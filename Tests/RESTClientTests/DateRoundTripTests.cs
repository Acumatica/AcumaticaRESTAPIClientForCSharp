using System;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

using RESTClientTests.Mocks;

using Xunit;

namespace RESTClientTests
{
    /// <summary>
    /// Checks that a date received from the server and sent back stays the same on the server.
    /// The server turns every offset into an instant, converts it to its own time zone and stores that,
    /// so the client only has to keep the instant (or, for date-only fields, the calendar date).
    /// </summary>
    public class DateRoundTripTests
    {
        private static ApiClient ClientReturning(string json, Action<string>? onRequestBody = null)
            => new ApiClient(new HttpClientMock(async (request, ct) =>
            {
                if (request.Content != null)
                    onRequestBody?.Invoke(await request.Content.ReadAsStringAsync().ConfigureAwait(false));
                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(json) };
            }));

        private static DateTime? ReadDateTime(string wireValue)
        {
            var client = ClientReturning($"{{\"DateTime\":{{\"value\":\"{wireValue}\"}}}}");
            return client.GetById<Appointment>(Guid.NewGuid())!.DateTime!.Value;
        }

        private static string SendDateTime(DateTime? value)
        {
            string sent = "";
            var client = ClientReturning("{}", body => sent = body);
            client.Put(new Appointment { DateTime = value });
            return sent;
        }

        private static DateTimeOffset InstantOf(string wire)
            => DateTimeOffset.Parse(wire, System.Globalization.CultureInfo.InvariantCulture);

        private static string WireValueOf(string requestBody)
            => Regex.Match(requestBody, "\"value\":\"([^\"]*)\"").Groups[1].Value;

        // ---- date + time fields (DateTimeValue) ----

        // Values the server sends: in the site's time zone, with the offset of that zone on that date.
        [Theory]
        [InlineData("2018-07-17T12:30:00-04:00")]   // summer, US Eastern
        [InlineData("2018-01-17T12:30:00-05:00")]   // winter, US Eastern
        [InlineData("2018-07-17T00:00:00-04:00")]   // a date shown as midnight
        [InlineData("2018-07-17T12:30:00+10:00")]   // a site east of UTC
        [InlineData("2018-07-17T00:00:00+10:00")]   // midnight at a site east of UTC
        [InlineData("2018-07-17T23:30:00-05:00")]   // late evening, UTC is already the next day
        [InlineData("2018-07-17T12:30:00.123-04:00")]
        [InlineData("2018-07-17T12:30:00Z")]
        public void DateTimeSentBackIsTheSameInstantThatWasReceived(string serverValue)
        {
            DateTime? received = ReadDateTime(serverValue);

            string sentBack = WireValueOf(SendDateTime(received));

            Assert.Equal(InstantOf(serverValue).UtcDateTime, InstantOf(sentBack).UtcDateTime);
        }

        [Fact]
        public void DateTimeReceivedIsSentBackWithTheUtcDesignator()
        {
            string sentBack = WireValueOf(SendDateTime(ReadDateTime("2018-07-17T12:30:00-04:00")));

            Assert.Equal("2018-07-17T16:30:00Z", sentBack);
        }

        // Kind decides what goes on the wire. The server reads an offset as an instant and a value without one as its own local time.
        [Theory]
        [InlineData(DateTimeKind.Utc, "2018-07-17T16:30:00Z")]
        [InlineData(DateTimeKind.Unspecified, "2018-07-17T16:30:00")]
        public void DateTimeKindDecidesWhetherAnOffsetIsSent(DateTimeKind kind, string expected)
        {
            string sent = WireValueOf(SendDateTime(new DateTime(2018, 7, 17, 16, 30, 0, kind)));

            Assert.Equal(expected, sent);
        }

        [Fact]
        public void LocalDateTimeIsSentWithTheLocalOffsetSoTheInstantIsKept()
        {
            var local = new DateTime(2018, 7, 17, 12, 30, 0, DateTimeKind.Local);

            string sent = WireValueOf(SendDateTime(local));

            Assert.Equal(new DateTimeOffset(local).UtcDateTime, InstantOf(sent).UtcDateTime);
        }

        // ---- date-only fields (DateOnlyValue) ----

        private static DateTime? ReadDate(string wireValue)
        {
            var client = ClientReturning($"{{\"Date\":{{\"value\":\"{wireValue}\"}}}}");
            return client.GetById<Invoice>(Guid.NewGuid())!.Date!.Value;
        }

        private static string SendDate(DateTime? value)
        {
            string sent = "";
            var client = ClientReturning("{}", body => sent = body);
            client.Put(new Invoice { Date = value });
            return sent;
        }

        // The 26.200.001 endpoint sends a bare date.
        [Theory]
        [InlineData("2018-07-17", 2018, 7, 17)]
        [InlineData("2018-12-31", 2018, 12, 31)]
        [InlineData("2020-02-29", 2020, 2, 29)]
        public void BareDateIsReadAsTheSameCalendarDate(string serverValue, int year, int month, int day)
        {
            DateTime? received = ReadDate(serverValue);

            Assert.Equal(new DateTime(year, month, day), received);
            Assert.Equal(DateTimeKind.Unspecified, received!.Value.Kind);
        }

        [Theory]
        [InlineData("2018-07-17")]
        [InlineData("2018-12-31")]
        [InlineData("2020-02-29")]
        public void DateOnlyValueSentBackIsTheSameBareDate(string serverValue)
        {
            string sentBack = WireValueOf(SendDate(ReadDate(serverValue)));

            Assert.Equal(serverValue, sentBack);
        }

        // The same field in older endpoints is sent as midnight with the site's offset.
        [Theory]
        [InlineData("2018-07-17T00:00:00-04:00", 2018, 7, 17)]
        [InlineData("2018-01-17T00:00:00-05:00", 2018, 1, 17)]
        [InlineData("2018-07-17T00:00:00", 2018, 7, 17)]
        [InlineData("2018-07-17T00:00:00Z", 2018, 7, 17)]
        public void DateOnlyValueReadsTheDateOfMidnightWithANegativeOrNoOffset(string serverValue, int year, int month, int day)
        {
            Assert.Equal(new DateTime(year, month, day), ReadDate(serverValue));
        }

        [Theory]
        [InlineData(DateTimeKind.Utc)]
        [InlineData(DateTimeKind.Local)]
        [InlineData(DateTimeKind.Unspecified)]
        public void DateOnlyValueIsSentAsTheCalendarDateOfTheValueWhateverItsKind(DateTimeKind kind)
        {
            string sent = WireValueOf(SendDate(new DateTime(2018, 7, 17, 23, 30, 0, kind)));

            Assert.Equal("2018-07-17", sent);
        }
    }
}
