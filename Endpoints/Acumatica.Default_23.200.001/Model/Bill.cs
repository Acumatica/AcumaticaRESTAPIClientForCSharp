using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AP301000</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr, Type</para>
	/// </summary>
	public class Bill : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The amount to be paid for the document in the currency of the document. (See CuryID)
		/// <para>DAC Field Name: CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		public List<BillApplicationDetail>? Applications { get; set; }

		/// <summary>
		/// When set to true indicates that the document is approved for payment.
		/// <para>DAC Field Name: PaySel</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Approved for Payment</para>
		/// </summary>
		public BooleanValue? ApprovedForPayment { get; set; }

		/// <summary>
		/// The balance of the Accounts Payable document after tax (if inclusive) and the discount in the currency of the document. (See CuryID)
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// </summary>
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// Identifier of the Branch, to which the document belongs.
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Branch</para>
		/// </summary>
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// The cash account used for the payment.
		/// <para>DAC Field Name: PayAccountID</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// Code of the Currency of the document.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// Date of the document.
		/// <para>DAC Field Name: DocDate</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// Description of the document.
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<BillDetail>? Details { get; set; }

		/// <summary>
		/// The date when payment for the document is due in accordance with the credit terms.
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Due Date</para>
		/// </summary>
		public DateTimeValue? DueDate { get; set; }

		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// Financial Period of the document.
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// Reference number of the document.
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// The status of the document. The field is calculatedbased on the values of the status flag. It can't be changed directly.The following fields determine the status of the document: Hold,Released, Voided, Scheduled,Prebooked, Printed, Approved, Rejected.
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public List<BillTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The total amount of taxes associated with the document. (Presented in the currency of the document, see CuryID)
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Tax Total</para>
		/// </summary>
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// The credit terms associated with the document (unavailable for prepayments and debit adjustments).\Defaults to the credit terms of the vendor.
		/// <para>DAC Field Name: TermsID</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Terms { get; set; }

		/// <summary>
		/// Type of the document.
		/// <para>DAC Field Name: DocType</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// Identifier of the Vendor, whom the document belongs to.
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The document’s original reference number as assigned by the vendor (for informational purposes).The reference to the vendor document is required if RequireVendorRef is set to true.The reference should also be unique if RaiseErrorOnDoubleInvoiceNbr is set to true.
		/// <para>DAC Field Name: InvoiceNbr</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Vendor Ref.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? VendorRef { get; set; }

		public BooleanValue? IsTaxValid { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Applications = "Applications";
			public const string Applications_Files = "Applications/Files";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Applications,Applications/Files,Details,Details/Files,TaxDetails,TaxDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}