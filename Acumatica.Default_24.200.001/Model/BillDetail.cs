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
	public class BillDetail : Entity
	{

		/// <summary>
		/// Identifier of the expense account to be updated by the transaction.
		/// DAC Field Name: AccountID 
		/// DAC: PX.Objects.AP.APTran 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// The total amount for the specified quantity of items or services of this type (after discount has been taken),or the amount of debit adjustment or prepayment.(Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryTranAmt 
		/// DAC: PX.Objects.AP.APTran 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// Identifier of the Branch, to which the document belongs.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AP.APInvoice 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
		public BooleanValue? CalculateDiscountsOnImport { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// DAC Field Name: AccountID_Account_description 
		/// DAC: PX.Objects.AP.APTran 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The extended cost of the item or service associated with the line, which is the unit price multiplied by the quantity.(Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryLineAmt 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: Ext. Cost 
		/// </summary>
		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? ExtendedCost { get; set; }

		/// <summary>
		/// Identifier of the inventory item associated with the transaction.
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The line number of the corresponding Landed Cost Document Detail.Together with LCDocType and LCRefNbr links AP transactions to the Landed Cost Document and their lines.
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: LC Line 
		/// </summary>
		[DataMember(Name="LCLineNbr", EmitDefaultValue=false)]
		public IntValue? LCLineNbr { get; set; }

		/// <summary>
		/// The reference number of the corresponding Landed Cost Document.Together with LCDocType and LCLineNbr links APTrans to the PO Orders and their lines.
		/// DAC Field Name: LCRefNbr 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: LC Number 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="LCNbr", EmitDefaultValue=false)]
		public StringValue? LCNbr { get; set; }

		/// <summary>
		/// The type of the corresponding Landed Cost Document.Together with LCRefNbr and LCLineNbr links APTrans to the PO Orders and their lines.
		/// DAC Field Name: LCDocType 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: LC Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="LCType", EmitDefaultValue=false)]
		public StringValue? LCType { get; set; }

		/// <summary>
		/// When set to true indicates that the document line is not billable in the project.The field is relevant only in case Project module is enabled.
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: Non Billable 
		/// </summary>
		[DataMember(Name="NonBillable", EmitDefaultValue=false)]
		public BooleanValue? NonBillable { get; set; }

		/// <summary>
		/// The line number of the corresponding PO Line.Together with POOrderType and PONbr links AP transactions to the PO Orders and their lines.
		/// DAC Field Name: POLineNbr 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: PO Line 
		/// </summary>
		[DataMember(Name="POLine", EmitDefaultValue=false)]
		public IntValue? POLine { get; set; }

		/// <summary>
		/// The reference number of the corresponding PO Order.Together with POOrderType and POLineNbr links APTrans to the PO Orders and their lines.
		/// DAC Field Name: PONbr 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: PO Number 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// The type of the corresponding PO Order.Together with PONbr and POLineNbr links APTrans to the PO Orders and their lines.
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: PO Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="POOrderType", EmitDefaultValue=false)]
		public StringValue? POOrderType { get; set; }

		/// <summary>
		/// The number of the corresponding line in the related PO Receipt.Together with ReceiptNbr field links AP transactions to PO Receipts and their lines.
		/// DAC Field Name: ReceiptLineNbr 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: PO Receipt Line 
		/// </summary>
		[DataMember(Name="POReceiptLine", EmitDefaultValue=false)]
		public IntValue? POReceiptLine { get; set; }

		/// <summary>
		/// DAC Field Name: ReceiptType 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: PO Receipt Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="POReceiptType", EmitDefaultValue=false)]
		public StringValue? POReceiptType { get; set; }

		/// <summary>
		/// The reference number of the corresponding PO Receipt.Together with ReceiptLineNbr field links AP transactions to PO Receipts and their lines.
		/// DAC Field Name: ReceiptNbr 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: PO Receipt Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="POReceiptNbr", EmitDefaultValue=false)]
		public StringValue? POReceiptNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.AP.APInvoice 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// Identifier of the particular task associated with the transaction. The task belongs to the selected project
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// The quantity of the items or services associated with the line delivered by the vendor.
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: Quantity 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// Identifier of the Subaccount associated with the transaction.
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.AP.APTran 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// Identifier of the tax category associated with the line.
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The description text for the transaction.
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: Transaction Descr. 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// The unit cost of the item or service received from the vendor and associated with the line.(Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryUnitCost 
		/// DAC: PX.Objects.AP.APTran 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// The unit of measure for the transaction.
		/// DAC: PX.Objects.AP.APTran 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}