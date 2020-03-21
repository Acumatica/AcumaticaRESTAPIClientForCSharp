
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Model;
using SOAPLikeWrapperForREST;
using System;
using System.Collections.Generic;

namespace SOAPLikeWrapperForREST
{
	public class DefaultSoapClient : SOAPLikeClient
	{
		public DefaultSoapClient(string siteURL, string endpoint) : base(siteURL, endpoint)
		{ }
	
	}
}