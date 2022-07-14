using System;
using System.Collections.Generic;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;

namespace AcumaticaRestApiExample
{
	public class ODataExample
	{
		public static void ODataGetV3(string basePath, string username, string password)
		{
			Console.WriteLine("OData version 3 examples");
			var version = "OData";
			var configuration = new Configuration(basePath);

			Console.WriteLine("Testing sign in");  
			ODataAPI odata = new ODataAPI(configuration);
			var response = odata.Get(version, null, null, username, password);
			Console.WriteLine(response);

			Console.WriteLine("Example retrieval of customers with OData Version 3");
			var parameter = new Dictionary<string, string>();
			parameter.Add("format", "json");
			var response2 = odata.Get(version, "Customer%20Contacts", parameter);
			Console.WriteLine(response2);

			Console.WriteLine("Retrieving quantities from tables with OData Version 3");
			var response3 = odata.Get(version, "Item%20Availability%20Data", parameter);
			Console.WriteLine(response3);

			Console.WriteLine("Filtering the Result of a Generic Inquiry with OData Version 3");
			var response4 = odata.Get(version, "$metadata");
			Console.WriteLine(response4);

			Console.WriteLine("Retrieve the modified stocks with OData Version 3");
			parameter.Add("filter", "ItemStatus eq 'Active' and LastModifiedOn gt datetime'2022-07-13T00:00:00.000'");
			var response5 = odata.Get(version, "Modified%20Stock%20Items", parameter);
		}

		public static void ODataGetV4(string basePath, string username, string password)
        {
			Console.WriteLine("OData version 4 examples");
			var version = "ODatav4";
			var configuration = new Configuration(basePath);

			Console.WriteLine("Testing sign in");  
			ODataAPI odata = new ODataAPI(configuration);
			var response = odata.Get(version, "$metadata", null, username, password);
			Console.WriteLine(response);

			Console.WriteLine("Retrieving quantities from tables with OData Version 4");
			var parameter = new Dictionary<string, string>();
			parameter.Add("select", "QtyOnHand,QtyAvail");
			parameter.Add("expand", "InventoryItemByInventoryID($select=InventoryCD,Descr),INSiteBySiteID($select = SiteCD)");
			var response3 = odata.Get(version, "PX_Objects_IN_INSiteStatus", parameter);
			Console.WriteLine(response3);

			Console.WriteLine("Retrieve the list of modified stocks with OData Version 4");
			parameter.Add("filter", "ItemStatus eq 'Active' and LastModifiedOn gt datetime'2022-07-13T00:00:00.000'");
			parameter = new Dictionary<string, string>();
			parameter.Add("select", "InventoryCD,Descr,ItemStatus,LastModifiedDateTime,BaseUnit");
			parameter.Add("expand", "INSiteByDfltSiteID($select=SiteCD),INItemClassByItemClassID($select = ItemClassCD),INSiteStatusCollection($select = QtyOnHand");
			parameter.Add("filter", "StkItem eq true and ItemStatus eq 'AC' and LastModifiedDateTime gt 2022 - 07 - 13T00: 00:00 - 04:00");
			var response5 = odata.Get(version, "PX_Objects_IN_InventoryItem", parameter);
			Console.WriteLine(response5);

        }

	}
}
