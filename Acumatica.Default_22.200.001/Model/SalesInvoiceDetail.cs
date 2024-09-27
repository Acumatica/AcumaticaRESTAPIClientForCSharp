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
	public class SalesInvoiceDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: CuryTranAmt 
		/// DAC: PX.Objects.AR.ARTran 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The identifier of the branch to which the document belongs.
		/// DAC: PX.Objects.AR.ARInvoice 
		/// Display Name: Branch 
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		[DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
		public BooleanValue? CalculateDiscountsOnImport { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// DAC Field Name: AccountID_Account_description 
		/// DAC: PX.Objects.AR.ARTran 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDiscAmt 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Discount Amount 
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// DAC Field Name: DiscPct 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Discount Percent 
		/// </summary>
		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// DAC Field Name: ExpireDate 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// DAC Field Name: InvtDocType 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Inventory Doc. Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="InventoryDocType", EmitDefaultValue=false)]
		public StringValue? InventoryDocType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: InvtRefNbr 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Inventory Ref. Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
		public StringValue? InventoryRefNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.AR.ARTran 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ManualDisc 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Manual Discount 
		/// </summary>
		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue? ManualDiscount { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderLineNbr 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Order Line Nbr 
		/// </summary>
		[DataMember(Name="OrderLineNbr", EmitDefaultValue=false)]
		public IntValue? OrderLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderNbr 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SOOrderType 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: OrigInvoiceLineNbr 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Orig. Inv. Line Nbr. 
		/// </summary>
		[DataMember(Name="OrigInvLineNbr", EmitDefaultValue=false)]
		public IntValue? OrigInvLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OrigInvoiceNbr 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Orig. Inv. Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="OrigInvNbr", EmitDefaultValue=false)]
		public StringValue? OrigInvNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OrigInvoiceType 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Orig. Inv. Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="OrigInvType", EmitDefaultValue=false)]
		public StringValue? OrigInvType { get; set; }

		/// <summary>
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Quantity 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// DAC Field Name: SOShipmentNbr 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Shipment Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AR.ARTran 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Transaction Descr. 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="TransactionDescr", EmitDefaultValue=false)]
		public StringValue? TransactionDescr { get; set; }

		/// <summary>
		/// DAC Field Name: CuryUnitPrice 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Unit Price 
		/// </summary>
		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARTran 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AR.ARTran 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

	}
}