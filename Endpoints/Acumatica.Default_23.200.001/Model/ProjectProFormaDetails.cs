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
	public class ProjectProFormaDetails : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__DocDate</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="ARDocDate", EmitDefaultValue=false)]
		public DateTimeValue? ARDocDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__DocDesc</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="ARDocDescription", EmitDefaultValue=false)]
		public StringValue? ARDocDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="ARDocOriginalAmount", EmitDefaultValue=false)]
		public DecimalValue? ARDocOriginalAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__Status</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="ARDocStatus", EmitDefaultValue=false)]
		public StringValue? ARDocStatus { get; set; }

		/// <summary>
		/// The type of the AR document that is created during the billing.
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// <para>Display Name: AR Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="ARDocType", EmitDefaultValue=false)]
		public StringValue? ARDocType { get; set; }

		/// <summary>
		/// The reference number of the AR document that is created during the billing.
		/// <para>DAC Field Name: ARRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// <para>Display Name: AR Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ARReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ARReferenceNbr { get; set; }

		/// <summary>
		/// The sequence number of the invoice that is being assigned to the invoices of the project in order of the creation of the invoices.
		/// <para>DAC Field Name: RecordNumber</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// <para>Display Name: Billing Number</para>
		/// </summary>
		[DataMember(Name="BillingNbr", EmitDefaultValue=false)]
		public IntValue? BillingNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMProforma__Description</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMProforma__CuryDocTotal</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="InvoiceTotal", EmitDefaultValue=false)]
		public DecimalValue? InvoiceTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__CuryDocBal</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="OpenARBalance", EmitDefaultValue=false)]
		public DecimalValue? OpenARBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__OrigRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="OriginalRefNbr", EmitDefaultValue=false)]
		public StringValue? OriginalRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__CuryRetainageTotal</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="OriginalRetainage", EmitDefaultValue=false)]
		public DecimalValue? OriginalRetainage { get; set; }

		[DataMember(Name="PaidRetainage", EmitDefaultValue=false)]
		public DecimalValue? PaidRetainage { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMProforma__InvoiceDate</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="ProFormaDate", EmitDefaultValue=false)]
		public DateTimeValue? ProFormaDate { get; set; }

		/// <summary>
		/// The reference number of the parent pro forma invoice.
		/// <para>DAC Field Name: ProformaRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// <para>Display Name: Pro Forma Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ProFormaReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ProFormaReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__IsRetainageDocument</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="RetainageInvoice", EmitDefaultValue=false)]
		public BooleanValue? RetainageInvoice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMProforma__Status</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__CuryOrigDocAmtWithRetainageTotal</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="TotalAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalAmount { get; set; }

		[DataMember(Name="UnpaidRetainage", EmitDefaultValue=false)]
		public DecimalValue? UnpaidRetainage { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__CuryRetainageUnreleasedAmt</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		[DataMember(Name="UnreleasedRetainage", EmitDefaultValue=false)]
		public DecimalValue? UnreleasedRetainage { get; set; }

	}
}