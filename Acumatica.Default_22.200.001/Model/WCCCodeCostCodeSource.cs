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
	public class WCCCodeCostCodeSource : Entity
	{

		[DataMember(Name="CostCodeFrom", EmitDefaultValue=false)]
		public StringValue? CostCodeFrom { get; set; }

		[DataMember(Name="CostCodeTo", EmitDefaultValue=false)]
		public StringValue? CostCodeTo { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="WorkCodeID", EmitDefaultValue=false)]
		public StringValue? WorkCodeID { get; set; }

	}
}