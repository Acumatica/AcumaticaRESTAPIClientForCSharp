using System;

namespace AcumaticaRestApiExample
{
	class Program
	{
		const string SiteURL = "http://localhost/22r203/";
        const string Username = "admin";
		const string Password = "123";
		const string Tenant = "Company";
		const string Branch = null;
		const string Locale = null;
        private const string ClientSecret = "Op0M23KPx8BWvQHWQAvbMg";
        private const string ClientID = "85D663A7-9BDC-4409-E5A0-D686D28CF4BB@Company";
        const string RedirectUrl = "https://localhost/urlForOauth/";

        static void Main(string[] args)
		{

			Console.WriteLine("REST API example");
			RESTExample.ExampleMethod(SiteURL, Username, Password, Tenant, Branch, Locale);

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

		}

	}
}
