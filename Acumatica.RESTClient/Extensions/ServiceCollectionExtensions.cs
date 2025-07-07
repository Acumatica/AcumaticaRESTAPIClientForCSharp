using System;
using System.Net;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Acumatica.RESTClient
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureAcumaticaHttpClientHandler(
            this IServiceCollection serviceCollection,
            string acumaticaHttpClientName) =>
                serviceCollection.AddSingleton<Client.IHttpClientHandler>(
                    sp => new Client.HttpClientHandler(
                        sp.GetRequiredService<CookieContainer>(),
                        sp.GetRequiredService<IHttpClientFactory>(),
                        acumaticaHttpClientName));

        public static IServiceCollection ConfigureDefaultHttpClientHandler(
            this IServiceCollection serviceCollection,
            int timeout = 100000,
            bool ignoreSslErrors = false,
            string httpClientName = "HttpClient")
        {
            var cookies = new CookieContainer();

            serviceCollection
                .AddSingleton(_ => cookies)
                .AddHttpClient(
                    httpClientName,
                    c =>
                    {
                        c.Timeout = TimeSpan.FromMilliseconds(timeout);
                    })
                .ConfigurePrimaryHttpMessageHandler(
                    () => ignoreSslErrors
                        ? new HttpClientHandler
                        {
                            UseCookies = true,
                            CookieContainer = cookies,
                            ServerCertificateCustomValidationCallback =
                                (_, _, _, _) => true,
                        }
                        : new HttpClientHandler
                        {
                            UseCookies = true,
                            CookieContainer = cookies,
                        });

            return serviceCollection
                .ConfigureAcumaticaHttpClientHandler(httpClientName);
        }

        public static IServiceCollection ConfigureDefaultApiClient(
            this IServiceCollection serviceCollection,
            string basePath,
            int timeout = 100000,
            bool ignoreSslErrors = false,
            Action<HttpRequestMessage>? requestInterceptor = null,
            Action<HttpResponseMessage>? responseInterceptor = null) =>
                serviceCollection
                    .ConfigureDefaultHttpClientHandler(timeout, ignoreSslErrors)
                    .AddSingleton(sp =>
                        new Client.ApiClient(
                            basePath,
                            sp.GetRequiredService<Client.IHttpClientHandler>(),
                            requestInterceptor,
                            responseInterceptor));
    }
}
