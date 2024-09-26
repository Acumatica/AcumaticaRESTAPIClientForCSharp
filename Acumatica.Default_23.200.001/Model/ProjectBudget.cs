using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PM309000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProjectBudget : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AccountGroupID 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryActualAmount 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue? ActualAmount { get; set; }

		[DataMember(Name="ActualPlusOpenCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue? ActualPlusOpenCommittedAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActualQty 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActualQty", EmitDefaultValue=false)]
		public DecimalValue? ActualQty { get; set; }

		[DataMember(Name="AutoCompleted", EmitDefaultValue=false)]
		public BooleanValue? AutoCompleted { get; set; }

		[DataMember(Name="BudgetedCOAmount", EmitDefaultValue=false)]
		public DecimalValue? BudgetedCOAmount { get; set; }

		[DataMember(Name="BudgetedCOQty", EmitDefaultValue=false)]
		public DecimalValue? BudgetedCOQty { get; set; }

		[DataMember(Name="CommittedCOAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedCOAmount { get; set; }

		[DataMember(Name="CommittedCOQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedCOQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryCommittedInvoicedAmount 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommittedInvoicedAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedInvoicedAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CommittedInvoicedQty 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommittedInvoicedQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedInvoicedQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryCommittedOpenAmount 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommittedOpenAmount", EmitDefaultValue=false)]
		public DecimalValue? CommittedOpenAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CommittedOpenQty 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommittedOpenQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedOpenQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CommittedReceivedQty 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CommittedReceivedQty", EmitDefaultValue=false)]
		public DecimalValue? CommittedReceivedQty { get; set; }

		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public DecimalValue? Completed { get; set; }

		[DataMember(Name="CostAtCompletion", EmitDefaultValue=false)]
		public DecimalValue? CostAtCompletion { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		[DataMember(Name="CostToComplete", EmitDefaultValue=false)]
		public DecimalValue? CostToComplete { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DraftInvoicesAmount", EmitDefaultValue=false)]
		public DecimalValue? DraftInvoicesAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LastCostAtCompletion", EmitDefaultValue=false)]
		public DecimalValue? LastCostAtCompletion { get; set; }

		[DataMember(Name="LastCostToComplete", EmitDefaultValue=false)]
		public DecimalValue? LastCostToComplete { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="LastPercentageOfCompletion", EmitDefaultValue=false)]
		public DecimalValue? LastPercentageOfCompletion { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryAmount 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OriginalBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue? OriginalBudgetedAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OriginalBudgetedQty", EmitDefaultValue=false)]
		public DecimalValue? OriginalBudgetedQty { get; set; }

		[DataMember(Name="OriginalCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue? OriginalCommittedAmount { get; set; }

		[DataMember(Name="OriginalCommittedQty", EmitDefaultValue=false)]
		public DecimalValue? OriginalCommittedQty { get; set; }

		[DataMember(Name="PendingInvoiceAmount", EmitDefaultValue=false)]
		public DecimalValue? PendingInvoiceAmount { get; set; }

		[DataMember(Name="PercentageOfCompletion", EmitDefaultValue=false)]
		public DecimalValue? PercentageOfCompletion { get; set; }

		[DataMember(Name="Performance", EmitDefaultValue=false)]
		public DecimalValue? Performance { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectTaskID 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		[DataMember(Name="Retainage", EmitDefaultValue=false)]
		public DecimalValue? Retainage { get; set; }

		[DataMember(Name="RevenueTask", EmitDefaultValue=false)]
		public IntValue? RevenueTask { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryRevisedAmount 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue? RevisedBudgetedAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RevisedQty 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RevisedBudgetedQty", EmitDefaultValue=false)]
		public DecimalValue? RevisedBudgetedQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryCommittedAmount 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RevisedCommittedAmount", EmitDefaultValue=false)]
		public DecimalValue? RevisedCommittedAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CommittedQty 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RevisedCommittedQty", EmitDefaultValue=false)]
		public DecimalValue? RevisedCommittedQty { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Type 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryUnitRate 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnitRate", EmitDefaultValue=false)]
		public DecimalValue? UnitRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UOM 
		/// DAC: PX.Objects.PM.PMBudget 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		[DataMember(Name="VarianceAmount", EmitDefaultValue=false)]
		public DecimalValue? VarianceAmount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}