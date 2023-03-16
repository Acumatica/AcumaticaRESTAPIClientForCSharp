using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestHold : EntityAction<EngineeringChangeRequest>
	{
		public EngineeringChangeRequestHold(EngineeringChangeRequest entity) : base(entity)
		{ }
		public EngineeringChangeRequestHold() : base()
		{ }
	}
}
