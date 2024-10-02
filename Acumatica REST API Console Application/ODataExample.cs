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
                responseInterceptor: RequestLogger.LogResponse,
                ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );
            client.ReceiveAccessToken(clientID, clientSecret, username, password, OAuthScope.API);
            var response = client.GetOdataObjects(ODataVersion.OData, tenant);

            Console.WriteLine($"Retrieved {response.Count()} results");
        }

		public static void ODataGetGI(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
		{
			Console.WriteLine("GI-based OData with Basic Authentication");
			var client = new ApiClient(siteURL
				, requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse,
                ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );
			client.Username = username;
			client.Password = password;
			Console.WriteLine("Getting list of GIs available via OData");
			try
			{
				var objects = client.GetOdataObjects(ODataVersion.OData, tenant);
				
                var giName = "BI-ARInvoices";
				if (objects.Where(gi => gi.Name == giName).Any())
				{
					Console.WriteLine("Retrieving 5 AR Invoices with GI-based OData");
					var giResult = client.GetOData(ODataVersion.OData, giName, tenant: tenant, top: 5);
					Console.WriteLine($"Retrieved {giResult.Count()} Invoices");
				}
				else
				{
					Console.WriteLine($"Generic Inquiry {giName} not found");
				}


				Console.WriteLine("Retrieve the modified stocks qtys with GI-based OData");

				try
				{
					// the parameter does not exist, throws an error
					string filterParam = "LastModifiedDateTime gt datetime'2022-07-13T00:00:00.000'";
					var giResult2 = client.GetOData(ODataVersion.OData, "DB-StorageDetails", tenant: tenant, filter: filterParam);
				}
                catch (Exception e)
                {
					
                    Console.WriteLine(e.Message);
                }
                string filterParam2 = "LastModifiedDateofWarehouseQty gt datetime'2022-07-13T00:00:00.000'";
                var giResult3 = client.GetOData(ODataVersion.OData, "DB-StorageDetails", tenant: tenant, filter: filterParam2);
                Console.WriteLine("Retrieved successfully");
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
        public static void ODataGetGINewUrl(string siteURL, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            Console.WriteLine("GI-based OData with Basic Authentication");
            var client = new ApiClient(siteURL
                , requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse,
                ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );
            client.Username = username;
            client.Password = password;
            Console.WriteLine("Getting list of GIs available via OData");
            try
            {
                var objects = client.GetOdataObjects(ODataVersion.GIBasedOData, tenant);

                var giName = "BI-ARInvoices";
                if (objects.Where(gi => gi.Name == giName).Any())
                {
                    Console.WriteLine("Retrieving 5 AR Invoices with GI-based OData");
                    var giResult = client.GetOData(ODataVersion.GIBasedOData, giName, tenant: tenant, top: 5);
                    Console.WriteLine($"Retrieved {giResult.Count()} Invoices");
                }
                else
                {
                    Console.WriteLine($"Generic Inquiry {giName} not found");
                }


                Console.WriteLine("Retrieve the modified stocks qtys with GI-based OData");

                try
                {
                    // the parameter does not exist, throws an error
                    string filterParam = "LastModifiedDateTime gt 2022-07-13T00:00:00Z";
                    var giResult2 = client.GetOData(ODataVersion.GIBasedOData, "DB-StorageDetails", tenant: tenant, filter: filterParam);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                string filterParam2 = "LastModifiedDateofWarehouseQty gt 2022-07-13T00:00:00Z";
                var giResult3 = client.GetOData(ODataVersion.GIBasedOData, "DB-StorageDetails", tenant: tenant, filter: filterParam2);
                Console.WriteLine("Retrieved successfully");
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

        public static void ODataGetDAC(string siteURL, string username, string password, string tenant)
		{
			Console.WriteLine("DAC-based OData examples");
			var client = new ApiClient(siteURL
				//	, requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse
                ,ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );
			client.Username = username;
			client.Password = password;
			var response = client.GetOdataObjects(ODataVersion.ODatav4, tenant);
			Console.WriteLine($"{response.Count()} DACs available");

			Console.WriteLine("Retrieving quantities from tables with DAC-based OData");
			string selectParam = "QtyOnHand,QtyAvail";
			string expandParam = "InventoryItemByInventoryID($select=InventoryCD,Descr),INSiteBySiteID($select = SiteCD)";
			var response3 = client.GetOData(ODataVersion.ODatav4, "PX_Objects_IN_INSiteStatus", tenant: tenant,
				select: selectParam, expand: expandParam);
			Console.WriteLine(response3.First());

			Console.WriteLine("Retrieve the list of modified stocks with DAC-based OData");
			selectParam = "InventoryCD,Descr,ItemStatus,LastModifiedDateTime,BaseUnit";
			expandParam = "INSiteByDfltSiteID($select=SiteCD),INItemClassByItemClassID($select = ItemClassCD),INSiteStatusCollection($select = QtyOnHand)";
			string filterParam = "StkItem eq true and ItemStatus eq 'AC' and LastModifiedDateTime gt 2022-07-13T00:00-04:00";
			var response5 = client.GetOData(ODataVersion.ODatav4, "PX_Objects_IN_InventoryItem", tenant: tenant, select: selectParam, filter: filterParam, expand: expandParam);
			Console.WriteLine(response5.First());

        }
        public static void ODataGetDACNewUrl(string siteURL, string username, string password, string tenant)
        {
            Console.WriteLine("DAC-based OData examples");
            var client = new ApiClient(siteURL,
                //	, requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse
                ignoreSslErrors: true // this is here to allow testing with self-signed certificates
                );
            client.Username = username;
            client.Password = password;
            var response = client.GetOdataObjects(ODataVersion.DACBasedOData, tenant);
            Console.WriteLine($"{response.Count()} DACs available");

            Console.WriteLine("Retrieving quantities from tables with DAC-based OData");
            string selectParam = "QtyOnHand,QtyAvail";
            string expandParam = "InventoryItemByInventoryID($select=InventoryCD,Descr),INSiteBySiteID($select = SiteCD)";
            var response3 = client.GetOData(ODataVersion.DACBasedOData, "PX_Objects_IN_INSiteStatus", tenant: tenant,
                select: selectParam, expand: expandParam);
            Console.WriteLine(response3.First());

            Console.WriteLine("Retrieve the list of modified stocks with DAC-based OData");
            selectParam = "InventoryCD,Descr,ItemStatus,LastModifiedDateTime,BaseUnit";
            expandParam = "INSiteByDfltSiteID($select=SiteCD),INItemClassByItemClassID($select = ItemClassCD),INSiteStatusCollection($select = QtyOnHand)";
            string filterParam = "StkItem eq true and ItemStatus eq 'AC' and LastModifiedDateTime gt 2022-07-13T00:00-04:00";
            var response5 = client.GetOData(ODataVersion.DACBasedOData, "PX_Objects_IN_InventoryItem", tenant: tenant, select: selectParam, filter: filterParam, expand: expandParam);
            Console.WriteLine(response5.First());

        }
    }
}
		