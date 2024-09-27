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
	public class InvoiceDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: AccountID 
		/// DAC: PX.Objects.AR.ARTran 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTranAmt 
		/// DAC: PX.Objects.AR.ARTran 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The identifier of the branch to which the document belongs.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AR.ARInvoice 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

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
		/// DAC Field Name: CuryDiscAmt 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Discount Amount 
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryExtPrice 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Ext. Price 
		/// </summary>
		[DataMember(Name="ExtendedPrice", EmitDefaultValue=false)]
		public DecimalValue? ExtendedPrice { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

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
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.AR.ARTran 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AR.ARTran 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Transaction Descr. 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue? TransactionDescription { get; set; }

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
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.AR.ARTran 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

	}
}