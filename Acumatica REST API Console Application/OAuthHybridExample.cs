using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Web;

using Acumatica.Default_24_200_001.Model;
using Acumatica.RESTClient.AuthApi.Model;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Loggers;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;

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
				 Guid.NewGuid().ToString()
                );
            OpenUrl(url);

            var code = ReadCodeFromRedirectURL(redirectUrl, out Token token);

            client.ReceiveAccessTokenAuthCode(
                clientID,
                clientSecret,
                redirectUrl,
                code);

            foreach (var account in client.GetList<Account>(top: 5))
            {
                Console.WriteLine(account.Description.Value);
            }
            client.TryLogout();

            foreach (var soorder in client.GetList<SalesOrder>(top: 5))
            {
                Console.WriteLine(soorder.Description.Value);
            }
            client.TryLogout();

        }

        private static string ReadCodeFromRedirectURL(string url, out Token token)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(url);
            token = new Token();
            try
            {
                listener.Start();
                string purecode = string.Empty;

                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;

                using (Stream body = context.Request.InputStream) // here we have data
                {
                    using (var reader = new StreamReader(body, context.Request.ContentEncoding))
                    {
                        var values = HttpUtility.ParseQueryString(reader.ReadToEnd());
                        Console.WriteLine();
                        token.Access_token = values.Get("access_token");
                        token.Expires_in = values.Get("expires_in");
                        token.Token_type = values.Get("token_type");
                        token.Scope = values.Get("scope");
                        purecode = values.Get("code") ?? string.Empty;
                    }
                }

                return purecode;
            }
            finally
            {
                listener.Stop();
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
