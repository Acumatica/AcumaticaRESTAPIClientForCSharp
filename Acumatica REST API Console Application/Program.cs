using Acumatica.Auth.Api;
using Acumatica.Auth.Model;
using Acumatica.Default_20_200_001.Api;
using Acumatica.RESTClient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Acumatica.RESTClient.Api;
using Version = Acumatica.RESTClient.ODataVersion;

namespace AcumaticaRestApiExample
{
	class Program
	{
		const string SiteURL = "http://localhost/demo/";
        const string Username = "admin";
		const string Password = "123";
		const string Tenant = null;
		const string Branch = null;
		const string Locale = null;
        private const string ClientSecret = "*-******************";
        private const string ClientID = "********-****-****-****-************@MyStore";

        static void Main(string[] args)
		{

			Console.WriteLine("REST API example");
			RESTExample.ExampleMethod(SiteURL, Username, Password, Tenant, Branch, Locale);

			Console.WriteLine("REST API (Extended Endpoint) example");
			ExtendedEndpointExample.ExampleMethod(SiteURL, Username, Password, Tenant, Branch, Locale);

			Console.WriteLine("OData V3 example");
			ODataExample.ODataGetV3(SiteURL, Username, Password);

			Console.WriteLine("OData V4 example");
			ODataExample.ODataGetV4(SiteURL, Username, Password);

			Console.WriteLine("OData Oauth example");
			ODataExample.OauthExample(SiteURL, Username, Password, ClientSecret, ClientID);

		}

	}
}
