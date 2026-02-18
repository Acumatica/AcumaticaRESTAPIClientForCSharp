using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	public class Case : Acumatica.Default_24_200_001.Model.Case, ITopLevelEntity
	{

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}