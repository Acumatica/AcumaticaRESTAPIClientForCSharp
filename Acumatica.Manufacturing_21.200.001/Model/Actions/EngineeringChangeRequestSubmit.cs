using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestSubmit : EntityAction<EngineeringChangeRequest>
	{
		public EngineeringChangeRequestSubmit(EngineeringChangeRequest entity) : base(entity)
		{ }
		public EngineeringChangeRequestSubmit() : base()
		{ }
	}
}
