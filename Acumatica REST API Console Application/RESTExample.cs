using Acumatica.Auth.Api;
using Acumatica.Auth.Model;
using Acumatica.Default_20_200_001.Api;
using Acumatica.Default_20_200_001.Model;
using Acumatica.RESTClient.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AcumaticaRestApiExample
{
	public class RESTExample
	{
		public static void ExampleMethod(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			var authApi = new AuthApi(siteURL, 
				requestInterceptor: LogRequest, responseInterceptor: LogResponse);
			
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
				Console.WriteLine("Order Total: "+order.OrderTotal.Value);


				var shipmentApi = new ShipmentApi(configuration);
				var shipment= shipmentApi.GetByKeys(new List<string>() { "002805" });
				Console.WriteLine("ConfirmShipment");
				shipmentApi.WaitActionCompletion(shipmentApi.InvokeAction(new ConfirmShipment(shipment)));

				Console.WriteLine("CorrectShipment");
				shipmentApi.WaitActionCompletion(shipmentApi.InvokeAction(new CorrectShipment(shipment)));
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				//we use logout in finally block because we need to always logut, even if the request failed for some reason
				authApi.AuthLogout();
				Console.WriteLine("Logged Out...");
			}
		}
		private const string RequestsLogPath = "RequestsLog.txt";
		private static void LogResponse(RestRequest request, RestResponse response, RestClient restClient)
		{
			StreamWriter writer = new StreamWriter(RequestsLogPath, true);
			writer.WriteLine(DateTime.Now.ToString());
			writer.WriteLine("Response");
			writer.WriteLine("\tStatus code: " + response.StatusCode);
			writer.WriteLine("\tContent: " + response.Content);
			writer.WriteLine("-----------------------------------------");
			writer.WriteLine();
			writer.Flush();
			writer.Close();

		}

		private static void LogRequest(RestRequest request, RestClient restClient)
		{
			StreamWriter writer = new StreamWriter(RequestsLogPath, true);
			writer.WriteLine(DateTime.Now.ToString());
			writer.WriteLine("Request");
			writer.WriteLine("\tMethod: " + request.Method);
			string parameters = "";
			string body = "";
			foreach (var parametr in request.Parameters)
			{
				if (parametr.Type == ParameterType.QueryString)
				{
					parameters += String.IsNullOrEmpty(parameters) ? "?" : "&";
					parameters += parametr.Name + "=" + parametr.Value;
				}

				if (parametr.Type == ParameterType.RequestBody)
					body += parametr.Value;
			}

			writer.WriteLine("\tURL: " + restClient.BuildUri(request) + parameters);
			if (!String.IsNullOrEmpty(body))
				writer.WriteLine("\tBody: " + body);
			writer.WriteLine("-----------------------------------------");
			writer.WriteLine();
			writer.Flush();
			writer.Close();
		}
	}
}
