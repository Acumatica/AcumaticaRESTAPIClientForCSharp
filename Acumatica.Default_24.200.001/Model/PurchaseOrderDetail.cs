using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class PurchaseOrderDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: ExpenseAcctID 
		/// DAC: PX.Objects.PO.POLine 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Alternate ID 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="AlternateID", EmitDefaultValue=false)]
		public StringValue? AlternateID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Branch 
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		[DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
		public BooleanValue? CalculateDiscountsOnImport { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POLine 
		/// </summary>
		[DataMember(Name="Cancelled", EmitDefaultValue=false)]
		public BooleanValue? Cancelled { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POLine 
		/// </summary>
		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public BooleanValue? Completed { get; set; }

		/// <summary>
		/// DAC Field Name: RcptQtyThreshold 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Complete On (%) 
		/// </summary>
		[DataMember(Name="CompleteOn", EmitDefaultValue=false)]
		public DecimalValue? CompleteOn { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// DAC Field Name: ExpenseAcctID_Account_description 
		/// DAC: PX.Objects.PO.POLine 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: CuryLineAmt 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Ext. Cost 
		/// </summary>
		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? ExtendedCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Line Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Line Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue? LineType { get; set; }

		/// <summary>
		/// DAC Field Name: RcptQtyMax 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Max. Receipt (%) 
		/// </summary>
		[DataMember(Name="MaxReceiptPercent", EmitDefaultValue=false)]
		public DecimalValue? MaxReceiptPercent { get; set; }

		/// <summary>
		/// DAC Field Name: RcptQtyMin 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Min. Receipt (%) 
		/// </summary>
		[DataMember(Name="MinReceiptPercent", EmitDefaultValue=false)]
		public DecimalValue? MinReceiptPercent { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Order Qty. 
		/// </summary>
		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Qty. On Orders 
		/// </summary>
		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: PONbr 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Blanket PO Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="OrigPONbr", EmitDefaultValue=false)]
		public StringValue? OrigPONbr { get; set; }

		/// <summary>
		/// DAC Field Name: POType 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Blanket PO Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrigPOType", EmitDefaultValue=false)]
		public StringValue? OrigPOType { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC Field Name: PromisedDate 
		/// DAC: PX.Objects.PO.POLine 
		/// </summary>
		[DataMember(Name="Promised", EmitDefaultValue=false)]
		public DateTimeValue? Promised { get; set; }

		/// <summary>
		/// DAC Field Name: ReceivedQty 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Qty. On Receipts 
		/// </summary>
		[DataMember(Name="QtyOnReceipts", EmitDefaultValue=false)]
		public DecimalValue? QtyOnReceipts { get; set; }

		/// <summary>
		/// DAC Field Name: RcptQtyAction 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Receipt Action 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ReceiptAction", EmitDefaultValue=false)]
		public StringValue? ReceiptAction { get; set; }

		[DataMember(Name="ReceivedAmount", EmitDefaultValue=false)]
		public DecimalValue? ReceivedAmount { get; set; }

		/// <summary>
		/// DAC Field Name: RequestedDate 
		/// DAC: PX.Objects.PO.POLine 
		/// </summary>
		[DataMember(Name="Requested", EmitDefaultValue=false)]
		public DateTimeValue? Requested { get; set; }

		/// <summary>
		/// DAC Field Name: ExpenseSubID 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Sub. 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.PO.POLine 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// DAC Field Name: CuryUnitCost 
		/// DAC: PX.Objects.PO.POLine 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POLine 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Warehouse 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

	}
}