using Acumatica.Default_24_200_001.Model;
using Acumatica.RESTClient.AuthApi.Model;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Loggers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;
using Task = System.Threading.Tasks.Task;

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
            bool usePost = true; //This is here to read the the Authorization data in backend
            var url = client.Authorize(
                clientID,
                clientSecret,
                 redirectUrl,
                 OAuthScope.API | OAuthScope.OfflineAccess | OAuthScope.OpenID,
                 ResponseType.IdToken,// | ResponseType.Token,
                 usePost,
                 Guid.NewGuid().ToString()
                );
            OpenUrl(url);

            var code = ReadCodeFromRedirectURL(redirectUrl, usePost, out Token token);

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

        private static string ReadCodeFromRedirectURL(string url, bool usePost, out Token token)
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
                if (usePost)
                {
                    using (System.IO.Stream body = context.Request.InputStream) // here we have data
                    {
                        using (var reader = new System.IO.StreamReader(body, context.Request.ContentEncoding))
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
                }
                else
                {
                    var rawUrl = request.RawUrl;
                    const string codeParametrIdentifier = "?code=";
                    var codewithgarbage = rawUrl.Substring(rawUrl.IndexOf(codeParametrIdentifier) + codeParametrIdentifier.Length);
                    purecode = codewithgarbage.Substring(0, codewithgarbage.IndexOf("&"));
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
