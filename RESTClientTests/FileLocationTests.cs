using FluentAssertions;
using System.Linq;
using Xunit;
using System;
using System.Globalization;

using Acumatica.RESTClient.Model;
using Acumatica.RESTClient.Api;

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
			parsedLocation.EndpointName.Should().Be(expectedEndpoint);
			parsedLocation.EndpointVersion.Should().Be(expectedEdnpointVersion);
			parsedLocation.ID.Should().Be(expectedID);
			parsedLocation.Site.Should().Be(expectedSite);
		}
	}
}
