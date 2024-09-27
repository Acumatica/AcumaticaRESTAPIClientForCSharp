using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PM308000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ChangeOrder : Entity, ITopLevelEntity
	{

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval>? ApprovalDetails { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The date on which the changes made with the change order should be recorded in the project balances.
		/// DAC Field Name: Date 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Change Date 
		/// </summary>
		[DataMember(Name="ChangeDate", EmitDefaultValue=false)]
		public DateTimeValue? ChangeDate { get; set; }

		/// <summary>
		/// The identifier of the GL change order class that provides default settings for the change order.
		/// DAC Field Name: ClassID 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="Class", EmitDefaultValue=false)]
		public StringValue? Class { get; set; }

		[DataMember(Name="Commitments", EmitDefaultValue=false)]
		public List<ChangeOrderCommitment>? Commitments { get; set; }

		/// <summary>
		/// The total amount in project currency of the commitments lines of the document.
		/// DAC Field Name: CommitmentTotal 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Commitment Change Total 
		/// </summary>
		[DataMember(Name="CommitmentsChangeTotal", EmitDefaultValue=false)]
		public DecimalValue? CommitmentsChangeTotal { get; set; }

		/// <summary>
		/// The date that has been communicated to the customer as the approval date of the agreed-upon changes.
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Approval Date 
		/// </summary>
		[DataMember(Name="CompletionDate", EmitDefaultValue=false)]
		public DateTimeValue? CompletionDate { get; set; }

		/// <summary>
		/// A positive or negative number of days that represents the delay of the contract.
		/// DAC Field Name: DelayDays 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Contract Change (Days) 
		/// </summary>
		[DataMember(Name="ContractTimeChangeDays", EmitDefaultValue=false)]
		public IntValue? ContractTimeChangeDays { get; set; }

		[DataMember(Name="CostBudget", EmitDefaultValue=false)]
		public List<ChangeOrderCostBudget>? CostBudget { get; set; }

		/// <summary>
		/// The total amount of thecost budget lines of the document.
		/// DAC Field Name: CostTotal 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Cost Budget Change Total 
		/// </summary>
		[DataMember(Name="CostBudgetChangeTotal", EmitDefaultValue=false)]
		public DecimalValue? CostBudgetChangeTotal { get; set; }

		/// <summary>
		/// The identifier of the customer associated with the project.
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// The description of the change order.
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// A detailed description of the change order.
		/// DAC Field Name: Text 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Details 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="DetailedDescription", EmitDefaultValue=false)]
		public StringValue? DetailedDescription { get; set; }

		/// <summary>
		/// The external reference number (such as an identifier required by the customer or a number from an external system integrated with Acumatica ERP) entered            manually.
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: External Ref. Nbr. 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// The gross margin percent.
		/// DAC Field Name: GrossMarginPct 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Gross Margin (%) 
		/// </summary>
		[DataMember(Name="GrossMargin", EmitDefaultValue=false)]
		public DecimalValue? GrossMargin { get; set; }

		/// <summary>
		/// The difference between the Revenue Budget Change Totaland the Cost Budget Change Total values.
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Gross Margin Amount 
		/// </summary>
		[DataMember(Name="GrossMarginAmount", EmitDefaultValue=false)]
		public DecimalValue? GrossMarginAmount { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the document is on hold.
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The reference number of the original change orderwhose changes the currently selected change order reverses.
		/// DAC Field Name: OrigRefNbr 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Original CO Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="OriginalCORefNbr", EmitDefaultValue=false)]
		public StringValue? OriginalCORefNbr { get; set; }

		/// <summary>
		/// The identifier of the project associated with the change order.
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Project 
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The reference number of the change order.
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		[DataMember(Name="RevenueBudget", EmitDefaultValue=false)]
		public List<ChangeOrderRevenueBudget>? RevenueBudget { get; set; }

		/// <summary>
		/// The total amount of therevenue budget lines of the document.
		/// DAC Field Name: RevenueTotal 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Revenue Budget Change Total 
		/// </summary>
		[DataMember(Name="RevenueBudgetChangeTotal", EmitDefaultValue=false)]
		public DecimalValue? RevenueBudgetChangeTotal { get; set; }

		/// <summary>
		/// The change number.
		/// DAC Field Name: ProjectNbr 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: Revenue Change Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="RevenueChangeNbr", EmitDefaultValue=false)]
		public StringValue? RevenueChangeNbr { get; set; }

		[DataMember(Name="ReverseStatus", EmitDefaultValue=false)]
		public StringValue? ReverseStatus { get; set; }

		/// <summary>
		/// The status of the change order.
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}