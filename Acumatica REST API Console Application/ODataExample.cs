using System;

using Acumatica.Auth.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ODataApi;

using static Acumatica.Auth.Api.AuthApi;

namespace AcumaticaRestApiExample
{
	public class ODataExample
	{
		public static void OauthExample(string siteURL, string username, string password, string clientSecret, string clientID, string tenant = null)
		{
			Console.WriteLine("OData with Oauth authentication");
            var authApi = new AuthApi(siteURL,
				requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);
			var configuration = authApi.ReceiveAccessToken(clientID, clientSecret, username, password, OAuthScope.API);
			
			ODataAPI ODataOauthExample = new ODataAPI(configuration, ODataVersion.OData, tenant);
			var response = ODataOauthExample.GetMetadata();
			Console.WriteLine(response.Data);
		}

		public static void ODataGetV3(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			Console.WriteLine("OData version 3 with Basic Authentication");
			var conf = new Configuration(siteURL, requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);
			conf.Username = username;
			conf.Password = password;
			ODataAPI odatav3 = new ODataAPI(conf, ODataVersion.OData, tenant);
			var response = odatav3.GetMetadata();
			Console.WriteLine(response.Data);


			Console.WriteLine("Filtering the Result of a Generic Inquiry with OData Version 3");
			response = odatav3.GetOData("BI-ARInvoices");

			Console.WriteLine(response.Data);

			Console.WriteLine("Retrieve the modified stocks qtys with OData Version 3");
			string filterParam = "LastModifiedDateTime gt datetime'2022-07-13T00:00:00.000'";
			response = odatav3.GetOData("DB-StorageDetails", filter: filterParam);
			Console.WriteLine(response.Data);
		}
        
		public static void ODataGetV4(string siteURL, string username, string password, string tenant)
        {
			Console.WriteLine("OData version 4 examples");
			Console.WriteLine("Testing sign in");
            var conf = new Configuration(siteURL, requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);
            conf.Username = username;
            conf.Password = password;
            ODataAPI oDatav4 = new ODataAPI(conf, ODataVersion.ODatav4, tenant);
			var response = oDatav4.GetMetadata();
			Console.WriteLine(response.Data);

			Console.WriteLine("Retrieving quantities from tables with OData Version 4");
			string selectParam = "QtyOnHand,QtyAvail";
			string expandParam = "InventoryItemByInventoryID($select=InventoryCD,Descr),INSiteBySiteID($select = SiteCD)";
			var response3 = oDatav4.GetOData("PX_Objects_IN_INSiteStatus", selectParam, null, expandParam);
			Console.WriteLine(response3.Data);

			Console.WriteLine("Retrieve the list of modified stocks with OData Version 4");
			selectParam = "InventoryCD,Descr,ItemStatus,LastModifiedDateTime,BaseUnit";
			expandParam = "INSiteByDfltSiteID($select=SiteCD),INItemClassByItemClassID($select = ItemClassCD),INSiteStatusCollection($select = QtyOnHand)";
			string filterParam = "StkItem eq true and ItemStatus eq 'AC' and LastModifiedDateTime gt 2022-07-13T00:00-04:00";
			var response5 = oDatav4.GetOData("PX_Objects_IN_InventoryItem", selectParam, filterParam, expandParam);
			Console.WriteLine(response5.Data);

        }
		

    }
		
}
		