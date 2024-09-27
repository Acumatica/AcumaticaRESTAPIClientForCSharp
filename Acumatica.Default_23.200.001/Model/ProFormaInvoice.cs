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
	/// Corresponds to the screen PM307000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProFormaInvoice : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The amount due.
		/// DAC Field Name: CuryAmountDue 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Amount Due 
		/// </summary>
		[DataMember(Name="AmountDue", EmitDefaultValue=false)]
		public DecimalValue? AmountDue { get; set; }

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval>? ApprovalDetails { get; set; }

		[DataMember(Name="BillingSettings", EmitDefaultValue=false)]
		public BillToSettings? BillingSettings { get; set; }

		/// <summary>
		/// The identifier of the pro forma invoice currency.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The identifier of the Customer associated with the pro forma invoice.
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Customer 
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The description of the pro forma invoice, which is provided by the billing ruleand can be manually modified.
		/// DAC: PX.Objects.PM.PMProforma 
		/// SQL Type: nvarchar(255) 
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
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// The date on which the pro forma invoice was created.
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Invoice Date 
		/// </summary>
		[DataMember(Name="InvoiceDate", EmitDefaultValue=false)]
		public DateTimeValue? InvoiceDate { get; set; }

		/// <summary>
		/// The invoice total.
		/// DAC Field Name: CuryDocTotal 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Invoice Total 
		/// </summary>
		[DataMember(Name="InvoiceTotal", EmitDefaultValue=false)]
		public DecimalValue? InvoiceTotal { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the Location associated with the pro forma invoice.
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// The financial period that corresponds to the invoice date.
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Post Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="ProgressBilling", EmitDefaultValue=false)]
		public List<ProgressBilling>? ProgressBilling { get; set; }

		/// <summary>
		/// The total amount to invoice of the progress billing lines of the document.
		/// DAC Field Name: CuryProgressiveTotal 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Progress Billing Total 
		/// </summary>
		[DataMember(Name="ProgressBillingTotal", EmitDefaultValue=false)]
		public DecimalValue? ProgressBillingTotal { get; set; }

		/// <summary>
		/// The identifier of the project associated with the pro forma invoice.
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Project 
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The reference number of the pro forma invoice.
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		/// <summary>
		/// The total retained amount.
		/// DAC Field Name: CuryRetainageTotal 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Retainage Total 
		/// </summary>
		[DataMember(Name="RetainageTotal", EmitDefaultValue=false)]
		public DecimalValue? RetainageTotal { get; set; }

		/// <summary>
		/// The read-only status of the document.
		/// DAC: PX.Objects.PM.PMProforma 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<ProFormaTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The total tax amount of the document.
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.PM.PMProformaRevision 
		/// Display Name: Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="TimeAndMaterial", EmitDefaultValue=false)]
		public List<TimeAndMaterial>? TimeAndMaterial { get; set; }

		/// <summary>
		/// The total amount to invoice of the time and material lines of the document.
		/// DAC Field Name: CuryTransactionalTotal 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Time and Material Total 
		/// </summary>
		[DataMember(Name="TimeAndMaterialTotal", EmitDefaultValue=false)]
		public DecimalValue? TimeAndMaterialTotal { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}