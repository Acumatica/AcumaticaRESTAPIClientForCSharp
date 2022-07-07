using System;
using Acumatica.RESTClient.Api;


namespace AcumaticaRestApiExample
{
	public class ODataExample
	{
		public static void ODataGetV3(string basePath, string username, string password)
		{
			var odataExample = new ODataAPI(basePath);
			string response = odataExample.GetV3(basePath, username, password);
			Console.WriteLine(response);
			

		}
	}
}
