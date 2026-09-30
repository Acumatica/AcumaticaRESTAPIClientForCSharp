using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.AuthApi.Model;
using Acumatica.RESTClient.Client;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.NonProductionLogin
{
    /// <summary>
    /// Logs in using the OAuth 2.0 password grant against the public OAuth client that Acumatica
    /// ships out of the box. That client is enabled only on non-production (demo/test) sites and
    /// is disabled on production ones, so this login method cannot be used against a production site.
    /// </summary>
    public static class ApiClientExtensions
	{
        // Well-known public client that Acumatica enables only on non-production sites.
        // It requires no client secret; the tenant to log into is selected by appending
        // the company name to the client ID.
        private const string ClientId = "2A8BDF43-8FC3-4A29-98C5-40F6701B85A7";
        private const string Scope = "api";

        /// <summary>
        /// Logs in to a non-production Acumatica site using the OAuth 2.0 password grant and the
        /// built-in public client. Throws if that client is disabled on the target site, which is
        /// always the case on production sites.
        /// </summary>
        /// <param name="client">The API client to authenticate.</param>
        /// <param name="username">Name of the user to log in as.</param>
        /// <param name="password">The user's password.</param>
        /// <param name="tenant">The tenant to log into.</param>
        /// <param name="branch">Not implemented. Accepted for signature parity only; has no effect.</param>
        /// <param name="locale">Not implemented. Accepted for signature parity only; has no effect.</param>
        public static void Login(this ApiClient client, string username, string password, string tenant = "Company", string? branch = null, string? locale = null)
        {
            LoginAsync(client, username, password, tenant, branch, locale).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Logs in to a non-production Acumatica site using the OAuth 2.0 password grant and the
        /// built-in public client. Throws if that client is disabled on the target site, which is
        /// always the case on production sites.
        /// </summary>
        /// <param name="client">The API client to authenticate.</param>
        /// <param name="username">Name of the user to log in as.</param>
        /// <param name="password">The user's password.</param>
        /// <param name="tenant">The tenant to log into.</param>
        /// <param name="branch">Not implemented. Accepted for signature parity only; has no effect.</param>
        /// <param name="locale">Not implemented. Accepted for signature parity only; has no effect.</param>
        /// <param name="cancellationToken"></param>
        public static async Task LoginAsync(
            this ApiClient client,
            string username,
            string password,
            string tenant = null,
			string? branch = null,
			string? locale = null,
			CancellationToken cancellationToken = default)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));
            if(string.IsNullOrEmpty(tenant))
				tenant = "Company";

			var clientId = $"{ClientId}@{tenant}";
            var time = DateTime.UtcNow;

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "identity/connect/token",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.None,
                contentType:        HeaderContentType.WwwForm,
                body:               await ToFormUrlEncodedAsync(new Dictionary<string, string>
                                    {
                                        { "grant_type", "password" },
                                        { "client_id", clientId },
                                        { "username", username },
                                        { "password", password },
                                        { "scope", Scope }
                                    }).ConfigureAwait(false),
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                throw new HttpRequestException(
                    $"OAuth2 password grant failed: {(int)response.StatusCode} {response.ReasonPhrase} - {content}. " +
                    "Note this login method relies on a public OAuth client that Acumatica enables only on non-production sites.");
            }

            client.Token = await DeserializeAsync<Token>(response).ConfigureAwait(false);
            client.Token?.SetTokenObtainedDT(time);
        }
    }
}
