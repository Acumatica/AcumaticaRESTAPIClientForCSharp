using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ChangeOrderCostBudget : Entity
	{

		/// <summary>
		/// The identifier of the account group associated with the change order line.
		/// <para>DAC Field Name: AccountGroupID</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// <para>Display Name: Account Group</para>
		/// </summary>
		public StringValue? AccountGroup { get; set; }

		public DecimalValue? ActualAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMBudget__ActualQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? ActualQty { get; set; }

		/// <summary>
		/// The amount of the change order line in the base currency. The value can be manually modified.
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		public DecimalValue? CommittedCOAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMBudget__CommittedCOQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? CommittedCOQty { get; set; }

		public DecimalValue? CommittedInvoicedAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMBudget__CommittedInvoicedQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? CommittedInvoicedQty { get; set; }

		public DecimalValue? CommittedOpenAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMBudget__CommittedOpenQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? CommittedOpenQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMBudget__CommittedReceivedQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? CommittedReceivedQty { get; set; }

		/// <summary>
		/// The identifier of the cost code associated with the change order line.
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The total amount of the commitment lines of the currently selected change orderthat are associated with the same project, project task, account group, and cost code or inventory item.The amount is displayed in the base currency.
		/// <para>DAC Field Name: CommittedCOAmount</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? CurrentCommittedCOAmount { get; set; }

		/// <summary>
		/// The total quantity of the commitment lines of the currently selected change orderthat are associated with the same project, project task, account group, and cost code or inventory item.
		/// <para>DAC Field Name: CommittedCOQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? CurrentCommittedCOQty { get; set; }

		/// <summary>
		/// The description of the change order.
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The identifier of the inventory item associated with the change order line.
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public DecimalValue? OriginalBudgetedAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMBudget__Qty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? OriginalBudgetedQty { get; set; }

		/// <summary>
		/// The total amount of lines of the unreleased change orders (except for the current one) that refer to the cost budget line with the same project, project task,            account group, and cost code or inventory item. The amount is displayed in the base currency.
		/// <para>DAC Field Name: OtherDraftRevisedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? OtherDraftCOAmount { get; set; }

		/// <summary>
		/// The total amount of the released change orders that were created before the current oneand that are associated with the same project, project task, account group, and cost code or inventory item.The amount is displayed in the base currency.
		/// <para>DAC Field Name: PreviouslyApprovedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? PreviouslyApprovedCOAmount { get; set; }

		/// <summary>
		/// The total quantity of the released change orders that were created before the current oneand that are associated with the same project, project task, account group, and cost code or inventory item.
		/// <para>DAC Field Name: PreviouslyApprovedQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? PreviouslyApprovedCOQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// The quantity of the change order line.
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// The sum of the Original Budgeted Amount,Previously Approved CO Amount,and Amount values. The amount is displayed in the base currency.
		/// <para>DAC Field Name: RevisedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// <para>Display Name: Revised Budgeted Amount</para>
		/// </summary>
		public DecimalValue? RevisedBudgetedAmount { get; set; }

		/// <summary>
		/// The sum of the Original Budgeted Quantity,Previously Approved CO Quantity,and Quantity values.
		/// <para>DAC Field Name: RevisedQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// <para>Display Name: Revised Budgeted Quantity</para>
		/// </summary>
		public DecimalValue? RevisedBudgetedQty { get; set; }

		public DecimalValue? RevisedCommittedAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMBudget__CommittedQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? RevisedCommittedQty { get; set; }

		/// <summary>
		/// The sum of the Revised Budgeted Amount and Other Draft CO Amount values. The amount is displayed in the base currency.
		/// <para>DAC Field Name: TotalPotentialRevisedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? TotalPotentiallyRevisedAmount { get; set; }

		/// <summary>
		/// The cost of the specified unit of the change order line. The value can be manually modified.
		/// <para>DAC Field Name: Rate</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// <para>Display Name: Unit Rate</para>
		/// </summary>
		public DecimalValue? UnitRate { get; set; }

		/// <summary>
		/// The unit of measure of the change order line.
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

	}
}