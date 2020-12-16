using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectBudget : Entity_v4
	{

		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue AccountGroup { get; set; }

		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue ActualAmount { get; set; }

		[DataMember(Name="ActualPlusOpenCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue ActualPlusOpenCommittedAmount { get; set; }

		[DataMember(Name="ActualQty", EmitDefaultValue=false)]
		public DecimalValue ActualQty { get; set; }

		[DataMember(Name="AutoCompleted", EmitDefaultValue=false)]
		public BooleanValue AutoCompleted { get; set; }

		[DataMember(Name="BudgetedCOAmount", EmitDefaultValue=false)]
		public DecimalValue BudgetedCOAmount { get; set; }

		[DataMember(Name="BudgetedCOQty", EmitDefaultValue=false)]
		public DecimalValue BudgetedCOQty { get; set; }

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

		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public DecimalValue Completed { get; set; }

		[DataMember(Name="CostAtCompletion", EmitDefaultValue=false)]
		public DecimalValue CostAtCompletion { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="CostToComplete", EmitDefaultValue=false)]
		public DecimalValue CostToComplete { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DraftInvoicesAmount", EmitDefaultValue=false)]
		public DecimalValue DraftInvoicesAmount { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LastCostAtCompletion", EmitDefaultValue=false)]
		public DecimalValue LastCostAtCompletion { get; set; }

		[DataMember(Name="LastCostToComplete", EmitDefaultValue=false)]
		public DecimalValue LastCostToComplete { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LastPercentageOfCompletion", EmitDefaultValue=false)]
		public DecimalValue LastPercentageOfCompletion { get; set; }

		[DataMember(Name="OriginalBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue OriginalBudgetedAmount { get; set; }

		[DataMember(Name="OriginalBudgetedQty", EmitDefaultValue=false)]
		public DecimalValue OriginalBudgetedQty { get; set; }

		[DataMember(Name="OriginalCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue OriginalCommittedAmount { get; set; }

		[DataMember(Name="OriginalCommittedQty", EmitDefaultValue=false)]
		public DecimalValue OriginalCommittedQty { get; set; }

		[DataMember(Name="PendingInvoiceAmount", EmitDefaultValue=false)]
		public DecimalValue PendingInvoiceAmount { get; set; }

		[DataMember(Name="PercentageOfCompletion", EmitDefaultValue=false)]
		public DecimalValue PercentageOfCompletion { get; set; }

		[DataMember(Name="Performance", EmitDefaultValue=false)]
		public DecimalValue Performance { get; set; }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue ProjectID { get; set; }

		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue ProjectTaskID { get; set; }

		[DataMember(Name="Retainage", EmitDefaultValue=false)]
		public DecimalValue Retainage { get; set; }

		[DataMember(Name="RevenueTask", EmitDefaultValue=false)]
		public IntValue RevenueTask { get; set; }

		[DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue RevisedBudgetedAmount { get; set; }

		[DataMember(Name="RevisedBudgetedQty", EmitDefaultValue=false)]
		public DecimalValue RevisedBudgetedQty { get; set; }

		[DataMember(Name="RevisedCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue RevisedCommittedAmount { get; set; }

		[DataMember(Name="RevisedCommittedQty", EmitDefaultValue=false)]
		public DecimalValue RevisedCommittedQty { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="UnitRate", EmitDefaultValue=false)]
		public DecimalValue UnitRate { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="VarianceAmount", EmitDefaultValue=false)]
		public DecimalValue VarianceAmount { get; set; }

	}
}