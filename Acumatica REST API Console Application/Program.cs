using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AcumaticaRestApiExample
{
	class Program
	{
		const string SiteURL = "http://localhost/2023r200Sales/";
        const string Username = "admin";
		const string Password = "123";
		const string Tenant = null;
		const string Branch = null;
		const string Locale = null;
        private const string ClientSecret = "Bwe_jPnrRBUjn2Ish1rZ1w";
        private const string ClientID = "D1734A18-6EBC-A44F-BAD4-E2E5ACC978D6@Company";
        const string RedirectUrl = "https://localhost/urlForOauth/";

        static async Task Main(string[] args)
		{

            //Console.WriteLine("REST API example");
            //RESTExample.ExampleMethod(SiteURL, Username, Password, Tenant, Branch, Locale);

            //Console.WriteLine("REST API (Extended Endpoint) example");
            //ExtendedEndpointExample.ExampleMethod(SiteURL, Username, Password, Tenant, Branch, Locale);

            //Console.WriteLine("OData V3 example");
            //ODataExample.ODataGetV3(SiteURL, Username, Password, Tenant);

            //Console.WriteLine("OData V4 example");
            //ODataExample.ODataGetV4(SiteURL, Username, Password, Tenant);

            //Console.WriteLine("OData OAuth 2.0 (Resource Owner Password Credentials flow) example");
            //ODataExample.OauthExample(SiteURL, Username, Password, ClientSecret, ClientID, Tenant);

            //Console.WriteLine("OAuth 2.0 (Authorization Code flow)");
            //OAuthAuthCodeExample.Example(SiteURL, ClientSecret, ClientID, RedirectUrl);
            await TestPerformanceAsync();

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
