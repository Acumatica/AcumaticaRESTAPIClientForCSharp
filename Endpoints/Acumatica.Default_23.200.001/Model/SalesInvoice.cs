using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SO303000</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr, Type</para>
	/// </summary>
	public class SalesInvoice : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The amount of the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		public List<SalesInvoiceApplicationCreditMemo>? ApplicationsCreditMemo { get; set; }

		public List<SalesInvoiceApplicationInvoice>? ApplicationsInvoice { get; set; }

		/// <summary>
		/// The open balance of the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		public DecimalValue? Balance { get; set; }

		public BillToSettings? BillingSettings { get; set; }

		/// <summary>
		/// The cash discount entered for the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryOrigDiscAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Cash Discount</para>
		/// </summary>
		public DecimalValue? CashDiscount { get; set; }

		public SalesInvoiceCommissions? Commissions { get; set; }

		public BooleanValue? CreditHold { get; set; }

		/// <summary>
		/// The code of the Currency of the document.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? Currency { get; set; }

		/// <summary>
		/// The identifier of the Customer record associated with the document.
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Customer</para>
		/// </summary>
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The original reference number or ID assigned by the customer to the customer document.
		/// <para>DAC Field Name: InvoiceNbr</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Customer Order Nbr.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// The date of the document.
		/// <para>DAC Field Name: DocDate</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The description of the document.
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<SalesInvoiceDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryLineTotal</para>
		/// <para>DAC: PX.Objects.SO.SOFreightDetail</para>
		/// <para>Display Name: Line Total</para>
		/// </summary>
		public DecimalValue? DetailTotal { get; set; }

		public List<SalesInvoiceDiscountDetails>? DiscountDetails { get; set; }

		/// <summary>
		/// The group and document discount total for the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryDiscTot</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Group and Document Discount Total</para>
		/// </summary>
		public DecimalValue? DiscountTotal { get; set; }

		/// <summary>
		/// The due date of the document.
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Due Date</para>
		/// </summary>
		public DateTimeValue? DueDate { get; set; }

		public BooleanValue? IsTaxValid { get; set; }

		public SalesInvoiceFinancialDetails? FinancialDetails { get; set; }

		public List<SalesInvoiceFreightDetail>? FreightDetails { get; set; }

		/// <summary>
		/// The amount of freight associated with the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryFreightAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Freight Price</para>
		/// </summary>
		public DecimalValue? FreightPrice { get; set; }

		public BooleanValue? Hold { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryPaymentTotal</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Total Paid</para>
		/// </summary>
		public DecimalValue? PaymentTotal { get; set; }

		/// <summary>
		/// The identifier of the project associated with the documentor the non-project code, which indicates that the document is not related to any particular project.
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// The reference number of the document.This field is a part of the compound key of the document.
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public List<SalesInvoiceTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The total amount of tax associated with the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Tax Total</para>
		/// </summary>
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// The type of the document.This field is a part of the compound key of the document.
		/// <para>DAC Field Name: DocType</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// The portion of the document total that is exempt from VAT.Given in the currency of the document.This field is relevant only if the VAT Reporting feature is enabled.
		/// <para>DAC Field Name: CuryVatExemptTotal</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Tax Exempt Total</para>
		/// </summary>
		public DecimalValue? VATExemptTotal { get; set; }

		/// <summary>
		/// The portion of the document total that is subjected to VAT.Given in the currency of the document.This field is relevant only if the VAT Reporting feature is enabled.
		/// <para>DAC Field Name: CuryVatTaxableTotal</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Taxable Total</para>
		/// </summary>
		public DecimalValue? VATTaxableTotal { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ApplicationsCreditMemo = "ApplicationsCreditMemo";
			public const string ApplicationsCreditMemo_Files = "ApplicationsCreditMemo/Files";
			public const string ApplicationsInvoice = "ApplicationsInvoice";
			public const string ApplicationsInvoice_Files = "ApplicationsInvoice/Files";
			public const string BillingSettings = "BillingSettings";
			public const string BillingSettings_BillToAddress = "BillingSettings/BillToAddress";
			public const string BillingSettings_BillToContact = "BillingSettings/BillToContact";
			public const string Commissions = "Commissions";
			public const string Commissions_SalesPersons = "Commissions/SalesPersons";
			public const string Commissions_SalesPersons_Files = "Commissions/SalesPersons/Files";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string DiscountDetails = "DiscountDetails";
			public const string DiscountDetails_Files = "DiscountDetails/Files";
			public const string FinancialDetails = "FinancialDetails";
			public const string FreightDetails = "FreightDetails";
			public const string FreightDetails_Files = "FreightDetails/Files";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,ApplicationsCreditMemo,ApplicationsCreditMemo/Files,ApplicationsInvoice,ApplicationsInvoice/Files,BillingSettings,BillingSettings/BillToAddress,BillingSettings/BillToContact,Commissions,Commissions/SalesPersons,Commissions/SalesPersons/Files,Details,Details/Files,DiscountDetails,DiscountDetails/Files,FinancialDetails,FreightDetails,FreightDetails/Files,TaxDetails,TaxDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}