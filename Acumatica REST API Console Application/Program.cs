using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AcumaticaRestApiExample
{
	class Program
	{
		const string SiteURL = "https://localhost/24r200/";
        const string Username = "admin";
		const string Password = "123";
        const string Tenant = null;//"Company";
		const string Branch = null;
		const string Locale = null;
        # region Resource Owner Password Credentials flow
        private const string ClientSecretROPC = "cCVpHnGVownV7ZAVfT1Y9g";
        private const string ClientIDROPC = "7475716F-D402-EAB6-F8F8-893C9B1EEDF4@Company";
        #endregion
        # region AuthorizationCode flow
        private const string ClientSecretAC = "ZJ7sGGDZWOJyJzSpbRjrpg";
        private const string ClientIDAC = "9737F884-8405-42FB-7303-7F1DA7BE8CA7@Company";
        #endregion
        const string RedirectUrl = "https://localhost/test/";

        static async Task Main(string[] args)
		{

            Console.WriteLine("REST API example");
            Console.WriteLine("----------------------------------------");
            RESTExample.TestFullSOProcess(SiteURL, Username, Password, Tenant, Branch, Locale);
            Console.WriteLine("----------------------------------------");
            RESTExample.TestFileUpload(SiteURL, Username, Password, Tenant, Branch, Locale);
            Console.WriteLine("----------------------------------------");
            RESTExample.TestShipmentRetrieval(SiteURL, Username, Password, Tenant, Branch, Locale);
            Console.WriteLine("----------------------------------------");
            RESTExample.CreateAndReleaseAPBill(SiteURL, Username, Password, Tenant, Branch, Locale);
            Console.WriteLine("----------------------------------------");
            RESTExample.ReadStockItemsWithTranslations(SiteURL, Username, Password, Tenant, Branch, Locale);
            Console.WriteLine("----------------------------------------");
            RESTExample.TryToCreateARInvoiceAndFail(SiteURL, Username, Password, Tenant, Branch, Locale);
            Console.WriteLine("\r\nReady to continue...");
            Console.ReadLine();

            Console.WriteLine("REST API (Extended Endpoint) example");
            Console.WriteLine("----------------------------------------");
            ExtendedEndpointExample.ExampleMethod(SiteURL, Username, Password, Tenant, Branch, Locale);
            Console.WriteLine("\r\nReady to continue...");
            Console.ReadLine();

            Console.WriteLine("OData GI example");
            Console.WriteLine("----------------------------------------");
            ODataExample.ODataGetGI(SiteURL, Username, Password, Tenant);
            ODataExample.ODataGetGINewUrl(SiteURL, Username, Password, Tenant);
            Console.WriteLine("Ready to continue...");
            Console.ReadLine();

            Console.WriteLine("OData DAC example");
            Console.WriteLine("----------------------------------------");
            ODataExample.ODataGetDAC(SiteURL, Username, Password, Tenant);
            ODataExample.ODataGetDACNewUrl(SiteURL, Username, Password, Tenant);
            Console.WriteLine("Ready to continue...");
            Console.ReadLine();

            Console.WriteLine("OData OAuth 2.0 (Resource Owner Password Credentials flow) example");
            Console.WriteLine("----------------------------------------");
            ODataExample.OauthExample(SiteURL, Username, Password, ClientSecretROPC, ClientIDROPC, Tenant);
            Console.WriteLine("Ready to continue...");
            Console.ReadLine();

            Console.WriteLine("OAuth 2.0 (Authorization Code flow)");
            Console.WriteLine("----------------------------------------");
            OAuthAuthCodeExample.Example(SiteURL, ClientSecretAC, ClientIDAC, RedirectUrl);
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
