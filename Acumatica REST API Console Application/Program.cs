using System;
using System.Diagnostics;
using System.Threading.Tasks;

using AcumaticaRestApiExample.Properties;

namespace AcumaticaRestApiExample
{
	class Program
	{
		// Every value below comes from Project Properties > Settings (App.config).

        static async Task Main(string[] args)
		{
			RESTExamples_24();
			RESTExamples_26();

			Console.WriteLine("REST API (Extended Endpoint) example");
			Console.WriteLine("----------------------------------------");
			ExtendedEndpointExample.ExampleMethod(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("\r\nReady to continue...");
			Console.ReadLine();

			Console.WriteLine("OData GI example");
			Console.WriteLine("----------------------------------------");
			ODataExample.ODataGetGI(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant);
			ODataExample.ODataGetGINewUrl(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant);
			Console.WriteLine("Ready to continue...");
			Console.ReadLine();

			Console.WriteLine("OData DAC example");
			Console.WriteLine("----------------------------------------");
			ODataExample.ODataGetDAC(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant);
			ODataExample.ODataGetDACNewUrl(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant);
			Console.WriteLine("Ready to continue...");
			Console.ReadLine();

			Console.WriteLine("OData OAuth 2.0 (Resource Owner Password Credentials flow) example");
			Console.WriteLine("----------------------------------------");
			ODataExample.OauthExample(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.ClientSecretROPC, Settings.Default.ClientIDROPC, Settings.Default.Tenant);
			Console.WriteLine("Ready to continue...");
			Console.ReadLine();

			Console.WriteLine("OAuth 2.0 (Authorization Code flow)");
			Console.WriteLine("----------------------------------------");
			OAuthAuthCodeExample.Example(Settings.Default.SiteURL, Settings.Default.ClientSecretAC, Settings.Default.ClientIDAC, Settings.Default.RedirectUrl);
			Console.WriteLine("Ready to continue...");
			Console.ReadLine();

			Console.WriteLine("OAuth 2.0 (Hybrid flow)");
			Console.WriteLine("----------------------------------------");
			OAuthHybridExample.Example(Settings.Default.SiteURL, Settings.Default.ClientSecretHybrid, Settings.Default.ClientIDHybrid, Settings.Default.RedirectUrl);
			Console.WriteLine("Ready to continue...");
			Console.ReadLine();
			//await TestPerformanceAsync();

		}

		private static void RESTExamples_24()
		{
			Console.WriteLine("Update example");
			Console.WriteLine("----------------------------------------");
			RESTExample_24_200_001.UpdateBill(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);


			Console.WriteLine("Report example");
			Console.WriteLine("----------------------------------------");
			RESTExample_24_200_001.TestReportDownload(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);

			Console.WriteLine("REST API example");
			Console.WriteLine("----------------------------------------");
			RESTExample_24_200_001.RetrieveInvoiceWithApplications(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_24_200_001.RetrievePOOrdersWithLines(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_24_200_001.TestFullSOProcess(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_24_200_001.TestFileUpload(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_24_200_001.TestShipmentRetrieval(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_24_200_001.CreateAndReleaseAPBill(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_24_200_001.ReadStockItemsWithTranslations(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_24_200_001.TryToCreateARInvoiceAndFail(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("\r\nReady to continue...");
			Console.ReadLine();
		}

		private static void RESTExamples_26()
		{
			Console.WriteLine("Update example");
			Console.WriteLine("----------------------------------------");
			RESTExample_26_200_001.UpdateBill(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);


			Console.WriteLine("Report example");
			Console.WriteLine("----------------------------------------");
			RESTExample_26_200_001.TestReportDownload(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);

			Console.WriteLine("REST API example");
			Console.WriteLine("----------------------------------------");
			RESTExample_26_200_001.RetrieveInvoiceWithApplications(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_26_200_001.RetrievePOOrdersWithLines(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_26_200_001.TestFullSOProcess(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_26_200_001.TestFileUpload(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_26_200_001.TestShipmentRetrieval(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_26_200_001.CreateAndReleaseAPBill(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_26_200_001.ReadStockItemsWithTranslations(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("----------------------------------------");
			RESTExample_26_200_001.TryToCreateARInvoiceAndFail(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			Console.WriteLine("\r\nReady to continue...");
			Console.ReadLine();
		}

		public static async Task TestPerformanceAsync()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
			RestApiPerformanceTest.SyncRestApiMethod(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
			sw.Stop(); 
			Debug.WriteLine("Execution completed for sync in {0} ms.", sw.Elapsed.TotalMilliseconds);

            sw.Start();
            await RestApiPerformanceTest.AsyncRestApiMethod(Settings.Default.SiteURL, Settings.Default.Username, Settings.Default.Password, Settings.Default.Tenant, Settings.Default.Branch, Settings.Default.Locale);
            sw.Stop();
            Debug.WriteLine("Execution completed for async in {0} ms.", sw.Elapsed.TotalMilliseconds);
        }

    }
}
