using FluentAssertions;
using System.Linq;
using Xunit;
using System;
using System.Globalization;

using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using RESTClientTests.Mocks;
using System.Net.Http;
using System.Net;

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
            var client = new ApiClient("http://localhost/23r211/",
               new HttpClientHandlerMock(request =>
               {
                   return new HttpResponseMessage(HttpStatusCode.OK)
                   { Content = new StringContent(response) };
               }));
            var order = client.GetById<SalesOrder>(new Guid());
            order!.Date!.Value!.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(2025, 08, 18, "2025-08-18T00:00:00")]
        public void DateIsSerializedInUTCTimeZone(int year, int month, int day, string expectedDateTime)
        {
            SalesOrder so = new SalesOrder()
            {
                Date = new DateTime(year, month, day)
            };

            var client = new ApiClient("http://localhost/23r211/",
               new HttpClientHandlerMock(request =>
               {
                   string serializedContent = request.Content.ReadAsStringAsync().Result;
                   serializedContent.Should().Contain($"Date\":{{\"value\":\"{expectedDateTime}\"");
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
            var client = new ApiClient("http://localhost/23r211/",
               new HttpClientHandlerMock(request =>
               {
                   return new HttpResponseMessage(HttpStatusCode.OK)
                   { Content = new StringContent(response) };
               }));
            var appointment = client.GetById<Appointment>(new Guid());
            appointment!.DateTime!.Value!.Should().Be(expectedValue);
        }

        [Fact]
        public void DateTimeIsDeserializedAsUTCKind()
        {
            string response = $"{{\"DateTime\":{{\"value\":\"2020-09-25T13:00:00+04:00\"}}}}";
            var client = new ApiClient("http://localhost/23r211/",
               new HttpClientHandlerMock(request =>
               {
                   return new HttpResponseMessage(HttpStatusCode.OK)
                   { Content = new StringContent(response) };
               }));
            var appointment = client.GetById<Appointment>(new Guid());
            appointment!.DateTime!.Value!.Value.Kind.Should().Be(DateTimeKind.Utc);
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

            var client = new ApiClient("http://localhost/23r211/",
               new HttpClientHandlerMock(request =>
               {
                   string serializedContent = request.Content.ReadAsStringAsync().Result;
                   serializedContent.Should().Contain($"DateTime\":{{\"value\":\"{expectedDateTime}\"");
                   return new HttpResponseMessage(HttpStatusCode.OK);
               }));
            var order = client.Put(appointment);
        }
    }
}
