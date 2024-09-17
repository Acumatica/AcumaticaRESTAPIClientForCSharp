using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class ProjectRetainage : Entity
	{

		[DataMember(Name="RetainageMode", EmitDefaultValue=false)]
		public StringValue? RetainageMode { get; set; }

		[DataMember(Name="IncludeCO", EmitDefaultValue=false)]
		public BooleanValue? IncludeCO { get; set; }

		[DataMember(Name="UseSteps", EmitDefaultValue=false)]
		public BooleanValue? UseSteps { get; set; }

		[DataMember(Name="CapPct", EmitDefaultValue=false)]
		public DecimalValue? CapPct { get; set; }

		[DataMember(Name="CapAmount", EmitDefaultValue=false)]
		public DecimalValue? CapAmount { get; set; }

		[DataMember(Name="RetainagePct", EmitDefaultValue=false)]
		public DecimalValue? RetainagePct { get; set; }

		[DataMember(Name="RetainTotal", EmitDefaultValue=false)]
		public DecimalValue? RetainTotal { get; set; }

		[DataMember(Name="ContractTotal", EmitDefaultValue=false)]
		public DecimalValue? ContractTotal { get; set; }

		[DataMember(Name="CompletedPct", EmitDefaultValue=false)]
		public DecimalValue? CompletedPct { get; set; }

	}
}