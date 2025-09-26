using Acumatica.RESTClient.Api;

using Xunit;

namespace RESTClientTests
{
	public class FileLocationTests
	{
		[Theory]
		[InlineData("/AcumaticaDB", "Default", "22.200.001", "9be45eb7-f97d-400b-96a5-1c4cf82faa96",
                    "{0}/entity/{1}/{2}/files/{3}")]
		[InlineData("", "Default", "18.200.001", "9be45eb7-f97d-400b-96a5-1c4cf82faa96",
					"{0}/entity/{1}/{2}/files/{3}")]
		public void ParseLocationTestWithAction(
			string expectedSite,
			string expectedEndpoint,
			string expectedEdnpointVersion,
			string expectedID,
			string inputLocation)
		{
			var parsedLocation = UrlParser.ParseFileLocation(
				string.Format(inputLocation, expectedSite, expectedEndpoint, expectedEdnpointVersion, expectedID));
			Assert.Equal(expectedEndpoint, parsedLocation.EndpointName);
			Assert.Equal(expectedEdnpointVersion, parsedLocation.EndpointVersion);
			Assert.Equal(expectedID, parsedLocation.ID);
			Assert.Equal(expectedSite, parsedLocation.Site);
		}
	}
}
