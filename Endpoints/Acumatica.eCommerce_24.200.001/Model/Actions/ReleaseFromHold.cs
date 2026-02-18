using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	public class ReleaseFromHold : EntityAction<Subcontract>
	{
		public ReleaseFromHold(Subcontract entity) : base(entity)
		{ }
	}
}
