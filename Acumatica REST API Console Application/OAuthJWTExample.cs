using System;

using Acumatica.Default_24_200_001.Model;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Loggers;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;
using static AcumaticaRestApiExample.OAuthExampleHelpers;

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

	}
}
