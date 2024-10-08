using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AP301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Bill : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The amount to be paid for the document in the currency of the document. (See CuryID)
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.AP.APInvoice 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="Applications", EmitDefaultValue=false)]
		public List<BillApplicationDetail>? Applications { get; set; }

		/// <summary>
		/// When set to true indicates that the document is approved for payment.
		/// DAC Field Name: PaySel 
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Approved for Payment 
		/// </summary>
		[DataMember(Name="ApprovedForPayment", EmitDefaultValue=false)]
		public BooleanValue? ApprovedForPayment { get; set; }

		/// <summary>
		/// The balance of the Accounts Payable document after tax (if inclusive) and the discount in the currency of the document. (See CuryID)
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.AP.APInvoice 
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// Identifier of the Branch, to which the document belongs.
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Branch 
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// The cash account used for the payment.
		/// DAC Field Name: PayAccountID 
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// Code of the Currency of the document.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// Date of the document.
		/// DAC Field Name: DocDate 
		/// DAC: PX.Objects.AP.APInvoice 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// Description of the document.
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.AP.APInvoice 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<BillDetail>? Details { get; set; }

		/// <summary>
		/// The date when payment for the document is due in accordance with the credit terms.
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Due Date 
		/// </summary>
		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// Financial Period of the document.
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Post Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.AP.APInvoice 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// Reference number of the document.
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// The status of the document. The field is calculatedbased on the values of the status flag. It can't be changed directly.The following fields determine the status of the document: Hold,Released, Voided, Scheduled,Prebooked, Printed, Approved, Rejected.
		/// DAC: PX.Objects.AP.APInvoice 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<BillTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The total amount of taxes associated with the document. (Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// The credit terms associated with the document (unavailable for prepayments and debit adjustments).\Defaults to the credit terms of the vendor.
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.AP.APInvoice 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// Type of the document.
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AP.APInvoice 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// Identifier of the Vendor, whom the document belongs to.
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AP.APInvoice 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The document’s original reference number as assigned by the vendor (for informational purposes).The reference to the vendor document is required if RequireVendorRef is set to true.The reference should also be unique if RaiseErrorOnDoubleInvoiceNbr is set to true.
		/// DAC Field Name: InvoiceNbr 
		/// DAC: PX.Objects.AP.APInvoice 
		/// Display Name: Vendor Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="VendorRef", EmitDefaultValue=false)]
		public StringValue? VendorRef { get; set; }

		[DataMember(Name="IsTaxValid", EmitDefaultValue=false)]
		public BooleanValue? IsTaxValid { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}