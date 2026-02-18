using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class PurchaseReceiptDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POAccrualAcctID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Accrual Account</para>
		/// </summary>
		public StringValue? AccrualAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POAccrualSubID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Accrual Sub.</para>
		/// </summary>
		public StringValue? AccrualSubaccount { get; set; }

		public List<PurchaseReceiptDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpenseAcctID_Account_description</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowEditUnitCost</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Editable Unit Cost</para>
		/// </summary>
		public BooleanValue? EditableUnitCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranCost</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Estimated IN Ext. Cost</para>
		/// </summary>
		public DecimalValue? EstimatedINExtendedCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExtCost</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Ext. Cost</para>
		/// </summary>
		public DecimalValue? ExtendedCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranCostFinal</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Final IN Ext. Cost</para>
		/// </summary>
		public DecimalValue? FinalINExtendedCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Line Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? LineType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OpenOrderQty</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Open Qty.</para>
		/// </summary>
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigOrderQty</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Ordered Qty.</para>
		/// </summary>
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: PO Line Nbr.</para>
		/// </summary>
		public IntValue? POLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PONbr</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: PO Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POType</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: PO Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? POOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigReceiptLineNbr</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: PO Receipt Line Nbr.</para>
		/// </summary>
		public IntValue? POReceiptLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigReceiptNbr</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: PO Receipt Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? POReceiptNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Receipt Qty.</para>
		/// </summary>
		public DecimalValue? ReceiptQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpenseSubID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Sub.</para>
		/// </summary>
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Transaction Descr.</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderNbr</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: SO Return</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TransferOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderLineNbr</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Transfer Line Nbr.</para>
		/// </summary>
		public IntValue? TransferOrderLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderType</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Transfer Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? TransferOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOShipmentNbr</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Transfer Shipment Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TransferShipmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnitCost</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}