using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class EngineeringChangeOrderHold : EntityAction<EngineeringChangeOrder>
	{
		public EngineeringChangeOrderHold(EngineeringChangeOrder entity) : base(entity)
		{ }
		public EngineeringChangeOrderHold() : base()
		{ }
	}
}
