using Acumatica.Auth.Api;
using Acumatica.Auth.Model;
using Acumatica.DefaultEndpoint_18_200_001.Api;
using Acumatica.RESTClient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AcumaticaRestApiExample
{
	class Program
	{
		const string SiteURL = "http://localhost/AcumaticaERP/";
		const string Username = "admin";
		const string Password = "123";
		const string Tenant = null;
		const string Branch = null;
		const string Locale = null;

		static void Main(string[] args)
		{
			Console.WriteLine("SOAP-like example (reading Shipment)");
			SOAPLikeExample.ExampleMethod(SiteURL, Username, Password, Tenant, Branch, Locale);

			Console.WriteLine("REST API example (reading Account), Confirming Shipment");
			RESTExample.ExampleMethod(SiteURL, Username, Password, Tenant, Branch, Locale);
		}

	}
}
