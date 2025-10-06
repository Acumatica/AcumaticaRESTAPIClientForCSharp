using Acumatica.RESTClient.Api;

using Xunit;

namespace RESTClientTests
{
	public class FilePutLocationTests
	{
		[Theory]
		[InlineData(
			"/AcumaticaDB", 
			"Default", 
			"23.200.001", 
			"PX.Objects.IN.InventoryItemMaint", 
			"Item",
			"cae53ce0 -1614-e511-9b82-c86000dddf0b",
            "{0}/entity/{1}/{2}/files/{3}/{4}/{5}/file.dat")]
		public void ParseLocationTestWithAction(
			string expectedSite,
			string expectedEndpoint,
			string expectedEdnpointVersion,
            string expectedGraph,
            string expectedView,
            string expectedID,
            string inputLocation)
		{
			var parsedLocation = UrlParser.ParseFilePutLocation(
				string.Format(inputLocation, expectedSite, expectedEndpoint, expectedEdnpointVersion, expectedGraph, expectedView, expectedID));
			Assert.Equal(expectedEndpoint, parsedLocation.EndpointName);
			Assert.Equal(expectedEdnpointVersion, parsedLocation.EndpointVersion);
            Assert.Equal(expectedGraph, parsedLocation.GraphType);
            Assert.Equal(expectedView, parsedLocation.ViewName);
            Assert.Equal(expectedEdnpointVersion, parsedLocation.EndpointVersion); 
			Assert.Equal(expectedID, parsedLocation.ID);
			Assert.Equal(expectedSite, parsedLocation.Site);
		}
	}
}
