using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ChangeOrderCommitment : Entity
	{

		/// <summary>
		/// The expense account associated with the commitment.
		/// <para>DAC Field Name: AccountID</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// The amount of the change order line in the base currency. The value can be manually modified.
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The amount of the commitment in the project currency.
		/// <para>DAC Field Name: AmountInProjectCury</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// <para>Display Name: Amount in Project Currency</para>
		/// </summary>
		public DecimalValue? AmountinBaseCurrency { get; set; }

		/// <summary>
		/// The identifier of the cost code associated with the change order line.
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The identifier of the commitment currency.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

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

		/// <summary>
		/// <para>DAC Field Name: POLinePM__CuryLineAmt</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// </summary>
		public DecimalValue? LineAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POLinePM__TranDesc</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// </summary>
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POLinePM__CalcOpenQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// </summary>
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POLinePM__OrderDate</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// </summary>
		public DateTimeValue? OrderDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POLinePM__OrderQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// </summary>
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// <para>Display Name: PO Line Nbr.</para>
		/// </summary>
		public IntValue? POLineNbr { get; set; }

		/// <summary>
		/// The reference number of the purchase order associated with the commitment.
		/// <para>DAC Field Name: POOrderNbr</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// <para>Display Name: PO Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? PONbr { get; set; }

		/// <summary>
		/// The sum of the amount and the original amount of the purchase order line associated with the commitment.
		/// <para>DAC Field Name: PotentialRevisedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// </summary>
		public DecimalValue? PotentiallyRevisedAmount { get; set; }

		/// <summary>
		/// The sum of the quantity and original quantity of the purchase order line associated with the commitment.
		/// <para>DAC Field Name: PotentialRevisedQty</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// </summary>
		public DecimalValue? PotentiallyRevisedQty { get; set; }

		/// <summary>
		/// The identifier of the Task associated with the commitment.
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
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
		/// The status of the commitment line of the change order.
		/// <para>DAC Field Name: LineType</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// The cost of the specified unit of the commitment. The value can be manually modified.
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// The unit of measure of the change order line.
		/// <para>DAC: PX.Objects.PM.PMChangeOrderCostBudget</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The type of the purchase order associated with the commitment.
		/// <para>DAC Field Name: POOrderType</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrderLine</para>
		/// <para>Display Name: PO Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? POType { get; set; }

	}
}