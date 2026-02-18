using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class PurchaseOrderDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Alternate ID</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? AlternateID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Branch</para>
		/// </summary>
		public StringValue? BranchID { get; set; }

		public BooleanValue? CalculateDiscountsOnImport { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		public BooleanValue? Cancelled { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		public BooleanValue? Completed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RcptQtyThreshold</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Complete On (%)</para>
		/// </summary>
		public DecimalValue? CompleteOn { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpenseAcctID_Account_description</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryLineAmt</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Ext. Cost</para>
		/// </summary>
		public DecimalValue? ExtendedCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Line Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Line Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? LineType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RcptQtyMax</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Max. Receipt (%)</para>
		/// </summary>
		public DecimalValue? MaxReceiptPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RcptQtyMin</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Min. Receipt (%)</para>
		/// </summary>
		public DecimalValue? MinReceiptPercent { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Order Qty.</para>
		/// </summary>
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Qty. On Orders</para>
		/// </summary>
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PONbr</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Blanket PO Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? OrigPONbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POType</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Blanket PO Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrigPOType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PromisedDate</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		public DateTimeValue? Promised { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReceivedQty</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Qty. On Receipts</para>
		/// </summary>
		public DecimalValue? QtyOnReceipts { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RcptQtyAction</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Receipt Action</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ReceiptAction { get; set; }

		public DecimalValue? ReceivedAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RequestedDate</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		public DateTimeValue? Requested { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpenseSubID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Sub.</para>
		/// </summary>
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnitCost</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

	}
}