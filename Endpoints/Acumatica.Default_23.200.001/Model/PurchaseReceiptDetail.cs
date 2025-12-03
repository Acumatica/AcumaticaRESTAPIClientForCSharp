using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class PurchaseReceiptDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POAccrualAcctID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Accrual Account</para>
		/// </summary>
		[DataMember(Name="AccrualAccount", EmitDefaultValue=false)]
		public StringValue? AccrualAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POAccrualSubID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Accrual Sub.</para>
		/// </summary>
		[DataMember(Name="AccrualSubaccount", EmitDefaultValue=false)]
		public StringValue? AccrualSubaccount { get; set; }

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<PurchaseReceiptDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpenseAcctID_Account_description</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowEditUnitCost</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Editable Unit Cost</para>
		/// </summary>
		[DataMember(Name="EditableUnitCost", EmitDefaultValue=false)]
		public BooleanValue? EditableUnitCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranCost</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Estimated IN Ext. Cost</para>
		/// </summary>
		[DataMember(Name="EstimatedINExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? EstimatedINExtendedCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExtCost</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Ext. Cost</para>
		/// </summary>
		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? ExtendedCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranCostFinal</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Final IN Ext. Cost</para>
		/// </summary>
		[DataMember(Name="FinalINExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? FinalINExtendedCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Line Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue? LineType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OpenOrderQty</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Open Qty.</para>
		/// </summary>
		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigOrderQty</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Ordered Qty.</para>
		/// </summary>
		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: PO Line Nbr.</para>
		/// </summary>
		[DataMember(Name="POLineNbr", EmitDefaultValue=false)]
		public IntValue? POLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PONbr</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: PO Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POType</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: PO Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="POOrderType", EmitDefaultValue=false)]
		public StringValue? POOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigReceiptLineNbr</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: PO Receipt Line Nbr.</para>
		/// </summary>
		[DataMember(Name="POReceiptLineNbr", EmitDefaultValue=false)]
		public IntValue? POReceiptLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigReceiptNbr</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: PO Receipt Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="POReceiptNbr", EmitDefaultValue=false)]
		public StringValue? POReceiptNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Receipt Qty.</para>
		/// </summary>
		[DataMember(Name="ReceiptQty", EmitDefaultValue=false)]
		public DecimalValue? ReceiptQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpenseSubID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Sub.</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Transaction Descr.</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderNbr</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// <para>Display Name: SO Return</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TransferOrderNbr", EmitDefaultValue=false)]
		public StringValue? TransferOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderLineNbr</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Transfer Line Nbr.</para>
		/// </summary>
		[DataMember(Name="TransferOrderLineNbr", EmitDefaultValue=false)]
		public IntValue? TransferOrderLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderType</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Transfer Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="TransferOrderType", EmitDefaultValue=false)]
		public StringValue? TransferOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOShipmentNbr</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Transfer Shipment Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TransferShipmentNbr", EmitDefaultValue=false)]
		public StringValue? TransferShipmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnitCost</para>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POReceiptLine</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}