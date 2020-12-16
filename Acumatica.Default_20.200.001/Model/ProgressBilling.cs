using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProgressBilling : Entity_v4
	{

		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue ActualAmount { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="AmountToInvoice", EmitDefaultValue=false)]
		public DecimalValue AmountToInvoice { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="CurrentInvoiced", EmitDefaultValue=false)]
		public DecimalValue CurrentInvoiced { get; set; }

		[DataMember(Name="DeferralCode", EmitDefaultValue=false)]
		public StringValue DeferralCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DraftInvoicesAmount", EmitDefaultValue=false)]
		public DecimalValue DraftInvoicesAmount { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="PreviouslyInvoiced", EmitDefaultValue=false)]
		public DecimalValue PreviouslyInvoiced { get; set; }

		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue ProjectTaskID { get; set; }

		[DataMember(Name="Retainage", EmitDefaultValue=false)]
		public DecimalValue Retainage { get; set; }

		[DataMember(Name="RetainageAmount", EmitDefaultValue=false)]
		public DecimalValue RetainageAmount { get; set; }

		[DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue RevisedBudgetedAmount { get; set; }

		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue SalesAccount { get; set; }

		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue SalesSubaccount { get; set; }

		[DataMember(Name="StoredMaterial", EmitDefaultValue=false)]
		public DecimalValue StoredMaterial { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="TotalCompleted", EmitDefaultValue=false)]
		public DecimalValue TotalCompleted { get; set; }

	}
}