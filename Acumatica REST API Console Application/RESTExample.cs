using Acumatica.Auth.Api;
using Acumatica.Default_20_200_001.Api;
using Acumatica.Default_20_200_001.Model;
using System;
using System.Collections.Generic;

namespace AcumaticaRestApiExample
{
	public class RESTExample
	{
		public static void ExampleMethod(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			var authApi = new AuthApi(siteURL,
				requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);

			try
			{
				var configuration = authApi.LogIn(username, password, tenant, branch, locale);

				Console.WriteLine("Reading Accounts...");
				var accountApi = new AccountApi(configuration);
				var accounts = accountApi.GetList(top: 5);
				foreach (var account in accounts)
				{
					Console.WriteLine("Account Nbr: " + account.AccountCD.Value + ";");
				}

				Console.WriteLine("Reading Sales Order by Keys...");
				var salesOrderApi = new SalesOrderApi(configuration);
				var order = salesOrderApi.GetByKeys(new List<string>() { "SO", "SO005207" });
				Console.WriteLine("Order Total: " + order.OrderTotal.Value);


				var shipmentApi = new ShipmentApi(configuration);
				var shipment = shipmentApi.GetByKeys(new List<string>() { "002805" });
				Console.WriteLine("ConfirmShipment");
				shipmentApi.WaitActionCompletion(shipmentApi.InvokeAction(new ConfirmShipment(shipment)));

				Console.WriteLine("CorrectShipment");
				shipmentApi.WaitActionCompletion(shipmentApi.InvokeAction(new CorrectShipment(shipment)));

                Console.WriteLine("File Uploade/Download");
                order = salesOrderApi.GetByKeys(new List<string>() { "SO", "SO005207"}, expand: "files");

                byte[] initialData = Encoding.UTF8.GetBytes("Acumatica is awesome");
                string fileName = "TestFile.txt";
                salesOrderApi.PutFile("SO/SO005207", fileName, initialData);
                
                order = salesOrderApi.GetByKeys(new List<string>() { "SO", "SO005207" }, expand: "files");

                if (order.Files.Any(fl => fl.Filename.EndsWith(@"\" + fileName))){
                    Console.WriteLine($"The file {fileName} was uploaded sucessfully");
                }

                Uri basePath = new Uri(siteURL);

                foreach (FileLink fileLink in order.Files)
                {
                    var test = configuration.BasePath + fileLink.Href;
                    var content = authApi.Configuration.ApiClient.RestClient.DownloadData(new RestRequest(basePath.Scheme+ "://" + basePath.Authority + fileLink.Href));
                    if (content != null && fileLink.Filename.EndsWith(@"\" + fileName))
                    {
                        if (content.SequenceEqual(initialData))
                        {
                            Console.WriteLine("The data is valid: " + Encoding.UTF8.GetString(content));
                        }
                        else
                        {
                            Console.WriteLine($"The file was corrupted: \r\n Intial \r\n {Encoding.UTF8.GetString(initialData)} \r\n  vs Current: \r\n {Encoding.UTF8.GetString(content)}");
                        }
                    }
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
