using System;
using System.IO;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.CustomizationApi;
using Acumatica.RESTClient.Loggers;

using AcumaticaRestApiExample;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;
using static Acumatica.RESTClient.CustomizationApi.CustomizationApiExtensions;

namespace AcumaticaRestApiExample
{
    public class CustomizationPublishingExample
    {
        public static void ImportAndPublishCustomization(string siteURL, string username, string password)
        {
            Console.WriteLine("Sign in");
            var client = new ApiClient(siteURL,
                requestInterceptor: FileRequestLogger.LogRequest,
                responseInterceptor: FileRequestLogger.LogResponse
                );
            try
            {
                client.Login(username, password);


                Console.WriteLine("Import customization package");
                using (var package = new FileStream("endpoint.zip", FileMode.Open))
                {
                    client.Import(package, "test");
                }

                Console.WriteLine("Start Publishing");
                client.PublishBegin("test");

                Console.WriteLine("Wait");
                client.WaitPublishingCompletion(millisecondsTimeout: 10 * 60 * 1000);


                Console.WriteLine("Done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Logging out");
                client.TryLogout();
            }

        }
    }
}
