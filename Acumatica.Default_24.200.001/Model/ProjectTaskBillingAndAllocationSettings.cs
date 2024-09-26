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
	public class ProjectTaskBillingAndAllocationSettings : Entity
	{

		[DataMember(Name="AllocationRule", EmitDefaultValue=false)]
		public StringValue? AllocationRule { get; set; }

		[DataMember(Name="BillingOption", EmitDefaultValue=false)]
		public StringValue? BillingOption { get; set; }

		[DataMember(Name="BillingRule", EmitDefaultValue=false)]
		public StringValue? BillingRule { get; set; }

		[DataMember(Name="BillSeparately", EmitDefaultValue=false)]
		public BooleanValue? BillSeparately { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="RateTable", EmitDefaultValue=false)]
		public StringValue? RateTable { get; set; }

		[DataMember(Name="WIPAccountGroup", EmitDefaultValue=false)]
		public StringValue? WIPAccountGroup { get; set; }

	}
}