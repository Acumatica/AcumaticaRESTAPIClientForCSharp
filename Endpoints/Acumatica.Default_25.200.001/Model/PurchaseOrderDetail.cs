using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class PurchaseOrderDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Alternate ID</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="AlternateID", EmitDefaultValue=false)]
		public StringValue? AlternateID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Branch</para>
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		[DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
		public BooleanValue? CalculateDiscountsOnImport { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		[DataMember(Name="Cancelled", EmitDefaultValue=false)]
		public BooleanValue? Cancelled { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public BooleanValue? Completed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RcptQtyThreshold</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Complete On (%)</para>
		/// </summary>
		[DataMember(Name="CompleteOn", EmitDefaultValue=false)]
		public DecimalValue? CompleteOn { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpenseAcctID_Account_description</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryLineAmt</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Ext. Cost</para>
		/// </summary>
		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? ExtendedCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Line Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Line Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue? LineType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RcptQtyMax</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Max. Receipt (%)</para>
		/// </summary>
		[DataMember(Name="MaxReceiptPercent", EmitDefaultValue=false)]
		public DecimalValue? MaxReceiptPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RcptQtyMin</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Min. Receipt (%)</para>
		/// </summary>
		[DataMember(Name="MinReceiptPercent", EmitDefaultValue=false)]
		public DecimalValue? MinReceiptPercent { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Order Qty.</para>
		/// </summary>
		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Qty. On Orders</para>
		/// </summary>
		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PONbr</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Blanket PO Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="OrigPONbr", EmitDefaultValue=false)]
		public StringValue? OrigPONbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POType</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Blanket PO Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="OrigPOType", EmitDefaultValue=false)]
		public StringValue? OrigPOType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PromisedDate</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		[DataMember(Name="Promised", EmitDefaultValue=false)]
		public DateTimeValue? Promised { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReceivedQty</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Qty. On Receipts</para>
		/// </summary>
		[DataMember(Name="QtyOnReceipts", EmitDefaultValue=false)]
		public DecimalValue? QtyOnReceipts { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RcptQtyAction</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Receipt Action</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="ReceiptAction", EmitDefaultValue=false)]
		public StringValue? ReceiptAction { get; set; }

		[DataMember(Name="ReceivedAmount", EmitDefaultValue=false)]
		public DecimalValue? ReceivedAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RequestedDate</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		[DataMember(Name="Requested", EmitDefaultValue=false)]
		public DateTimeValue? Requested { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpenseSubID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Sub.</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnitCost</para>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POLine</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

	}
}