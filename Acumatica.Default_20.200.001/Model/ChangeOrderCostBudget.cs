using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ChangeOrderCostBudget : Entity_v4
	{

		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue AccountGroup { get; set; }

		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue ActualAmount { get; set; }

		[DataMember(Name="ActualQty", EmitDefaultValue=false)]
		public DecimalValue ActualQty { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="CommittedCOAmount", EmitDefaultValue=false)]
		public DecimalValue CommittedCOAmount { get; set; }

		[DataMember(Name="CommittedCOQty", EmitDefaultValue=false)]
		public DecimalValue CommittedCOQty { get; set; }

		[DataMember(Name="CommittedInvoicedAmount", EmitDefaultValue=false)]
		public DecimalValue CommittedInvoicedAmount { get; set; }

		[DataMember(Name="CommittedInvoicedQty", EmitDefaultValue=false)]
		public DecimalValue CommittedInvoicedQty { get; set; }

		[DataMember(Name="CommittedOpenAmount", EmitDefaultValue=false)]
		public DecimalValue CommittedOpenAmount { get; set; }

		[DataMember(Name="CommittedOpenQty", EmitDefaultValue=false)]
		public DecimalValue CommittedOpenQty { get; set; }

		[DataMember(Name="CommittedReceivedQty", EmitDefaultValue=false)]
		public DecimalValue CommittedReceivedQty { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="CurrentCommittedCOAmount", EmitDefaultValue=false)]
		public DecimalValue CurrentCommittedCOAmount { get; set; }

		[DataMember(Name="CurrentCommittedCOQty", EmitDefaultValue=false)]
		public DecimalValue CurrentCommittedCOQty { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="OriginalBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue OriginalBudgetedAmount { get; set; }

		[DataMember(Name="OriginalBudgetedQty", EmitDefaultValue=false)]
		public DecimalValue OriginalBudgetedQty { get; set; }

		[DataMember(Name="OtherDraftCOAmount", EmitDefaultValue=false)]
		public DecimalValue OtherDraftCOAmount { get; set; }

		[DataMember(Name="PreviouslyApprovedCOAmount", EmitDefaultValue=false)]
		public DecimalValue PreviouslyApprovedCOAmount { get; set; }

		[DataMember(Name="PreviouslyApprovedCOQty", EmitDefaultValue=false)]
		public DecimalValue PreviouslyApprovedCOQty { get; set; }

		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue ProjectTaskID { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue RevisedBudgetedAmount { get; set; }

		[DataMember(Name="RevisedBudgetedQty", EmitDefaultValue=false)]
		public DecimalValue RevisedBudgetedQty { get; set; }

		[DataMember(Name="RevisedCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue RevisedCommittedAmount { get; set; }

		[DataMember(Name="RevisedCommittedQty", EmitDefaultValue=false)]
		public DecimalValue RevisedCommittedQty { get; set; }

		[DataMember(Name="TotalPotentiallyRevisedAmount", EmitDefaultValue=false)]
		public DecimalValue TotalPotentiallyRevisedAmount { get; set; }

		[DataMember(Name="UnitRate", EmitDefaultValue=false)]
		public DecimalValue UnitRate { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}