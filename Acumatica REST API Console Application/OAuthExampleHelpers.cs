using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Web;

using Acumatica.RESTClient.AuthApi.Model;

namespace AcumaticaRestApiExample
{
    /// <summary>
    /// Helpers shared by the OAuth 2.0 examples: opening the sign-in page, receiving the redirect
    /// and generating the PKCE, nonce and state values.
    /// </summary>
    internal static class OAuthExampleHelpers
    {
        /// <summary>
        /// Opens the URL in the default browser.
        /// </summary>
        public static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Listens on the redirect URL until the browser is redirected to it, and returns the full callback URL
        /// (including the authorization response in its query string or fragment).
        /// </summary>
        /// <param name="redirectUrl">The redirect URL registered for the client. It must end with '/'.</param>
        /// <param name="timeout">How long to wait for the redirect. The default is 5 minutes.</param>
        public static Uri ReadCallbackUrl(string redirectUrl, TimeSpan? timeout = null)
        {
            var listener = new HttpListener();
            listener.Prefixes.Add(redirectUrl);          // must end with '/'
            try
            {
                listener.Start();
                var contextTask = listener.GetContextAsync();
                if (!contextTask.Wait(timeout ?? TimeSpan.FromMinutes(5)))
                    throw new TimeoutException("No authorization response received.");

                HttpListenerContext context = contextTask.Result;
                byte[] page = Encoding.UTF8.GetBytes("<html><body>You can close this window.</body></html>");
                context.Response.ContentType = "text/html; charset=utf-8";
                context.Response.ContentLength64 = page.Length;
                context.Response.OutputStream.Write(page, 0, page.Length);
                context.Response.OutputStream.Close();

                return context.Request.Url ?? throw new InvalidOperationException("Request URL is null.");
            }
            finally
            {
                listener.Close();
            }
        }

        /// <summary>
        /// Listens on the redirect URL for the form post that the identity server sends when the
        /// authorization request uses <c>ResponseMode.FormPost</c>. Returns the authorization code and
        /// outputs whatever token data (access token, expiration, type, scope) came with the response.
        /// </summary>
        /// <param name="redirectUrl">The redirect URL registered for the client. It must end with '/'.</param>
        /// <param name="token">The token data that was posted along with the code. Its fields are empty when the response has none.</param>
        /// <returns>The authorization code, or an empty string when the response has none.</returns>
        public static string ReadFormPostCallback(string redirectUrl, out Token token)
        {
            var listener = new HttpListener();
            listener.Prefixes.Add(redirectUrl);          // must end with '/'
            token = new Token();
            try
            {
                listener.Start();

                HttpListenerContext context = listener.GetContext();
                using Stream body = context.Request.InputStream;
                using var reader = new StreamReader(body, context.Request.ContentEncoding);

                var values = HttpUtility.ParseQueryString(reader.ReadToEnd());
                token.Access_token = values.Get("access_token");
                token.Expires_in = values.Get("expires_in");
                token.Token_type = values.Get("token_type");
                token.Scope = values.Get("scope");
                return values.Get("code") ?? string.Empty;
            }
            finally
            {
                listener.Stop();
            }
        }
        /// <summary>
        /// Generates a random URL-safe value for the nonce, state or PKCE code verifier.
        /// </summary>
        public static string GenerateRandomValue(int byteCount = 32) =>
            Base64UrlEncode(RandomNumberGenerator.GetBytes(byteCount));

        /// <summary>
        /// Creates the PKCE code challenge (S256) for the code verifier.
        /// </summary>
        public static string CreateCodeChallenge(string codeVerifier) =>
            Base64UrlEncode(SHA256.HashData(Encoding.ASCII.GetBytes(codeVerifier)));

        private static string Base64UrlEncode(byte[] data) =>
            Convert.ToBase64String(data).TrimEnd('=').Replace('+', '-').Replace('/', '_');
    }
}
