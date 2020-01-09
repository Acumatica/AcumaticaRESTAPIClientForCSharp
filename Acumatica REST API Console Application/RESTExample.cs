using Acumatica.Auth.Api;
using Acumatica.Auth.Model;
using Acumatica.DefaultEndpoint_18_200_001.Api;
using Acumatica.DefaultEndpoint_18_200_001.Model;
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
			var cookieContainer = new CookieContainer();
			authApi.Configuration.ApiClient.RestClient.CookieContainer = cookieContainer;
			try
			{
				LogIn(authApi, siteURL, username, password, tenant, branch, locale);

				var accountApi = new AccountApi();
				Console.WriteLine("Reading Accounts...");

				var accounts = accountApi.GetList(top: 5);

				foreach (var order in accounts)
				{
					Console.WriteLine("Account Nbr: " + order.AccountCD.Value + ";");
				}

				Console.WriteLine("ConfirmShipment");
				var shipmentApi = new ShipmentApi();
				var shipment= shipmentApi.GetByKeys(new List<string>() { "002805" });
				shipmentApi.InvokeAction(new ConfirmShipment(shipment));
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
			Console.ReadLine();
		}

		private static void LogIn(AuthApi authApi, string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			authApi.AuthLogin(new Credentials(username, password, tenant, branch, locale));
			Console.WriteLine("Logged In...");
			Configuration.Default = new Configuration(DefaultEndpoint_18_200_001.EndpointHelper.CombineEndpointURL(siteURL));

			//share cookie container between API clients because we use different client for authentication and interaction with endpoint
			Configuration.Default.ApiClient.RestClient.CookieContainer = authApi.Configuration.ApiClient.RestClient.CookieContainer;
		}
	}
}
