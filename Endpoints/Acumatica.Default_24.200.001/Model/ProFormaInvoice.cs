using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM307000</c> in the Acumatica ERP
	/// <para>Key Fields: RefNbr</para>
	/// </summary>
	[DataContract]
	public class ProFormaInvoice : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The amount due.
		/// <para>DAC Field Name: CuryAmountDue</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Amount Due</para>
		/// </summary>
		[DataMember(Name="AmountDue", EmitDefaultValue=false)]
		public DecimalValue? AmountDue { get; set; }

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval>? ApprovalDetails { get; set; }

		[DataMember(Name="BillingSettings", EmitDefaultValue=false)]
		public BillToSettings? BillingSettings { get; set; }

		/// <summary>
		/// The identifier of the pro forma invoice currency.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The identifier of the Customer associated with the pro forma invoice.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Customer</para>
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The description of the pro forma invoice, which is provided by the billing ruleand can be manually modified.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public ProFormaFinancialDetails? FinancialDetails { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the document is on hold.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// The date on which the pro forma invoice was created.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Invoice Date</para>
		/// </summary>
		[DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
		public DateTimeValue? InvoiceDate { get; set; }

		/// <summary>
		/// The invoice total.
		/// <para>DAC Field Name: CuryDocTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		[DataMember(Name="InvoiceTotal", EmitDefaultValue=false)]
		public DecimalValue? InvoiceTotal { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the Location associated with the pro forma invoice.
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// The financial period that corresponds to the invoice date.
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Post Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="ProgressBilling", EmitDefaultValue=false)]
		public List<ProgressBilling>? ProgressBilling { get; set; }

		/// <summary>
		/// The total amount to invoice of the progress billing lines of the document.
		/// <para>DAC Field Name: CuryProgressiveTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Progress Billing Total</para>
		/// </summary>
		[DataMember(Name="ProgressBillingTotal", EmitDefaultValue=false)]
		public DecimalValue? ProgressBillingTotal { get; set; }

		/// <summary>
		/// The identifier of the project associated with the pro forma invoice.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Project</para>
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The reference number of the pro forma invoice.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		/// <summary>
		/// The total retained amount.
		/// <para>DAC Field Name: CuryRetainageTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Retainage Total</para>
		/// </summary>
		[DataMember(Name="RetainageTotal", EmitDefaultValue=false)]
		public DecimalValue? RetainageTotal { get; set; }

		/// <summary>
		/// The read-only status of the document.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<ProFormaTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The total tax amount of the document.
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProformaRevision</para>
		/// <para>Display Name: Tax Total</para>
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="TimeAndMaterial", EmitDefaultValue=false)]
		public List<TimeAndMaterial>? TimeAndMaterial { get; set; }

		/// <summary>
		/// The total amount to invoice of the time and material lines of the document.
		/// <para>DAC Field Name: CuryTransactionalTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Time and Material Total</para>
		/// </summary>
		[DataMember(Name="TimeAndMaterialTotal", EmitDefaultValue=false)]
		public DecimalValue? TimeAndMaterialTotal { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
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
			//public const string All = "Files,ApprovalDetails,ApprovalDetails/Files,BillingSettings,BillingSettings/BillToAddress,BillingSettings/BillToContact,FinancialDetails,ProgressBilling,ProgressBilling/Files,TaxDetails,TaxDetails/Files,TimeAndMaterial,TimeAndMaterial/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}