using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectBillingAndAllocationSettings : Entity
	{

		[DataMember(Name="AllocationRule", EmitDefaultValue=false)]
		public StringValue? AllocationRule { get; set; }

		[DataMember(Name="AutomaticallyReleaseARDocuments", EmitDefaultValue=false)]
		public BooleanValue? AutomaticallyReleaseARDocuments { get; set; }

		[DataMember(Name="BillingPeriod", EmitDefaultValue=false)]
		public StringValue? BillingPeriod { get; set; }

		[DataMember(Name="BillingRule", EmitDefaultValue=false)]
		public StringValue? BillingRule { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="CreateProFormaOnBilling", EmitDefaultValue=false)]
		public BooleanValue? CreateProFormaOnBilling { get; set; }

		[DataMember(Name="LastBillingDate", EmitDefaultValue=false)]
		public DateTimeValue? LastBillingDate { get; set; }

		[DataMember(Name="NextBillingDate", EmitDefaultValue=false)]
		public DateTimeValue? NextBillingDate { get; set; }

		[DataMember(Name="RateTable", EmitDefaultValue=false)]
		public StringValue? RateTable { get; set; }

		[DataMember(Name="Retainage", EmitDefaultValue=false)]
		public DecimalValue? Retainage { get; set; }

		[DataMember(Name="RunAllocationOnReleaseOfProjectTransactions", EmitDefaultValue=false)]
		public BooleanValue? RunAllocationOnReleaseOfProjectTransactions { get; set; }

		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		[DataMember(Name="UseTMRevenueBudgetLimits", EmitDefaultValue=false)]
		public BooleanValue? UseTMRevenueBudgetLimits { get; set; }

	}
}