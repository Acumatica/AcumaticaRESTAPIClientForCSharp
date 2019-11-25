using Acumatica.Auth.Api;
using Acumatica.Auth.Model;
using Acumatica.DefaultEndpoint.Api;
using Acumatica.RESTClient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Acumatica_REST_API_Console_Application
{
	class Program
	{
		const string SiteURL = "http://example.com/";
		const string Username = "admin";
		const string Password = "123";
		const string Tenant = null;

		static void Main(string[] args)
		{
			var authApi = new AuthApi(SiteURL);
			var cookieContainer = new CookieContainer();
			authApi.Configuration.ApiClient.RestClient.CookieContainer = cookieContainer;
			try
			{
				LogIn(authApi); 

				var soApi = new SalesOrderApi();
				Console.WriteLine("Reading Sales Orders...");

				var soOrders = soApi.SalesOrderGetList(top: 5);

				foreach (var order in soOrders)
				{
					Console.WriteLine("Order Type: " + order.OrderType.Value + "; Order Number: " + order.OrderNbr.Value);
				}
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

		private static void LogIn(AuthApi authApi)
		{
			authApi.AuthLogin(new Credentials(Username, Password, Tenant));
			Console.WriteLine("Logged In...");
			Configuration.Default = new Configuration(Default._18._200._001.EndpointHelper.CombineEndpointURL(SiteURL));

			//share cookie container between API clients because we use different client for authentication and interaction with endpoint
			Configuration.Default.ApiClient.RestClient.CookieContainer = authApi.Configuration.ApiClient.RestClient.CookieContainer;
		}
	}
}
