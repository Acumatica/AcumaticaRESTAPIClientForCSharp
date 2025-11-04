using System;
using System.Net;
using System.Net.Http;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;

using RESTClientTests.Mocks;

using Xunit;

namespace RESTClientTests
{
	public class DateTimeTests
	{
        [Theory]
        [InlineData("2025-08-18T00:00:00+00:00", 2025, 08, 18)]
        public void DateIsDeserializedInUTCTimeZone(
            string responseDate, int expectedYear, int expectedMonth, int expectedDay)
        {
            string response = $"{{\"Date\":{{\"value\":\"{responseDate}\"}}}}";
            DateTime expectedValue = new DateTime(expectedYear, expectedMonth, expectedDay);
            var client = new ApiClient(new HttpClientMock(async (request, ct) =>
               {
                   return new HttpResponseMessage(HttpStatusCode.OK)
                   { Content = new StringContent(response) };
               }));
            var order = client.GetById<SalesOrder>(new Guid());
            Assert.Equal(expectedValue, order!.Date!.Value!);
        }

        [Theory]
        [InlineData(2025, 08, 18, "2025-08-18T00:00:00")]
        public void DateIsSerializedInUTCTimeZone(int year, int month, int day, string expectedDateTime)
        {
            SalesOrder so = new SalesOrder()
            {
                Date = new DateTime(year, month, day)
            };

            var client = new ApiClient(
               new HttpClientMock(async (request, ct) =>
               {
                   string serializedContent = request.Content.ReadAsStringAsync().Result;
                   Assert.Contains($"Date\":{{\"value\":\"{expectedDateTime}\"", serializedContent);
                   return new HttpResponseMessage(HttpStatusCode.OK);
               }));
            var order = client.Put(so);
        }

        [Theory]
        [InlineData("2020-09-25T13:00:00-06:00", 2020, 09, 25, 19)]
        [InlineData("2020-09-25T20:00:00-06:00", 2020, 09, 26, 2)]
        [InlineData("2020-09-25T13:00:00", 2020, 09, 25, 13)]
        [InlineData("2020-09-25T13:00:00+04:00", 2020, 09, 25, 09)]
        [InlineData("2025-08-18T00:00:00+00:00", 2025, 08, 18, 00)]
        public void DateTimeIsDeserializedInUTCTimeZone(
            string responseDateTime, int expectedYear, int expectedMonth, int expectedDay, int expectedHour)
        {
            string response = $"{{\"DateTime\":{{\"value\":\"{responseDateTime}\"}}}}";
            DateTime expectedValue = new DateTime(expectedYear, expectedMonth, expectedDay, expectedHour, 0, 0);
            var client = new ApiClient(new HttpClientMock(async (request, ct) =>
               {
                   return new HttpResponseMessage(HttpStatusCode.OK)
                   { Content = new StringContent(response) };
               }));
            var appointment = client.GetById<Appointment>(new Guid());
            Assert.Equal(expectedValue, appointment!.DateTime!.Value!);
        }

        [Fact]
        public void DateTimeIsDeserializedAsUTCKind()
        {
            string response = $"{{\"DateTime\":{{\"value\":\"2020-09-25T13:00:00+04:00\"}}}}";
            var client = new ApiClient(
               new HttpClientMock(async (request, ct) =>
               {
                   return new HttpResponseMessage(HttpStatusCode.OK)
                   { Content = new StringContent(response) };
               }));
            var appointment = client.GetById<Appointment>(new Guid());
            Assert.Equal(DateTimeKind.Utc, appointment!.DateTime!.Value!.Value.Kind);
        }

        [Theory]
        [InlineData(2025, 08, 18, 00, "2025-08-18T00:00:00")]
        [InlineData(2025, 08, 18, 04, "2025-08-18T04:00:00")]
        public void DateTimeIsSerializedInUTCTimeZone(int year, int month, int day, int hour, string expectedDateTime)
        {
            Appointment appointment = new Appointment()
            {
                DateTime = new DateTime(year, month, day, hour, 0, 0)
            };

            var client = new ApiClient(new HttpClientMock(async (request, ct) =>
               {
                   string serializedContent = request.Content.ReadAsStringAsync().Result;
                   Assert.Contains($"DateTime\":{{\"value\":\"{expectedDateTime}\"", serializedContent);
                   return new HttpResponseMessage(HttpStatusCode.OK);
               }));
            var order = client.Put(appointment);
        }
    }
}
