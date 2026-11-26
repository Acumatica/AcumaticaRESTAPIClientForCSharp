using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

using Acumatica.Default_24_200_001.Model;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Loggers;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;

namespace AcumaticaRestApiExample
{
    internal class OAuthJWTExample
	{
        public static void Example(string siteURL, string jwk, string clientID, string redirectUrl)
        {
            var client = new ApiClient(siteURL,
                requestInterceptor: FileRequestLogger.LogRequest,
                responseInterceptor: FileRequestLogger.LogResponse
               //, ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );
            var url = client.Authorize(
                clientID,
                 redirectUrl,
				 OAuthScope.API | OAuthScope.OfflineAccess
				);
            OpenUrl(url);
			var callbackUrl = ReadCallbackUrl(redirectUrl);
			client.ReceiveAccessTokenJWT(clientID, jwk, callbackUrl);

            foreach (var account in client.GetList<Account>(top: 5))
            {
                Console.WriteLine(account.Description?.Value);
            }
            client.TryLogout();

        }
        //Example with PKCE, nonce, and state
        public static void Example2(string siteURL, string jwk, string clientID, string redirectUrl)
        {
			var client = new ApiClient(siteURL,
			   requestInterceptor: FileRequestLogger.LogRequest,
			   responseInterceptor: FileRequestLogger.LogResponse
			   //, ignoreSslErrors: true // this is here to allow testing with self-signed certificates
			   );

			string nonce = GenerateRandomValue();
            string state = GenerateRandomValue();
            string codeVerifier = GenerateRandomValue(32);
            string codeChallenge = CreateCodeChallenge(codeVerifier);

            var url = client.Authorize(
                      clientID,
                       redirectUrl,
                       OAuthScope.API | OAuthScope.OfflineAccess | OAuthScope.OpenID,
                       codeChallenge: codeChallenge,
                       nonce: nonce,
                       state: state
                );
            OpenUrl(url);
            var callbackUrl = ReadCallbackUrl(redirectUrl);

			client.ReceiveAccessTokenJWT(
                clientID,
                jwk,
                callbackUrl,
                codeVerifier: codeVerifier,
                expectedNonce: nonce,
                expectedState: state);

			foreach (var account in client.GetList<Account>(top: 5))
            {
                Console.WriteLine(account.Description?.Value);
            }
            client.TryLogout();
        }

        static string GenerateRandomValue(int byteCount = 32) =>
			Base64UrlEncode(RandomNumberGenerator.GetBytes(byteCount));

		static string Base64UrlEncode(byte[] data) =>
			Convert.ToBase64String(data).TrimEnd('=').Replace('+', '-').Replace('/', '_');

		static string CreateCodeChallenge(string codeVerifier) =>
			Base64UrlEncode(SHA256.HashData(Encoding.ASCII.GetBytes(codeVerifier)));
		

		
		private static Uri ReadCallbackUrl(string redirectUrl, TimeSpan? timeout = null)
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

		private static void OpenUrl(string url)
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
		
	}
}
