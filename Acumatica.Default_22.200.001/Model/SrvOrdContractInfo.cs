using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class SrvOrdContractInfo : Entity
	{

		[DataMember(Name="ContractPeriod", EmitDefaultValue=false)]
		public StringValue? ContractPeriod { get; set; }

		[DataMember(Name="ServiceContract", EmitDefaultValue=false)]
		public StringValue? ServiceContract { get; set; }

	}
}