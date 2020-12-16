using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SrvOrdFinancialDetails : Entity_v4
	{

		[DataMember(Name="BillingCustomer", EmitDefaultValue=false)]
		public StringValue BillingCustomer { get; set; }

		[DataMember(Name="BillingCycle", EmitDefaultValue=false)]
		public StringValue BillingCycle { get; set; }

		[DataMember(Name="BillingLocation", EmitDefaultValue=false)]
		public StringValue BillingLocation { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="Commissionable", EmitDefaultValue=false)]
		public BooleanValue Commissionable { get; set; }

		[DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
		public StringValue CustomerTaxZone { get; set; }

		[DataMember(Name="RunBillingFor", EmitDefaultValue=false)]
		public StringValue RunBillingFor { get; set; }

		[DataMember(Name="Salesperson", EmitDefaultValue=false)]
		public StringValue Salesperson { get; set; }

		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue TaxCalculationMode { get; set; }

	}
}