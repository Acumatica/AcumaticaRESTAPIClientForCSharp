using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ChangeOrder : Entity_v4
	{

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval> ApprovalDetails { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="ChangeDate", EmitDefaultValue=false)]
		public DateTimeValue ChangeDate { get; set; }

		[DataMember(Name="Class", EmitDefaultValue=false)]
		public StringValue Class { get; set; }

		[DataMember(Name="Commitments", EmitDefaultValue=false)]
		public List<ChangeOrderCommitment> Commitments { get; set; }

		[DataMember(Name="CommitmentsChangeTotal", EmitDefaultValue=false)]
		public DecimalValue CommitmentsChangeTotal { get; set; }

		[DataMember(Name="CompletionDate", EmitDefaultValue=false)]
		public DateTimeValue CompletionDate { get; set; }

		[DataMember(Name="ContractTimeChangeDays", EmitDefaultValue=false)]
		public IntValue ContractTimeChangeDays { get; set; }

		[DataMember(Name="CostBudget", EmitDefaultValue=false)]
		public List<ChangeOrderCostBudget> CostBudget { get; set; }

		[DataMember(Name="CostBudgetChangeTotal", EmitDefaultValue=false)]
		public DecimalValue CostBudgetChangeTotal { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DetailedDescription", EmitDefaultValue=false)]
		public StringValue DetailedDescription { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue ExternalRefNbr { get; set; }

		[DataMember(Name="GrossMargin", EmitDefaultValue=false)]
		public DecimalValue GrossMargin { get; set; }

		[DataMember(Name="GrossMarginAmount", EmitDefaultValue=false)]
		public DecimalValue GrossMarginAmount { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="OriginalCORefNbr", EmitDefaultValue=false)]
		public StringValue OriginalCORefNbr { get; set; }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue ProjectID { get; set; }

		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue RefNbr { get; set; }

		[DataMember(Name="RevenueBudget", EmitDefaultValue=false)]
		public List<ChangeOrderRevenueBudget> RevenueBudget { get; set; }

		[DataMember(Name="RevenueBudgetChangeTotal", EmitDefaultValue=false)]
		public DecimalValue RevenueBudgetChangeTotal { get; set; }

		[DataMember(Name="RevenueChangeNbr", EmitDefaultValue=false)]
		public StringValue RevenueChangeNbr { get; set; }

		[DataMember(Name="ReverseStatus", EmitDefaultValue=false)]
		public StringValue ReverseStatus { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

	}
}