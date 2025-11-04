using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;

using RESTClientTests.Mocks;

using Xunit;

namespace RESTClientTests
{
    public class QueryableTests
    {
        [Fact]
        public void AsQueryable_WithSimpleWhereClause_GeneratesCorrectFilter()
        {
            string? capturedFilter = null;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    capturedFilter = GetQueryParameter(request.RequestUri, "$filter");
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));

            var query = client.GetList<SalesOrder>(asQueryable: true)
                .Where(so => so.Date.Value == new DateTime(2024, 1, 1));

            var result = query.ToList();

            Assert.NotNull(capturedFilter);
            Assert.Contains("Date/value", capturedFilter);
            Assert.Contains("eq", capturedFilter);
            Assert.Contains("2024-01-01", capturedFilter);
        }

        [Fact]
        public void AsQueryable_WithMultipleWhereConditions_GeneratesCorrectFilter()
        {
            string? capturedFilter = null;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    capturedFilter = GetQueryParameter(request.RequestUri, "$filter");
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));

            var query = client.GetList<SalesOrder>(asQueryable: true)
                .Where(so => so.Date.Value == new DateTime(2024, 1, 1))
                .Where(so => so.Date.Value > new DateTime(2023, 12, 31));

            var result = query.ToList();

            Assert.NotNull(capturedFilter);
            Assert.Contains("Date/value", capturedFilter);
            Assert.Contains("eq", capturedFilter);
            Assert.Contains("2024-01-01", capturedFilter);
            Assert.Contains("and", capturedFilter);
            Assert.Contains("gt", capturedFilter);
            Assert.Contains("2023-12-31", capturedFilter);
        }

        [Fact]
        public void AsQueryable_WithAndCondition_GeneratesCorrectFilter()
        {
            string? capturedFilter = null;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    capturedFilter = GetQueryParameter(request.RequestUri, "$filter");
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));

            var minDate = new DateTime(2023, 12, 31);
            var maxDate = new DateTime(2024, 1, 1);
            var query = client.GetList<SalesOrder>(asQueryable: true)
                .Where(so => so.Date.Value > minDate && so.Date.Value == maxDate);

            var result = query.ToList();

            Assert.NotNull(capturedFilter);
            Assert.Contains("Date/value", capturedFilter);
            Assert.Contains("gt", capturedFilter);
            Assert.Contains("2023-12-31", capturedFilter);
            Assert.Contains("and", capturedFilter);
            Assert.Contains("eq", capturedFilter);
            Assert.Contains("2024-01-01", capturedFilter);
        }

        [Fact]
        public void AsQueryable_WithTake_GeneratesCorrectTopParameter()
        {
            string? capturedTop = null;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    capturedTop = GetQueryParameter(request.RequestUri, "$top");
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));

            var query = client.GetList<SalesOrder>(asQueryable: true)
                .Take(5);

            var result = query.ToList();

            Assert.Equal("5", capturedTop);
        }

        [Fact]
        public void AsQueryable_WithSkip_GeneratesCorrectSkipParameter()
        {
            string? capturedSkip = null;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    capturedSkip = GetQueryParameter(request.RequestUri, "$skip");
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));

            var query = client.GetList<SalesOrder>(asQueryable: true)
                .Skip(10);

            var result = query.ToList();

            Assert.Equal("10", capturedSkip);
        }

        [Fact]
        public void AsQueryable_WithSkipAndTake_GeneratesCorrectParameters()
        {
            string? capturedSkip = null;
            string? capturedTop = null;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    capturedSkip = GetQueryParameter(request.RequestUri, "$skip");
                    capturedTop = GetQueryParameter(request.RequestUri, "$top");
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));

            var query = client.GetList<SalesOrder>(asQueryable: true)
                .Skip(10)
                .Take(5);

            var result = query.ToList();

            Assert.Equal("10", capturedSkip);
            Assert.Equal("5", capturedTop);
        }

        [Fact]
        public void AsQueryable_WithCombinedConditions_GeneratesCorrectParameters()
        {
            string? capturedFilter = null;
            string? capturedTop = null;
            string? capturedSkip = null;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    capturedFilter = GetQueryParameter(request.RequestUri, "$filter");
                    capturedTop = GetQueryParameter(request.RequestUri, "$top");
                    capturedSkip = GetQueryParameter(request.RequestUri, "$skip");
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));

            var query = client.GetList<SalesOrder>(asQueryable: true)
                .Where(so => so.Date.Value == new DateTime(2024, 1, 1))
                .Skip(5)
                .Take(10);

            var result = query.ToList();

            Assert.NotNull(capturedFilter);
            Assert.Contains("Date", capturedFilter);
            Assert.Contains("eq", capturedFilter);
            Assert.Contains("2024-01-01", capturedFilter);
            Assert.Equal("10", capturedTop);
            Assert.Equal("5", capturedSkip);
        }

        [Fact]
        public void AsQueryable_WithCombinedConditionsGT_GeneratesCorrectParameters()
        {
            string? capturedFilter = null;
            string? capturedTop = null;
            string? capturedSkip = null;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    capturedFilter = GetQueryParameter(request.RequestUri, "$filter");
                    capturedTop = GetQueryParameter(request.RequestUri, "$top");
                    capturedSkip = GetQueryParameter(request.RequestUri, "$skip");
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));

            var query = client.GetList<SalesOrder>(asQueryable: true)
                .Where(so => so.Date > new DateTime(2024, 1, 1))
                .Skip(5)
                .Take(10);

            var result = query.ToList();

            Assert.NotNull(capturedFilter);
            Assert.Contains("Date", capturedFilter);
            Assert.Contains("gt", capturedFilter);
            Assert.Contains("2024-01-01", capturedFilter);
            Assert.Equal("10", capturedTop);
            Assert.Equal("5", capturedSkip);
        }

        [Fact]
        public async Task AsQueryable_WithToListAsync_ExecutesAsynchronously()
        {
            bool executed = false;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    executed = true;
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));

            var query = (EntityQueryable<SalesOrder>)client.GetList<SalesOrder>(asQueryable: true)
                .Where(so => so.Date.Value == new DateTime(2024, 1, 1));

            var result = await query.ToListAsync();

            Assert.True(executed);
            Assert.NotNull(result);
        }

        [Fact]
        public void AsQueryable_WithInitialFilter_CombinesFilters()
        {
            string? capturedFilter = null;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    capturedFilter = GetQueryParameter(request.RequestUri, "$filter");
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));

            var query = client.GetList<SalesOrder>(asQueryable: true, filter: "OrderNbr eq 'SO1234'")
                .Where(so => so.Date.Value == new DateTime(2024, 1, 1));

            var result = query.ToList();

            Assert.NotNull(capturedFilter);
            Assert.Contains("OrderNbr", capturedFilter);
            Assert.Contains("SO1234", capturedFilter);
            Assert.Contains("and", capturedFilter);
            Assert.Contains("Date/value", capturedFilter);
            Assert.Contains("2024-01-01", capturedFilter);
        }

        [Fact]
        public async Task AsQueryable_WithFirstAsync_GeneratesTopOne()
        {
            string? capturedTop = null;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    capturedTop = GetQueryParameter(request.RequestUri, "$top");
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[{\"Date\": {\"value\": \"2024-01-01T00:00:00\"}}]") };
                }));

            var query = (EntityQueryable<SalesOrder>)client.GetList<SalesOrder>(asQueryable: true)
                .Where(so => so.Date.Value == new DateTime(2024, 1, 1));

            var result = await query.FirstOrDefaultAsync();

            Assert.Equal("1", capturedTop);
        }

        [Fact]
        public async Task AsQueryable_WithCountAsync_ExecutesQuery()
        {
            bool executed = false;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    executed = true;
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[{\"Date\": {\"value\": \"2024-01-01T00:00:00\"}}, {\"Date\": {\"value\": \"2024-01-02T00:00:00\"}}]") };
                }));

            var query = (EntityQueryable<SalesOrder>)client.GetList<SalesOrder>(asQueryable: true)
                .Where(so => so.Date.Value > new DateTime(2023, 12, 31));

            var count = await query.CountAsync();

            Assert.True(executed);
            Assert.Equal(2, count);
        }

        [Fact]
        public void AsQueryable_SupportsEnumerationDirectly()
        {
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[{\"Date\": {\"value\": \"2024-01-01T00:00:00\"}}]") };
                }));

            var query = client.GetList<SalesOrder>(asQueryable: true);

            int count = 0;
            foreach (var item in query)
            {
                count++;
            }

            Assert.Equal(1, count);
        }

        [Fact]
        public void AsQueryable_WithComplexLinqQuery_GeneratesCorrectParameters()
        {
            string? capturedFilter = null;
            string? capturedTop = null;
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    capturedFilter = GetQueryParameter(request.RequestUri, "$filter");
                    capturedTop = GetQueryParameter(request.RequestUri, "$top");
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));

            var startDate = new DateTime(2024, 1, 1);
            var endDate = new DateTime(2024, 12, 31);

            var result = client.GetList<SalesOrder>(asQueryable: true)
                .Where(so => so.Date.Value >= startDate && so.Date.Value <= endDate)
                .Take(100)
                .ToList();

            Assert.NotNull(capturedFilter);
            Assert.Contains("Date/value", capturedFilter);
            Assert.Contains("ge", capturedFilter);
            Assert.Contains("2024-01-01", capturedFilter);
            Assert.Contains("le", capturedFilter);
            Assert.Contains("2024-12-31", capturedFilter);
            Assert.Contains("and", capturedFilter);
            Assert.Equal("100", capturedTop);
        }

        private string? GetQueryParameter(Uri? uri, string parameterName)
        {
            if (uri == null) return null;

            var query = uri.Query;
            if (string.IsNullOrEmpty(query)) return null;

            var parameters = query.TrimStart('?').Split('&');
            foreach (var param in parameters)
            {
                var parts = param.Split('=');
                if (parts.Length == 2 && parts[0] == parameterName)
                {
                    return Uri.UnescapeDataString(parts[1]);
                }
            }

            return null;
        }
    }
}
