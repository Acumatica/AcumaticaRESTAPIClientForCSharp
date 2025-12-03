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
	public class BillDetail : Entity
	{

		/// <summary>
		/// Identifier of the expense account to be updated by the transaction.
		/// <para>DAC Field Name: AccountID</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// The total amount for the specified quantity of items or services of this type (after discount has been taken),or the amount of debit adjustment or prepayment.(Presented in the currency of the document, see CuryID)
		/// <para>DAC Field Name: CuryTranAmt</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// Identifier of the Branch, to which the document belongs.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
		public BooleanValue? CalculateDiscountsOnImport { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AccountID_Account_description</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The extended cost of the item or service associated with the line, which is the unit price multiplied by the quantity.(Presented in the currency of the document, see CuryID)
		/// <para>DAC Field Name: CuryLineAmt</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: Ext. Cost</para>
		/// </summary>
		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? ExtendedCost { get; set; }

		/// <summary>
		/// Identifier of the inventory item associated with the transaction.
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// When set to true indicates that the document line is not billable in the project.The field is relevant only in case Project Accounting feature is enabled.
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: Non Billable</para>
		/// </summary>
		[DataMember(Name="NonBillable", EmitDefaultValue=false)]
		public BooleanValue? NonBillable { get; set; }

		/// <summary>
		/// The line number of the corresponding PO Line.Together with POOrderType and PONbr links AP transactions to the PO Orders and their lines.
		/// <para>DAC Field Name: POLineNbr</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: PO Line</para>
		/// </summary>
		[DataMember(Name="POLine", EmitDefaultValue=false)]
		public IntValue? POLine { get; set; }

		/// <summary>
		/// The reference number of the corresponding PO Order.Together with POOrderType and POLineNbr links APTrans to the PO Orders and their lines.
		/// <para>DAC Field Name: PONbr</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: PO Number</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// The type of the corresponding PO Order.Together with PONbr and POLineNbr links APTrans to the PO Orders and their lines.
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: PO Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="POOrderType", EmitDefaultValue=false)]
		public StringValue? POOrderType { get; set; }

		/// <summary>
		/// The number of the corresponding line in the related PO Receipt.Together with ReceiptNbr field links AP transactions to PO Receipts and their lines.
		/// <para>DAC Field Name: ReceiptLineNbr</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: PO Receipt Line</para>
		/// </summary>
		[DataMember(Name="POReceiptLine", EmitDefaultValue=false)]
		public IntValue? POReceiptLine { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReceiptType</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: PO Receipt Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="POReceiptType", EmitDefaultValue=false)]
		public StringValue? POReceiptType { get; set; }

		/// <summary>
		/// The reference number of the corresponding PO Receipt.Together with ReceiptLineNbr field links AP transactions to PO Receipts and their lines.
		/// <para>DAC Field Name: ReceiptNbr</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: PO Receipt Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="POReceiptNbr", EmitDefaultValue=false)]
		public StringValue? POReceiptNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// Identifier of the particular task associated with the transaction. The task belongs to the selected project
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// The quantity of the items or services associated with the line delivered by the vendor.
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// Identifier of the Subaccount associated with the transaction.
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// Identifier of the tax category associated with the line.
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The description text for the transaction.
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: Transaction Descr.</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// The unit cost of the item or service received from the vendor and associated with the line.(Presented in the currency of the document, see CuryID)
		/// <para>DAC Field Name: CuryUnitCost</para>
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// The unit of measure for the transaction.
		/// <para>DAC: PX.Objects.AP.APTran</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}