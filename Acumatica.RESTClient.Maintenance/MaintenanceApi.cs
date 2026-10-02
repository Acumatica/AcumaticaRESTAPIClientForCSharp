using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.MaintenanceApi
{
    public static class MaintenanceApi
    {
        public static async Task PutSchemaAsync(this ApiClient client, string endpointXML, CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "/entity/maintenance/23.200/",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.Xml,
                contentType:        HeaderContentType.Xml,
                body:               endpointXML,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(PutSchemaAsync)).ConfigureAwait(false);
        }
        public static void PutSchema(this ApiClient client, string endpointXML)
        {
            PutSchemaAsync(client, endpointXML).GetAwaiter().GetResult();
        }


        /// <summary>
        /// Reads the schema of an endpoint.
        /// </summary>
        /// <returns>
        /// The endpoint schema XML, or <c>null</c> if the endpoint does not exist.
        /// </returns>
        /// <exception cref="ApiException">
        /// Thrown when the request fails for any reason other than the endpoint not existing.
        /// </exception>
        public static async Task<string?> GetSchemaAsync(this ApiClient client, string endpointName, string endpointVersion,
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"/entity/maintenance/23.200/{endpointName}/{endpointVersion}",
                method:             HttpMethod.Get,
                acceptType:         HeaderContentType.Xml,
                contentType:        HeaderContentType.Xml,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            // A missing endpoint is reported as an absent schema rather than as an exception, so
            // that callers can probe for one without having to swallow transport and
            // authentication failures along with it.
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }

            await VerifyResponseAsync(response, nameof(GetSchemaAsync)).ConfigureAwait(false);
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }
        /// <summary>
        /// Reads the schema of an endpoint.
        /// </summary>
        /// <returns>
        /// The endpoint schema XML, or <c>null</c> if the endpoint does not exist.
        /// </returns>
        /// <exception cref="ApiException">
        /// Thrown when the request fails for any reason other than the endpoint not existing.
        /// </exception>
        public static string? GetSchema(this ApiClient client, string endpointName, string endpointVersion)
        {
            return GetSchemaAsync(client, endpointName, endpointVersion).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Throws an <see cref="ApiException"/> carrying the status code and the response body
        /// when the request did not succeed.
        /// </summary>
        /// <remarks>
        /// The body is placed in the message instead of being passed as the <c>errorContent</c>
        /// argument of <see cref="ApiException"/>: that constructor parses the content as JSON and
        /// replaces it with the message when parsing fails, and the endpoint maintenance API
        /// answers with XML. The body is the only place the server explains why a schema was
        /// rejected, so it must not be discarded.
        /// </remarks>
        private static async Task VerifyResponseAsync(HttpResponseMessage response, string methodName)
        {
            if (response.IsSuccessStatusCode)
            {
                return;
            }

            string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            throw new ApiException(
                (int)response.StatusCode,
                $"Error {(int)response.StatusCode} calling {methodName}: {response.ReasonPhrase}{Environment.NewLine}{responseBody}");
        }
    }
}