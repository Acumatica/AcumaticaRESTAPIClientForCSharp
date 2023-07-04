using System;
using System.IO;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.CustomizationApi;

using AcumaticaRestApiExample;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;
using static Acumatica.RESTClient.CustomizationApi.CustomizationApi;

namespace Acumatica_REST_API_Example_Console_Application
{
    public class CustomizationPublishingExample
    {
        public static void ImportAndPublishCustomization(string siteURL, string username, string password)
        {
            Console.WriteLine("Sign in");
            var client = new ApiClient(siteURL,
                requestInterceptor: RequestLogger.LogRequest,
                responseInterceptor: RequestLogger.LogResponse
                );
            try
            {
                client.Login(username, password);


                Console.WriteLine("Import customization package");
                client.Import(new FileStream("endpoint.zip", FileMode.Open), "test");

                Console.WriteLine("Start Publishing");
                client.PublishBegin("test");

                Console.WriteLine("Wait");
                client.WaitPublishingCompletion();


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
