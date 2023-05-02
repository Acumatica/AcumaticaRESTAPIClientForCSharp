
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Acumatica.Auth.Api;
using Acumatica.Default_20_200_001.Api;

namespace AcumaticaRestApiExample
{
    public class RESTExample
	{
		public static void ExampleMethod(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			var authApi = new AuthApi(siteURL,
				requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse
                );

            try
            {
                authApi.LogIn(username, password, tenant, branch, locale);

                Console.WriteLine("File Upload/Download");
                var salesOrderApi = new SalesOrderApi(authApi.ApiClient);
                var order = salesOrderApi.GetByKeys(new List<string>() { "SO", "SO005207" }, expand: "files");

                byte[] initialData = Encoding.UTF8.GetBytes("Acumatica is awesome");
                string fileName = "TestFile.txt";
                salesOrderApi.PutFile("SO/SO005207", fileName, initialData);

                order = salesOrderApi.GetByKeys(new List<string>() { "SO", "SO005207" }, expand: "files");

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
                if (authApi.TryLogout())
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
