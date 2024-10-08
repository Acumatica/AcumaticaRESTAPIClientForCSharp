using FluentAssertions;
using System.Linq;
using Xunit;
using System;
using System.Globalization;

using Acumatica.RESTClient.ContractBasedApi.Model;
using Acumatica.RESTClient.Api;

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
			parsedLocation.EndpointName.Should().Be(expectedEndpoint);
			parsedLocation.EndpointVersion.Should().Be(expectedEdnpointVersion);
            parsedLocation.GraphType.Should().Be(expectedGraph);
            parsedLocation.ViewName.Should().Be(expectedView);
            parsedLocation.EndpointVersion.Should().Be(expectedEdnpointVersion); 
			parsedLocation.ID.Should().Be(expectedID);
			parsedLocation.Site.Should().Be(expectedSite);
		}
	}
}
