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
	public class PurchaseReceiptDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: ExpenseAcctID 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// DAC Field Name: POAccrualAcctID 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Accrual Account 
		/// </summary>
		[DataMember(Name="AccrualAccount", EmitDefaultValue=false)]
		public StringValue? AccrualAccount { get; set; }

		/// <summary>
		/// DAC Field Name: POAccrualSubID 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Accrual Sub. 
		/// </summary>
		[DataMember(Name="AccrualSubaccount", EmitDefaultValue=false)]
		public StringValue? AccrualSubaccount { get; set; }

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<PurchaseReceiptDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: ExpenseAcctID_Account_description 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: AllowEditUnitCost 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Editable Unit Cost 
		/// </summary>
		[DataMember(Name="EditableUnitCost", EmitDefaultValue=false)]
		public BooleanValue? EditableUnitCost { get; set; }

		/// <summary>
		/// DAC Field Name: TranCost 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Estimated IN Ext. Cost 
		/// </summary>
		[DataMember(Name="EstimatedINExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? EstimatedINExtendedCost { get; set; }

		/// <summary>
		/// DAC Field Name: CuryExtCost 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Ext. Cost 
		/// </summary>
		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? ExtendedCost { get; set; }

		/// <summary>
		/// DAC Field Name: ExpireDate 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// DAC Field Name: TranCostFinal 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Final IN Ext. Cost 
		/// </summary>
		[DataMember(Name="FinalINExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? FinalINExtendedCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Line Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue? LineType { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OpenOrderQty 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Open Qty. 
		/// </summary>
		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// DAC Field Name: OrigOrderQty 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Ordered Qty. 
		/// </summary>
		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: PO Line Nbr. 
		/// </summary>
		[DataMember(Name="POLineNbr", EmitDefaultValue=false)]
		public IntValue? POLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: PONbr 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: PO Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: POType 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: PO Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="POOrderType", EmitDefaultValue=false)]
		public StringValue? POOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: OrigReceiptLineNbr 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: PO Receipt Line Nbr. 
		/// </summary>
		[DataMember(Name="POReceiptLineNbr", EmitDefaultValue=false)]
		public IntValue? POReceiptLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OrigReceiptNbr 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: PO Receipt Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="POReceiptNbr", EmitDefaultValue=false)]
		public StringValue? POReceiptNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Receipt Qty. 
		/// </summary>
		[DataMember(Name="ReceiptQty", EmitDefaultValue=false)]
		public DecimalValue? ReceiptQty { get; set; }

		/// <summary>
		/// DAC Field Name: ExpenseSubID 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Sub. 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Transaction Descr. 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderNbr 
		/// DAC: PX.Objects.PO.POReceipt 
		/// Display Name: SO Return 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TransferOrderNbr", EmitDefaultValue=false)]
		public StringValue? TransferOrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderLineNbr 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Transfer Line Nbr. 
		/// </summary>
		[DataMember(Name="TransferOrderLineNbr", EmitDefaultValue=false)]
		public IntValue? TransferOrderLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderType 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Transfer Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="TransferOrderType", EmitDefaultValue=false)]
		public StringValue? TransferOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: SOShipmentNbr 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Transfer Shipment Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TransferShipmentNbr", EmitDefaultValue=false)]
		public StringValue? TransferShipmentNbr { get; set; }

		/// <summary>
		/// DAC Field Name: CuryUnitCost 
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POReceiptLine 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.PO.POReceipt 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}