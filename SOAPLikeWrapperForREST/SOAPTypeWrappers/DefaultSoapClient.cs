 using System;

namespace SOAPLikeWrapperForREST
{
	public class DefaultSoapClient : SOAPLikeClient, IDisposable
	{
		public DefaultSoapClient(string siteURL, string endpoint) : base(siteURL, endpoint)
		{ }

		public void Dispose()
		{
			Logout();
		}
	}
}