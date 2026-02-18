using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class SalesInvoiceDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AccountID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTranAmt</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The identifier of the branch to which the document belongs.
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Branch</para>
		/// </summary>
		public StringValue? BranchID { get; set; }

		public BooleanValue? CalculateDiscountsOnImport { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AccountID_Account_description</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscAmt</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Discount Amount</para>
		/// </summary>
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscPct</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Discount Percent</para>
		/// </summary>
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		public StringValue? ExternalRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtDocType</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Inventory Doc. Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? InventoryDocType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Inventory Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? InventoryRefNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ManualDisc</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Manual Discount</para>
		/// </summary>
		public BooleanValue? ManualDiscount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Manual Price</para>
		/// </summary>
		public BooleanValue? ManualPrice { get; set; }

		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderLineNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Order Line Nbr</para>
		/// </summary>
		public IntValue? OrderLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderType</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigInvoiceLineNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Orig. Inv. Line Nbr.</para>
		/// </summary>
		public IntValue? OrigInvLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigInvoiceNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Orig. Inv. Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? OrigInvNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigInvoiceType</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Orig. Inv. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? OrigInvType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOShipmentNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Shipment Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Subaccount</para>
		/// </summary>
		public StringValue? SubAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Transaction Descr.</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? TransactionDescr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnitPrice</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>Display Name: Unit Price</para>
		/// </summary>
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AR.ARTran</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

	}
}