using Acumatica.Auth.Api;
using Acumatica.Auth.Model;
using Acumatica.Default_18_200_001.Api;
using Acumatica.Default_18_200_001.Model;
using Acumatica.RESTClient.Client;
using System;
using System.Collections.Generic;
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
			var authApi = new AuthApi(siteURL);
			
			try
			{
				var configuration = LogIn(authApi, siteURL, username, password, tenant, branch, locale);

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

		private static Configuration LogIn(AuthApi authApi, string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			var cookieContainer = new CookieContainer();
			authApi.Configuration.ApiClient.RestClient.CookieContainer = cookieContainer;

			authApi.AuthLogin(new Credentials(username, password, tenant, branch, locale));
			Console.WriteLine("Logged In...");
			var configuration =  new Configuration(DefaultEndpoint_18_200_001.EndpointHelper.CombineEndpointURL(siteURL));

			//share cookie container between API clients because we use different client for authentication and interaction with endpoint
			configuration.ApiClient.RestClient.CookieContainer = authApi.Configuration.ApiClient.RestClient.CookieContainer;
			return configuration;
		}
	}
}
