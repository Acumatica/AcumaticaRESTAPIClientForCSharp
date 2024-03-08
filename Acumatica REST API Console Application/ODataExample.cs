using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ODataApi;

using static Acumatica.RESTClient.AuthApi.AuthApiExtensions;

namespace AcumaticaRestApiExample
{
	public class ODataExample
	{
		public static void OauthExample(string siteURL, string username, string password, string clientSecret, string clientID, string tenant = null)
		{
			Console.WriteLine("OData with Oauth authentication");
            var client = new ApiClient(siteURL,
				requestInterceptor: RequestLogger.LogRequest, 
				responseInterceptor: RequestLogger.LogResponse
				);
			client.ReceiveAccessToken(clientID, clientSecret, username, password, OAuthScope.API);
			var response = client.GetOdataMetadata(ODataVersion.OData, tenant);
			
			Console.WriteLine(response);
		}

		public static void ODataGetV3(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			Console.WriteLine("OData version 3 with Basic Authentication");
			var client = new ApiClient(siteURL
				, requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse
				);
			client.Username = username;
			client.Password = password;
			Console.WriteLine("Getting OData metadata");
			try
			{
				var metadata = client.GetOdataMetadata(ODataVersion.OData, tenant);
				//deserialize metadata from xml

				
                var giName = "BI-ARInvoices";
				if (metadata.EntityType.Where(gi => gi.Name == giName).Any())
				{
					Console.WriteLine("Retrieving AR Invoices with OData Version 3");
					string giResult = client.GetOData(ODataVersion.OData, giName, tenant: tenant);
					Console.WriteLine(giResult);
				}
				else
				{
					Console.WriteLine($"Generic Inquiry {giName} not found");
				}



				Console.WriteLine("Filtering the Result of a Generic Inquiry with OData Version 3");
				string giResult2 = client.GetOData(ODataVersion.OData, giName, tenant: tenant);

				Console.WriteLine(metadata);

				Console.WriteLine("Retrieve the modified stocks qtys with OData Version 3");
				//string filterParam = "LastModifiedDateofWarehouseQty gt datetime'2022-07-13T00:00:00.000'";
                string filterParam = "LastModifiedDateTime gt datetime'2022-07-13T00:00:00.000'";
                giResult2 = client.GetOData(ODataVersion.OData, "DB-StorageDetails", tenant: tenant, filter: filterParam);
				///gives this error:
				///<m:message>Could not find a property named 'LastModifiedDateTime' on type 'PX.Data.DBStorageDetails'.</m:message>
				Console.WriteLine(metadata);
			}
			catch (Exception e)
			{
                Console.WriteLine(e.Message);
            }
            finally
			{
				//we don't need to logout in OData
            }
		}

		public static void ODataGetV4(string siteURL, string username, string password, string tenant)
		{
			Console.WriteLine("OData version 4 examples");
			Console.WriteLine("Testing sign in");
			var client = new ApiClient(siteURL
				//	, requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse
				);
			client.Username = username;
			client.Password = password;
			var response = client.GetOdataMetadata(ODataVersion.ODatav4, tenant);
			Console.WriteLine(response);

			Console.WriteLine("Retrieving quantities from tables with OData Version 4");
			string selectParam = "QtyOnHand,QtyAvail";
			string expandParam = "InventoryItemByInventoryID($select=InventoryCD,Descr),INSiteBySiteID($select = SiteCD)";
			var response3 = client.GetOData(ODataVersion.ODatav4, "PX_Objects_IN_INSiteStatus", tenant: tenant,
				select: selectParam, expand: expandParam);
			Console.WriteLine(response3);

			Console.WriteLine("Retrieve the list of modified stocks with OData Version 4");
			selectParam = "InventoryCD,Descr,ItemStatus,LastModifiedDateTime,BaseUnit";
			expandParam = "INSiteByDfltSiteID($select=SiteCD),INItemClassByItemClassID($select = ItemClassCD),INSiteStatusCollection($select = QtyOnHand)";
			string filterParam = "StkItem eq true and ItemStatus eq 'AC' and LastModifiedDateTime gt 2022-07-13T00:00-04:00";
			var response5 = client.GetOData(ODataVersion.ODatav4, "PX_Objects_IN_InventoryItem", tenant: tenant, select: selectParam, filter: filterParam, expand: expandParam);
			Console.WriteLine(response5);

		}
    }
}
		