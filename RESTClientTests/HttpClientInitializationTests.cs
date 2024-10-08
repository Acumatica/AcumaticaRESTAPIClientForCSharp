using System;

using Acumatica.RESTClient.Client;

using FluentAssertions;

using Xunit;

namespace RESTClientTests
{
    public class HttpClientInitializationTests
    {
        [Fact]

        public void Timeout_IsSetToHttpClient()
        {
            int timeout = 123;
            int timeout2 = 456;
            var client = new ApiClient("https://localhost", timeout);
            var client2 = new ApiClient("https://localhost", timeout2);
            (client.HttpClient as HttpClientHandler)!.GetHttpClient().Timeout.Should().Be(new TimeSpan(0, 0, 0, 0, timeout));
            (client2.HttpClient as HttpClientHandler)!.GetHttpClient().Timeout.Should().Be(new TimeSpan(0, 0, 0, 0, timeout2));
        }
    }
}

