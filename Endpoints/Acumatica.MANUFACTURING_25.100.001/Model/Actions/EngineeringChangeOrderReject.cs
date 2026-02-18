using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class EngineeringChangeOrderReject : EntityAction<EngineeringChangeOrder>
	{
		public EngineeringChangeOrderReject(EngineeringChangeOrder entity) : base(entity)
		{ }
	}
}
