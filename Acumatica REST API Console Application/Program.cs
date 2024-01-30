using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AcumaticaRestApiExample
{
	class Program
	{
		const string SiteURL = "http://localhost/23r206/";
        const string Username = "admin";
		const string Password = "123";
		const string Tenant = null;
		const string Branch = null;
		const string Locale = null;
        # region Resource Owner Password Credentials flow
        private const string ClientSecretROPC = "EIIG0Sx_9KxpaL7n7Xx7Ng";
        private const string ClientIDROPC = "E46A39DF-D7F5-2C74-C974-2B10C541507A@Company";
        #endregion
        # region AuthorizationCode flow
        private const string ClientSecretAC = "y9VknA2OKIok82MlTJ_ZUA";
        private const string ClientIDAC = "51F687CB-6CF3-B062-2504-C63C96565D57@Company";
        #endregion
        const string RedirectUrl = "https://localhost/urlForOauth/";

        static async Task Main(string[] args)
		{

            Console.WriteLine("REST API example");
            RESTExample.TestFileUpload(SiteURL, Username, Password, Tenant, Branch, Locale);
            RESTExample.TestShipmentRetrieval(SiteURL, Username, Password, Tenant, Branch, Locale);
            RESTExample.CreateAndReleaseAPBill(SiteURL, Username, Password, Tenant, Branch, Locale);
            RESTExample.ReadStockItemsWithTranslations(SiteURL, Username, Password, Tenant, Branch, Locale);
            Console.WriteLine("Ready to continue...");
            Console.ReadLine();

            //Console.WriteLine("REST API (Extended Endpoint) example");
            //ExtendedEndpointExample.ExampleMethod(SiteURL, Username, Password, Tenant, Branch, Locale);
            //Console.WriteLine("Ready to continue...");
            //Console.ReadLine();

            Console.WriteLine("OData V3 example");
            ODataExample.ODataGetV3(SiteURL, Username, Password, Tenant);
            Console.WriteLine("Ready to continue...");
            Console.ReadLine();

            Console.WriteLine("OData V4 example");
            ODataExample.ODataGetV4(SiteURL, Username, Password, Tenant);
            Console.WriteLine("Ready to continue...");
            Console.ReadLine();

            Console.WriteLine("OData OAuth 2.0 (Resource Owner Password Credentials flow) example");
            ODataExample.OauthExample(SiteURL, Username, Password, ClientSecretROPC, ClientIDROPC, Tenant);
            Console.WriteLine("Ready to continue...");
            Console.ReadLine();

            Console.WriteLine("OAuth 2.0 (Authorization Code flow)");
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
