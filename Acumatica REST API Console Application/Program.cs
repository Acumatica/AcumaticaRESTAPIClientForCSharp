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
		const string SiteURL = "...";
		const string EndpointName = "Default";
		const string EndpointVersion = "18.200.001";
		const string Username = "admin";
		const string Password = "...";
		const string Tenant = null;

		static void Main(string[] args)
		{
			var authApi = new AuthApi(SiteURL);
			var cookieContainer = new CookieContainer();
			authApi.Configuration.ApiClient.RestClient.CookieContainer = cookieContainer;
			try
			{
				authApi.AuthLogin(new Credentials(Username, Password, Tenant));
				Console.WriteLine("Logged In...");
				Configuration.Default = authApi.Configuration;
				Configuration.Default.BasePath = SiteURL + "entity/" + EndpointName + "/" + EndpointVersion + "/";
				var soApi = new SalesOrderApi();
				Console.WriteLine("Readin Sales Orders...");
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
				authApi.Configuration.BasePath = SiteURL;
				authApi.AuthLogout();
				Console.WriteLine("Logged Out...");
			}
			Console.ReadLine();
		}
	}
}
