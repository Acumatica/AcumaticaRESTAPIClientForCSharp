using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class ReleaseProductionOrdersProcessAll : EntityAction<ReleaseProductionOrders>
	{
		public ReleaseProductionOrdersProcessAll(ReleaseProductionOrders entity) : base(entity)
		{ }
	}
}
