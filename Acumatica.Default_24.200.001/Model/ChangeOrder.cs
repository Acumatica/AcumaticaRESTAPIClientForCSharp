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
		/// 
		/// Display Name:
		/// DAC Field Name: Date 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ChangeDate", EmitDefaultValue=false)]
		public DateTimeValue? ChangeDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ClassID 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Class", EmitDefaultValue=false)]
		public StringValue? Class { get; set; }

		[DataMember(Name="Commitments", EmitDefaultValue=false)]
		public List<ChangeOrderCommitment>? Commitments { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CommitmentTotal 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommitmentsChangeTotal", EmitDefaultValue=false)]
		public DecimalValue? CommitmentsChangeTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CompletionDate 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CompletionDate", EmitDefaultValue=false)]
		public DateTimeValue? CompletionDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DelayDays 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContractTimeChangeDays", EmitDefaultValue=false)]
		public IntValue? ContractTimeChangeDays { get; set; }

		[DataMember(Name="CostBudget", EmitDefaultValue=false)]
		public List<ChangeOrderCostBudget>? CostBudget { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CostTotal 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostBudgetChangeTotal", EmitDefaultValue=false)]
		public DecimalValue? CostBudgetChangeTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Text 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DetailedDescription", EmitDefaultValue=false)]
		public StringValue? DetailedDescription { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: GrossMarginPct 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="GrossMargin", EmitDefaultValue=false)]
		public DecimalValue? GrossMargin { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: GrossMarginAmount 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="GrossMarginAmount", EmitDefaultValue=false)]
		public DecimalValue? GrossMarginAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Hold 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrigRefNbr 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OriginalCORefNbr", EmitDefaultValue=false)]
		public StringValue? OriginalCORefNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		[DataMember(Name="RevenueBudget", EmitDefaultValue=false)]
		public List<ChangeOrderRevenueBudget>? RevenueBudget { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RevenueTotal 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RevenueBudgetChangeTotal", EmitDefaultValue=false)]
		public DecimalValue? RevenueBudgetChangeTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectNbr 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RevenueChangeNbr", EmitDefaultValue=false)]
		public StringValue? RevenueChangeNbr { get; set; }

		[DataMember(Name="ReverseStatus", EmitDefaultValue=false)]
		public StringValue? ReverseStatus { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}