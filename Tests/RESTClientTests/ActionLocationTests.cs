using Acumatica.RESTClient.Api;

using Xunit;

namespace RESTClientTests
{
	public class ActionLocationTests
	{
		[Theory]
		[InlineData("/demo", "Default", "18.200.001", "ReleaseBill",
					"{0}/entity/{1}/{2}/Bill/{3}/status/9bab77d3-61dd-488a-ba84-d6820f06d114")]
		[InlineData("", "Default", "18.200.001", "ReleaseBill",
            "{0}/entity/{1}/{2}/Bill/{3}/status/42e1c8e2-6346-452e-a604-cff94e7d751a")]
		[InlineData("/demo/test", "Default", "18.200.001", "ReleaseBill",
            "{0}/entity/{1}/{2}/Bill/{3}/status/1c1a0de3-2bc1-41ea-93fd-c4e3d98e7f03")]
		[InlineData("/AcumaticaEntity", "CustomEntityEndpoint", "18.200.001", "ReleaseBill",
            "{0}/entity/{1}/{2}/Bill/{3}/status/1c1a0de3-2bc1-41ea-93fd-c4e3d98e7f03")]
		[InlineData("http://localhost:1231", "Default", "18.200.001", "ReleaseBill",
			"{0}/entity/{1}/{2}/Bill/{3}/status/1c1a0de3-2bc1-41ea-93fd-c4e3d98e7f03")]
		[InlineData("https://int.acumatica.com/TestsSite", "Default", "18.200.001", "ReleaseBill", 
			"{0}/entity/{1}/{2}/Bill/{3}/status/1c1a0de3-2bc1-41ea-93fd-c4e3d98e7f03")]
		[InlineData("/Acumatica2022R2", "VTECHAPI", "6", "ConfirmShipment",
            "{0}/entity/{1}/{2}/Shipment/{3}/status/c0b9ae7d-acb8-4659-9262-1c232314459f")]
		public void ParseLocationTestWithAction(
			string expectedSite,
			string expectedEndpoint,
			string expectedEdnpointVersion,
			string expectedAction,
			string inputLocation)
		{
			var parsedLocation = UrlParser.ParseActionLocation(
				string.Format(inputLocation, expectedSite, expectedEndpoint, expectedEdnpointVersion, expectedAction));
			Assert.Equal(expectedEndpoint, parsedLocation.EndpointName);
			Assert.Equal(expectedEdnpointVersion, parsedLocation.EndpointVersion);
			Assert.Equal(expectedAction, parsedLocation.ActionName);
			Assert.Equal(expectedSite, parsedLocation.Site);
		}

		[Theory]
		[InlineData("/demo", "Default", "{0}/entity/{1}/18.200.001/Bill/")]
		[InlineData("", "Default", "{0}/entity/{1}/18.200.001/Bill")]
		[InlineData("/demo/test", "Default", "{0}/entity/{1}/18.200.001/Bill/")]
		[InlineData("/AcumaticaEntity", "CustomEntityEndpoint", "{0}/entity/{1}/18.200.001/Bill")]
		[InlineData("http://localhost:1231", "Default", "{0}/entity/{1}/18.200.001/Bill")]
		[InlineData("https://int.acumatica.com/TestsSite", "Default", "{0}/entity/{1}/18.200.001/Bill")]
		public void ParseLocationTestWithoutAction(string expectedSite, string expectedEndpoint, string inputLocation)
		{
			var parsedLocation = UrlParser.ParseActionLocation(string.Format(inputLocation, expectedSite, expectedEndpoint));
			Assert.Equal(expectedEndpoint, parsedLocation.EndpointName);
			Assert.Equal("18.200.001", parsedLocation.EndpointVersion);
			Assert.Null(parsedLocation.ActionName);
			Assert.Equal(expectedSite, parsedLocation.Site);
		}
	}
}
