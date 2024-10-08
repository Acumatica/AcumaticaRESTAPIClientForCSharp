using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ChangeOrderRevenueBudget : Entity
	{

		/// <summary>
		/// The identifier of the account group associated with the change order line.
		/// DAC Field Name: AccountGroupID 
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// Display Name: Account Group 
		/// Key Field
		/// </summary>
		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		/// <summary>
		/// The amount of the change order line in the base currency. The value can be manually modified.
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The identifier of the cost code associated with the change order line.
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// Display Name: Cost Code 
		/// Key Field
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The description of the change order.
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The identifier of the inventory item associated with the change order line.
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// Display Name: Inventory ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The total amount of lines of the unreleased change orders (except for the current one) that refer to the cost budget line with the same project, project task,            account group, and cost code or inventory item. The amount is displayed in the base currency.
		/// DAC Field Name: OtherDraftRevisedAmount 
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// </summary>
		[DataMember(Name="OtherDraftCOAmount", EmitDefaultValue=false)]
		public DecimalValue? OtherDraftCOAmount { get; set; }

		/// <summary>
		/// The total amount of the released change orders that were created before the current oneand that are associated with the same project, project task, account group, and cost code or inventory item.The amount is displayed in the base currency.
		/// DAC Field Name: PreviouslyApprovedAmount 
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// </summary>
		[DataMember(Name="PreviouslyApprovedCOAmount", EmitDefaultValue=false)]
		public DecimalValue? PreviouslyApprovedCOAmount { get; set; }

		/// <summary>
		/// The total quantity of the released change orders that were created before the current oneand that are associated with the same project, project task, account group, and cost code or inventory item.
		/// DAC Field Name: PreviouslyApprovedQty 
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// </summary>
		[DataMember(Name="PreviouslyApprovedCOQty", EmitDefaultValue=false)]
		public DecimalValue? PreviouslyApprovedCOQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// Display Name: Project Task 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// The quantity of the change order line.
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// Display Name: Quantity 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// The sum of the Original Budgeted Amount,Previously Approved CO Amount,and Amount values. The amount is displayed in the base currency.
		/// DAC Field Name: RevisedAmount 
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// Display Name: Revised Budgeted Amount 
		/// </summary>
		[DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue? RevisedBudgetedAmount { get; set; }

		/// <summary>
		/// The sum of the Original Budgeted Quantity,Previously Approved CO Quantity,and Quantity values.
		/// DAC Field Name: RevisedQty 
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// Display Name: Revised Budgeted Quantity 
		/// </summary>
		[DataMember(Name="RevisedBudgetedQty", EmitDefaultValue=false)]
		public DecimalValue? RevisedBudgetedQty { get; set; }

		/// <summary>
		/// The sum of the Revised Budgeted Amount and Other Draft CO Amount values. The amount is displayed in the base currency.
		/// DAC Field Name: TotalPotentialRevisedAmount 
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// </summary>
		[DataMember(Name="TotalPotentiallyRevisedAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalPotentiallyRevisedAmount { get; set; }

		/// <summary>
		/// The cost of the specified unit of the change order line. The value can be manually modified.
		/// DAC Field Name: Rate 
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// Display Name: Unit Rate 
		/// </summary>
		[DataMember(Name="UnitRate", EmitDefaultValue=false)]
		public DecimalValue? UnitRate { get; set; }

		/// <summary>
		/// The unit of measure of the change order line.
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}