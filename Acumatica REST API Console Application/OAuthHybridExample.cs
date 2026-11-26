using System;

using Acumatica.Default_24_200_001.Model;
using Acumatica.RESTClient.AuthApi.Model;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Loggers;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;
using static AcumaticaRestApiExample.OAuthExampleHelpers;

namespace AcumaticaRestApiExample
{
    internal class OAuthHybridExample
    {
        public static void Example(string siteURL, string clientSecret, string clientID, string redirectUrl)
        {
            var client = new ApiClient(siteURL,
               requestInterceptor: FileRequestLogger.LogRequest
            //   ,responseInterceptor: RequestLogger.LogResponse
            , ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );
            var url = client.Authorize(
                clientID,
                 redirectUrl,
                 OAuthScope.API | OAuthScope.OfflineAccess | OAuthScope.OpenID,
                 ResponseType.IdToken,// | ResponseType.Token,
                 ResponseMode.FormPost,//This is here to read the the Authorization data in backend
				 nonce: Guid.NewGuid().ToString()
                );
            OpenUrl(url);

            var code = ReadFormPostCallback(redirectUrl, out Token token);

            client.ReceiveAccessTokenAuthCode(
                clientID,
                clientSecret,
                redirectUrl,
                code);

            foreach (var account in client.GetList<Account>(top: 5))
            {
                Console.WriteLine(account.Description?.Value);
            }
            client.TryLogout();

            foreach (var soorder in client.GetList<SalesOrder>(top: 5))
            {
                Console.WriteLine(soorder.Description?.Value);
            }
            client.TryLogout();

        }
    }
}
