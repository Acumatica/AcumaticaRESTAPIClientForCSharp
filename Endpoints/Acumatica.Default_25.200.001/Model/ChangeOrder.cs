using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM308000</c> in the Acumatica ERP
	/// <para>Key Fields: RefNbr</para>
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
		/// <para>DAC Field Name: Date</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Change Date</para>
		/// </summary>
		[DataMember(Name="ChangeDate", EmitDefaultValue=false)]
		public DateTimeValue? ChangeDate { get; set; }

		/// <summary>
		/// The identifier of the GL change order class that provides default settings for the change order.
		/// <para>DAC Field Name: ClassID</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="Class", EmitDefaultValue=false)]
		public StringValue? Class { get; set; }

		[DataMember(Name="Commitments", EmitDefaultValue=false)]
		public List<ChangeOrderCommitment>? Commitments { get; set; }

		/// <summary>
		/// The total amount in project currency of the commitments lines of the document.
		/// <para>DAC Field Name: CommitmentTotal</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Commitment Change Total</para>
		/// </summary>
		[DataMember(Name="CommitmentsChangeTotal", EmitDefaultValue=false)]
		public DecimalValue? CommitmentsChangeTotal { get; set; }

		/// <summary>
		/// The date that has been communicated to the customer as the approval date of the agreed-upon changes.
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Approval Date</para>
		/// </summary>
		[DataMember(Name="CompletionDate", EmitDefaultValue=false)]
		public DateTimeValue? CompletionDate { get; set; }

		/// <summary>
		/// A positive or negative number of days that represents the delay of the contract.
		/// <para>DAC Field Name: DelayDays</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Contract Change (Days)</para>
		/// </summary>
		[DataMember(Name="ContractTimeChangeDays", EmitDefaultValue=false)]
		public IntValue? ContractTimeChangeDays { get; set; }

		[DataMember(Name="CostBudget", EmitDefaultValue=false)]
		public List<ChangeOrderCostBudget>? CostBudget { get; set; }

		/// <summary>
		/// The total amount of thecost budget lines of the document.
		/// <para>DAC Field Name: CostTotal</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Cost Budget Change Total</para>
		/// </summary>
		[DataMember(Name="CostBudgetChangeTotal", EmitDefaultValue=false)]
		public DecimalValue? CostBudgetChangeTotal { get; set; }

		/// <summary>
		/// The identifier of the customer associated with the project.
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// The description of the change order.
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// A detailed description of the change order.
		/// <para>DAC Field Name: Text</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Details</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="DetailedDescription", EmitDefaultValue=false)]
		public StringValue? DetailedDescription { get; set; }

		/// <summary>
		/// The external reference number (such as an identifier required by the customer or a number from an external system integrated with Acumatica ERP) entered            manually.
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: External Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// The gross margin percent.
		/// <para>DAC Field Name: GrossMarginPct</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Gross Margin (%)</para>
		/// </summary>
		[DataMember(Name="GrossMargin", EmitDefaultValue=false)]
		public DecimalValue? GrossMargin { get; set; }

		/// <summary>
		/// The difference between the Revenue Budget Change Totaland the Cost Budget Change Total values.
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Gross Margin Amount</para>
		/// </summary>
		[DataMember(Name="GrossMarginAmount", EmitDefaultValue=false)]
		public DecimalValue? GrossMarginAmount { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the document is on hold.
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The reference number of the original change orderwhose changes the currently selected change order reverses.
		/// <para>DAC Field Name: OrigRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Original CO Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="OriginalCORefNbr", EmitDefaultValue=false)]
		public StringValue? OriginalCORefNbr { get; set; }

		/// <summary>
		/// The identifier of the project associated with the change order.
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Project</para>
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The reference number of the change order.
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		[DataMember(Name="RevenueBudget", EmitDefaultValue=false)]
		public List<ChangeOrderRevenueBudget>? RevenueBudget { get; set; }

		/// <summary>
		/// The total amount of therevenue budget lines of the document.
		/// <para>DAC Field Name: RevenueTotal</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Revenue Budget Change Total</para>
		/// </summary>
		[DataMember(Name="RevenueBudgetChangeTotal", EmitDefaultValue=false)]
		public DecimalValue? RevenueBudgetChangeTotal { get; set; }

		/// <summary>
		/// The change number.
		/// <para>DAC Field Name: ProjectNbr</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: Revenue Change Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="RevenueChangeNbr", EmitDefaultValue=false)]
		public StringValue? RevenueChangeNbr { get; set; }

		[DataMember(Name="ReverseStatus", EmitDefaultValue=false)]
		public StringValue? ReverseStatus { get; set; }

		/// <summary>
		/// The status of the change order.
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string ApprovalDetails = "ApprovalDetails";
			public const string ApprovalDetails_Files = "ApprovalDetails/Files";
			public const string Attributes = "Attributes";
			public const string Commitments = "Commitments";
			public const string Commitments_Files = "Commitments/Files";
			public const string CostBudget = "CostBudget";
			public const string CostBudget_Files = "CostBudget/Files";
			public const string RevenueBudget = "RevenueBudget";
			public const string RevenueBudget_Files = "RevenueBudget/Files";

			//Intentionally excluded
			//public const string All = "Files,ApprovalDetails,ApprovalDetails/Files,Attributes,Commitments,Commitments/Files,CostBudget,CostBudget/Files,RevenueBudget,RevenueBudget/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}