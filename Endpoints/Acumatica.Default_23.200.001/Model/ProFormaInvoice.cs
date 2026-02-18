using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM307000</c> in the Acumatica ERP
	/// <para>Key Fields: RefNbr</para>
	/// </summary>
	public class ProFormaInvoice : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The amount due.
		/// <para>DAC Field Name: CuryAmountDue</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Amount Due</para>
		/// </summary>
		public DecimalValue? AmountDue { get; set; }

		public List<Approval>? ApprovalDetails { get; set; }

		public BillToSettings? BillingSettings { get; set; }

		/// <summary>
		/// The identifier of the pro forma invoice currency.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The identifier of the Customer associated with the pro forma invoice.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Customer</para>
		/// </summary>
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The description of the pro forma invoice, which is provided by the billing ruleand can be manually modified.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? EffectiveDate { get; set; }

		public StringValue? ExternalRefNbr { get; set; }

		public ProFormaFinancialDetails? FinancialDetails { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the document is on hold.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// </summary>
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// The date on which the pro forma invoice was created.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Invoice Date</para>
		/// </summary>
		public DateTimeValue? InvoiceDate { get; set; }

		/// <summary>
		/// The invoice total.
		/// <para>DAC Field Name: CuryDocTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		public DecimalValue? InvoiceTotal { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the Location associated with the pro forma invoice.
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// The financial period that corresponds to the invoice date.
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		public StringValue? PostPeriod { get; set; }

		public List<ProgressBilling>? ProgressBilling { get; set; }

		/// <summary>
		/// The total amount to invoice of the progress billing lines of the document.
		/// <para>DAC Field Name: CuryProgressiveTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Progress Billing Total</para>
		/// </summary>
		public DecimalValue? ProgressBillingTotal { get; set; }

		/// <summary>
		/// The identifier of the project associated with the pro forma invoice.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Project</para>
		/// </summary>
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The reference number of the pro forma invoice.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? RefNbr { get; set; }

		/// <summary>
		/// The total retained amount.
		/// <para>DAC Field Name: CuryRetainageTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Retainage Total</para>
		/// </summary>
		public DecimalValue? RetainageTotal { get; set; }

		/// <summary>
		/// The read-only status of the document.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public List<ProFormaTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The total tax amount of the document.
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProformaRevision</para>
		/// <para>Display Name: Tax Total</para>
		/// </summary>
		public DecimalValue? TaxTotal { get; set; }

		public List<TimeAndMaterial>? TimeAndMaterial { get; set; }

		/// <summary>
		/// The total amount to invoice of the time and material lines of the document.
		/// <para>DAC Field Name: CuryTransactionalTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Time and Material Total</para>
		/// </summary>
		public DecimalValue? TimeAndMaterialTotal { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ApprovalDetails = "ApprovalDetails";
			public const string ApprovalDetails_Files = "ApprovalDetails/Files";
			public const string BillingSettings = "BillingSettings";
			public const string BillingSettings_BillToAddress = "BillingSettings/BillToAddress";
			public const string BillingSettings_BillToContact = "BillingSettings/BillToContact";
			public const string FinancialDetails = "FinancialDetails";
			public const string ProgressBilling = "ProgressBilling";
			public const string ProgressBilling_Files = "ProgressBilling/Files";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";
			public const string TimeAndMaterial = "TimeAndMaterial";
			public const string TimeAndMaterial_Files = "TimeAndMaterial/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,ApprovalDetails,ApprovalDetails/Files,BillingSettings,BillingSettings/BillToAddress,BillingSettings/BillToContact,FinancialDetails,ProgressBilling,ProgressBilling/Files,TaxDetails,TaxDetails/Files,TimeAndMaterial,TimeAndMaterial/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}