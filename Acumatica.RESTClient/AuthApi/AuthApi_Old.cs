using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.AuthApi.Model;
using Acumatica.RESTClient.Client;

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;


namespace Acumatica.RESTClient.AuthApi
{
    public static partial class AuthApiExtensions
    {
		#region Public Methods
        #region Login
        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <param name="username">Name of the user that is used to open a new session (required).</param>
        /// <param name="password">User password (required).</param>
        /// <param name="tenant">Defines the tenant to log in.</param>
        /// <param name="branch">Defines the branch to log in.</param>
        /// <param name="locale">Defines the locale to use for localizable data.</param>
        [Obsolete("Use OAuth 2.0 methods instead.")]
        public static void Login(this ApiClient client, string username, string password, string? tenant = null, string? branch = null, string? locale = null)
        {
            Login(client, new Credentials(name: username, password: password, tenant: tenant, branch: branch, locale: locale));
        }

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <param name="username">Name of the user that is used to open a new session (required).</param>
        /// <param name="password">User password (required).</param>
        /// <param name="tenant">Defines the tenant to log in.</param>
        /// <param name="branch">Defines the branch to log in.</param>
        /// <param name="locale">Defines the locale to use for localizable data.</param>
        /// <param name="cancellationToken"></param>
        [Obsolete("Use OAuth 2.0 methods instead.")]
        public async static Task LoginAsync(this ApiClient client, 
            string username, string password, string? tenant = null, string? branch = null, string? locale = null,
            CancellationToken cancellationToken = default)
        {
            await LoginAsync(
                client:             client,
                credentials:        new Credentials(name: username, password: password, tenant: tenant, branch: branch, locale: locale),
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);
        }

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <param name="credentials">
        /// <see cref="Credentials"/> object that provides information required to log into the web service.
        /// </param>
        [Obsolete("Use OAuth 2.0 methods instead.")]
        public static void Login(this ApiClient client, Credentials credentials)
        {
           LoginAsync(client, credentials).GetAwaiter().GetResult();
		}

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <param name="credentials">
        /// <see cref="Credentials"/> object that provides information required to log into the web service.
        /// </param>
        /// <param name="cancellationToken"></param>
        [Obsolete("Use OAuth 2.0 methods instead.")]
        public async static Task LoginAsync(
            this ApiClient client, 
            Credentials credentials, 
            CancellationToken cancellationToken = default)
        {
            if (credentials == null)
                ThrowMissingParameter(nameof(LoginAsync), nameof(credentials));

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "/entity/auth/login",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.None,
                contentType:        HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm,
                body:               credentials,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(client, response, nameof(LoginAsync)).ConfigureAwait(false);
        }
        #endregion
        #endregion

    }
}