using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AcumaticaRestApiExample
{
	class Program
	{
		const string SiteURL = "https://localhost/26R1/";
        const string Username = "admin";
		const string Password = "123";
        const string Tenant = "Company";
		const string Branch = null;
		const string Locale = null;
        # region Resource Owner Password Credentials flow
        private const string ClientSecretROPC = "cCVpHnGVownV7ZAVfT1Y9g";
        private const string ClientIDROPC = "7475716F-D402-EAB6-F8F8-893C9B1EEDF4@Company";
        #endregion
        # region AuthorizationCode flow
        private const string ClientSecretAC = "KzK82VVdqggy4PHaOHMTNw";
        private const string ClientIDAC = "2DC9435C-A596-959E-3E38-8EB84725F089@Company";
        #endregion
        const string RedirectUrl = "https://localhost/test/";

        static async Task Main(string[] args)
        {
            //Console.WriteLine("Report example");
            //Console.WriteLine("----------------------------------------");
            //RESTExample.TestReportDownload(SiteURL, Username, Password, Tenant, Branch, Locale);

            //Console.WriteLine("REST API example");
            //Console.WriteLine("----------------------------------------");
            //RESTExample.TestFullSOProcess(SiteURL, Username, Password, Tenant, Branch, Locale);
            //Console.WriteLine("----------------------------------------");
            //RESTExample.TestFileUpload(SiteURL, Username, Password, Tenant, Branch, Locale);
            //Console.WriteLine("----------------------------------------");
            //RESTExample.TestShipmentRetrieval(SiteURL, Username, Password, Tenant, Branch, Locale);
            //Console.WriteLine("----------------------------------------");
            //RESTExample.CreateAndReleaseAPBill(SiteURL, Username, Password, Tenant, Branch, Locale);
            //Console.WriteLine("----------------------------------------");
            //RESTExample.ReadStockItemsWithTranslations(SiteURL, Username, Password, Tenant, Branch, Locale);
            //Console.WriteLine("----------------------------------------");
            //RESTExample.TryToCreateARInvoiceAndFail(SiteURL, Username, Password, Tenant, Branch, Locale);
            //Console.WriteLine("\r\nReady to continue...");
            //Console.ReadLine();

            //Console.WriteLine("REST API (Extended Endpoint) example");
            //Console.WriteLine("----------------------------------------");
            //ExtendedEndpointExample.ExampleMethod(SiteURL, Username, Password, Tenant, Branch, Locale);
            //Console.WriteLine("\r\nReady to continue...");
            //Console.ReadLine();

            //Console.WriteLine("OData GI example");
            //Console.WriteLine("----------------------------------------");
            //ODataExample.ODataGetGI(SiteURL, Username, Password, Tenant);
            //ODataExample.ODataGetGINewUrl(SiteURL, Username, Password, Tenant);
            //Console.WriteLine("Ready to continue...");
            //Console.ReadLine();

            //Console.WriteLine("OData DAC example");
            //Console.WriteLine("----------------------------------------");
            //ODataExample.ODataGetDAC(SiteURL, Username, Password, Tenant);
            //ODataExample.ODataGetDACNewUrl(SiteURL, Username, Password, Tenant);
            //Console.WriteLine("Ready to continue...");
            //Console.ReadLine();

            //Console.WriteLine("OData OAuth 2.0 (Resource Owner Password Credentials flow) example");
            //Console.WriteLine("----------------------------------------");
            //ODataExample.OauthExample(SiteURL, Username, Password, ClientSecretROPC, ClientIDROPC, Tenant);
            //Console.WriteLine("Ready to continue...");
            //Console.ReadLine();

            //Console.WriteLine("OAuth 2.0 (Authorization Code flow)");
            //Console.WriteLine("----------------------------------------");
            //OAuthAuthCodeExample.Example(SiteURL, ClientSecretAC, ClientIDAC, RedirectUrl);
            //Console.WriteLine("Ready to continue...");
            //Console.ReadLine();

            Console.WriteLine("OAuth 2.0 (Hybrid flow)");
            Console.WriteLine("----------------------------------------");
            OAuthHybridExample.Example(SiteURL, ClientSecretAC, ClientIDAC, RedirectUrl);
            Console.WriteLine("Ready to continue...");
            Console.ReadLine();
            //await TestPerformanceAsync();

        }

        public static async Task TestPerformanceAsync()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
			RestApiPerformanceTest.SyncRestApiMethod(SiteURL, Username, Password, Tenant, Branch, Locale);
			sw.Stop(); 
			Debug.WriteLine("Execution completed for sync in {0} ms.", sw.Elapsed.TotalMilliseconds);

            sw.Start();
            await RestApiPerformanceTest.AsyncRestApiMethod(SiteURL, Username, Password, Tenant, Branch, Locale);
            sw.Stop();
            Debug.WriteLine("Execution completed for async in {0} ms.", sw.Elapsed.TotalMilliseconds);
        }

    }
}
