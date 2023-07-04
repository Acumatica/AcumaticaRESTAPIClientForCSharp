
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Acumatica.Default_20_200_001.Api;
using Acumatica.Default_20_200_001.Model;
using Acumatica.RESTClient.Client;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;

namespace AcumaticaRestApiExample
{
    public class RESTExample
	{
		public static void ExampleMethod(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			var client = new ApiClient(siteURL,
				requestInterceptor: RequestLogger.LogRequest, 
                responseInterceptor: RequestLogger.LogResponse
                );

            try
            {
                client.Login(username, password, tenant, branch, locale);

                Console.WriteLine("File Upload/Download");
                var order = client.GetByKeys<SalesOrder>(new List<string>() { "SO", "SO005207" }, expand: "files");

                byte[] initialData = Encoding.UTF8.GetBytes("Acumatica is awesome");
                string fileName = "TestFile.txt";
                client.PutFile<SalesOrder>("SO/SO005207", fileName, initialData);

                order = client.GetByKeys<SalesOrder>(new List<string>() { "SO", "SO005207" }, expand: "files");

                if (order.Files.Any(fl => fl.Filename.EndsWith(@"\" + fileName)))
                {
                    Console.WriteLine($"The file {fileName} was uploaded successfully");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //we use logout in finally block because we need to always logout, even if the request failed for some reason
                if (client.TryLogout())
                {
                    Console.WriteLine("Logged out successfully.");
                }
                else
                {
                    Console.WriteLine("An error occured during logout.");
                }
            }
		}
	}
}
