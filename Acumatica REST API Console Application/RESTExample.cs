using Acumatica.Auth.Api;
using Acumatica.Default_20_200_001.Api;
using Acumatica.Default_20_200_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AcumaticaRestApiExample
{
	public class RESTExample
	{
		public static void ExampleMethod(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			List<Thread> threadpool = new List<Thread>();
			for (int i = 0; i < 55; i++)
			{
				var thread = new Thread(() =>
				{
					Thread.CurrentThread.IsBackground = true;

					ReadThings(username, password, tenant, branch, locale, siteURL, i);
				});
				thread.Start();
				threadpool.Add(thread);
			}
			while (threadpool.Any(_ => _.IsAlive))
			{
				Console.WriteLine($"{threadpool.Count(_ => _.IsAlive)} sessions running");
                Thread.Sleep(5000);
            }
			Console.WriteLine("All threads completed");
		}

		private static void ReadThings(string username, string password, string tenant, string branch, string locale, string siteURL, int i)
		{
            var authApi = new AuthApi(siteURL,
				//requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse,
				timeout: 20000000);
            try
			{
				var configuration = authApi.LogIn(username, password, tenant, branch, locale);

				Console.WriteLine($"Thread #{i} - Reading Accounts...");
				var accountApi = new AccountApi(configuration);
				var accounts = accountApi.GetList();


				Console.WriteLine($"Thread #{i} - Reading Sales Orders...");
				var salesOrderApi = new SalesOrderApi(configuration);
				var order = salesOrderApi.GetList();
			}
			catch (Exception e)
			{
				Console.WriteLine($"Thread #{i} - " + e.Message);

            }
			finally
			{
				//we use logout in finally block because we need to always logout, even if the request failed for some reason
				if (authApi.TryLogout())
				{
					Console.WriteLine($"Thread #{i} - Logged out successfully.");
				}
				else
				{
					 Console.WriteLine($"Thread #{i} - An error occured during logout.");
				}
			}
		}
	}
}
