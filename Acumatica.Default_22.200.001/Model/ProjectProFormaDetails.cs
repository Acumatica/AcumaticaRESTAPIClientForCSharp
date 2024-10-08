using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ProjectProFormaDetails : Entity
	{

		/// <summary>
		/// DAC Field Name: ARInvoice__DocDate 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="ARDocDate", EmitDefaultValue=false)]
		public DateTimeValue? ARDocDate { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__DocDesc 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="ARDocDescription", EmitDefaultValue=false)]
		public StringValue? ARDocDescription { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__CuryOrigDocAmt 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="ARDocOriginalAmount", EmitDefaultValue=false)]
		public DecimalValue? ARDocOriginalAmount { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__Status 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="ARDocStatus", EmitDefaultValue=false)]
		public StringValue? ARDocStatus { get; set; }

		/// <summary>
		/// The type of the AR document that is created during the billing.
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// Display Name: AR Doc. Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="ARDocType", EmitDefaultValue=false)]
		public StringValue? ARDocType { get; set; }

		/// <summary>
		/// The reference number of the AR document that is created during the billing.
		/// DAC Field Name: ARRefNbr 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// Display Name: AR Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ARReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ARReferenceNbr { get; set; }

		/// <summary>
		/// The sequence number of the invoice that is being assigned to the invoices of the project in order of the creation of the invoices.
		/// DAC Field Name: RecordNumber 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// Display Name: Billing Number 
		/// </summary>
		[DataMember(Name="BillingNbr", EmitDefaultValue=false)]
		public IntValue? BillingNbr { get; set; }

		/// <summary>
		/// DAC Field Name: PMProforma__Description 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: PMProforma__CuryDocTotal 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="InvoiceTotal", EmitDefaultValue=false)]
		public DecimalValue? InvoiceTotal { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__CuryDocBal 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="OpenARBalance", EmitDefaultValue=false)]
		public DecimalValue? OpenARBalance { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__OrigRefNbr 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="OriginalRefNbr", EmitDefaultValue=false)]
		public StringValue? OriginalRefNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__CuryRetainageTotal 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="OriginalRetainage", EmitDefaultValue=false)]
		public DecimalValue? OriginalRetainage { get; set; }

		[DataMember(Name="PaidRetainage", EmitDefaultValue=false)]
		public DecimalValue? PaidRetainage { get; set; }

		/// <summary>
		/// DAC Field Name: PMProforma__InvoiceDate 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="ProFormaDate", EmitDefaultValue=false)]
		public DateTimeValue? ProFormaDate { get; set; }

		/// <summary>
		/// The reference number of the parent pro forma invoice.
		/// DAC Field Name: ProformaRefNbr 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// Display Name: Pro Forma Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ProFormaReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ProFormaReferenceNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__IsRetainageDocument 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="RetainageInvoice", EmitDefaultValue=false)]
		public BooleanValue? RetainageInvoice { get; set; }

		/// <summary>
		/// DAC Field Name: PMProforma__Status 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__CuryOrigDocAmtWithRetainageTotal 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="TotalAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalAmount { get; set; }

		[DataMember(Name="UnpaidRetainage", EmitDefaultValue=false)]
		public DecimalValue? UnpaidRetainage { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__CuryRetainageUnreleasedAmt 
		/// DAC: PX.Objects.PM.PMBillingRecord 
		/// </summary>
		[DataMember(Name="UnreleasedRetainage", EmitDefaultValue=false)]
		public DecimalValue? UnreleasedRetainage { get; set; }

	}
}