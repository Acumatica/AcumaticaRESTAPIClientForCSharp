using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultEndpoint_18_200_001
{
	public static class EndpointHelper
	{
		const string EndpointName = "Default";
		const string EndpointVersion = "18.200.001";
		public static string CombineEndpointURL(string siteURL)
		{
			return siteURL + "/entity/" + EndpointName + "/" + EndpointVersion + "/";
		}
	}
}
