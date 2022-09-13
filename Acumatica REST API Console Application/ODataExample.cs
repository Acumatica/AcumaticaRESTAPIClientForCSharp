﻿using System;

using Acumatica.Auth.Api;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient;

using static Acumatica.Auth.Api.AuthApi;

using Version = Acumatica.RESTClient.ODataVersion;
using Acumatica.RESTClient.Client;

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
			
			ODataAPI oauth = new ODataAPI(configuration, Version.OData);
			var response = oauth.Get();
			Console.WriteLine(response);
		}
		
		public static void ODataGetV3(string siteURL, string username, string password, string tenant=null, string branch=null, string locale=null)
		{			
			var authApi = new AuthApi(siteURL, requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);
			
                Console.WriteLine("OData version 3 with Basic Authentication");
                var conf = new Configuration(siteURL, requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);
				conf.Username= username;
				conf.Password = password;
				ODataAPI odatav3 = new ODataAPI(conf, ODataVersion.OData);
				var response = odatav3.Get();
				Console.WriteLine(response.Data);

				Console.WriteLine("Example retrieval of customers with OData Version 3");
				var response2 = odatav3.Get("Customer%20Contacts");
				Console.WriteLine(response2);

				Console.WriteLine("Retrieving quantities from tables with OData Version 3");
				var response3 = odatav3.Get("Item%20Availability%20Data");
				Console.WriteLine(response3);

				Console.WriteLine("Filtering the Result of a Generic Inquiry with OData Version 3");
				var response4 = odatav3.Get("$metadata");
				Console.WriteLine(response4);

				Console.WriteLine("Retrieve the modified stocks with OData Version 3");
				string filterParam = "ItemStatus eq 'Active' and LastModifiedOn gt datetime'2022-07-13T00:00:00.000'";
				var response5 = odatav3.Get("Modified%20Stock%20Items", null, filterParam);
				Console.WriteLine(response5);
				
			
			
        }
        
		public static void ODataGetV4(string siteURL, string username, string password)
        {
			Console.WriteLine("OData version 4 examples");
			Console.WriteLine("Testing sign in");
            var authApi = new AuthApi(siteURL, requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);
            var conf = new Configuration(siteURL, requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);
            conf.Username = username;
            conf.Password = password;
            ODataAPI oDatav4 = new ODataAPI(conf, ODataVersion.ODatav4);
			var response = oDatav4.Get("$metadata");
			Console.WriteLine(response);

			Console.WriteLine("Retrieving quantities from tables with OData Version 4");
			string selectParam = "QtyOnHand,QtyAvail";
			string expandParam = "InventoryItemByInventoryID($select=InventoryCD,Descr),INSiteBySiteID($select = SiteCD)";
			var response3 = oDatav4.Get("PX_Objects_IN_INSiteStatus", selectParam, null, expandParam);
			Console.WriteLine(response3);

			Console.WriteLine("Retrieve the list of modified stocks with OData Version 4");
			selectParam = "InventoryCD,Descr,ItemStatus,LastModifiedDateTime,BaseUnit";
			expandParam = "INSiteByDfltSiteID($select=SiteCD),INItemClassByItemClassID($select = ItemClassCD),INSiteStatusCollection($select = QtyOnHand)";
			string filterParam = "StkItem eq true and ItemStatus eq 'AC' and LastModifiedDateTime gt 2022-07-13T00:00-04:00";
			var response5 = oDatav4.Get("PX_Objects_IN_InventoryItem", selectParam, filterParam, expandParam);
			Console.WriteLine(response5);

        }
		

    }
		
}
		