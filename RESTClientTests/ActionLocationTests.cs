using FluentAssertions;
using System.Linq;
using Xunit;
using System;
using System.Globalization;

using Acumatica.RESTClient.Model;
using Acumatica.RESTClient.Api;

namespace RESTClientTests
{
	public class ActionLocationTests
	{
		[Theory]
		[InlineData("/demo", "Default", "{0}/entity/{1}/18.200.001/Bill/ReleaseBill/status/9bab77d3-61dd-488a-ba84-d6820f06d114")]
		[InlineData("", "Default", "{0}/entity/{1}/18.200.001/Bill/ReleaseBill/status/42e1c8e2-6346-452e-a604-cff94e7d751a")]
		[InlineData("/demo/test", "Default", "{0}/entity/{1}/18.200.001/Bill/ReleaseBill/status/1c1a0de3-2bc1-41ea-93fd-c4e3d98e7f03")]
		[InlineData("/AcumaticaEntity", "CustomEntityEndpoint", "{0}/entity/{1}/18.200.001/Bill/ReleaseBill/status/1c1a0de3-2bc1-41ea-93fd-c4e3d98e7f03")]
		[InlineData("http://localhost:1231", "Default", "{0}/entity/{1}/18.200.001/Bill/ReleaseBill/status/1c1a0de3-2bc1-41ea-93fd-c4e3d98e7f03")]
		[InlineData("https://int.acumatica.com/TestsSite", "Default", "{0}/entity/{1}/18.200.001/Bill/ReleaseBill/status/1c1a0de3-2bc1-41ea-93fd-c4e3d98e7f03")]
		public void ParseLocationTestWithAction(string expectedSite, string expectedEndpoint, string inputLocation)
		{
			var parsedLocation = EntityAPI<Entity>.ParseLocation(string.Format(inputLocation, expectedSite, expectedEndpoint));
			parsedLocation.EndpointName.Should().Be(expectedEndpoint);
			parsedLocation.EndpointVersion.Should().Be("18.200.001");
			parsedLocation.ActionName.Should().Be("ReleaseBill");
			parsedLocation.Site.Should().Be(expectedSite);
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
			var parsedLocation = EntityAPI<Entity>.ParseLocation(string.Format(inputLocation, expectedSite, expectedEndpoint));
			parsedLocation.EndpointName.Should().Be(expectedEndpoint);
			parsedLocation.EndpointVersion.Should().Be("18.200.001");
			parsedLocation.ActionName.Should().BeNull();
			parsedLocation.Site.Should().Be(expectedSite);
		}
	}
}
