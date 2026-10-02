using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ProjectProFormaDetails : Entity
	{

		#region Fields
		/// <summary>
		/// The sequence number of the invoice that is being assigned to the invoices of the project in order of the creation of the invoices.
		/// <para>DAC Field Name: RecordNumber</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// <para>Display Name: Billing Number</para>
		/// </summary>
		public IntValue? BillingNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMProforma__InvoiceDate</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public DateTimeValue? ProFormaDate { get; set; }

		/// <summary>
		/// The reference number of the parent pro forma invoice.
		/// <para>DAC Field Name: ProformaRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// <para>Display Name: Pro Forma Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ProFormaReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMProforma__Description</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMProforma__Status</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMProforma__CuryDocTotal</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public DecimalValue? InvoiceTotal { get; set; }

		/// <summary>
		/// The type of the AR document that is created during the billing.
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// <para>Display Name: AR Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringSingleSelectValue? ARDocType { get; set; }

		/// <summary>
		/// The reference number of the AR document that is created during the billing.
		/// <para>DAC Field Name: ARRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// <para>Display Name: AR Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ARReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__DocDate</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public DateTimeValue? ARDocDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__DocDesc</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public StringValue? ARDocDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public DecimalValue? ARDocOriginalAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__CuryRetainageTotal</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public DecimalValue? OriginalRetainage { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__CuryOrigDocAmtWithRetainageTotal</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public DecimalValue? TotalAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__CuryDocBal</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public DecimalValue? OpenARBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__Status</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public StringSingleSelectValue? ARDocStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__CuryRetainageUnreleasedAmt</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public DecimalValue? UnreleasedRetainage { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__IsRetainageDocument</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public BooleanValue? RetainageInvoice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__OrigRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMBillingRecord</para>
		/// </summary>
		public StringValue? OriginalRefNbr { get; set; }

		public DecimalValue? PaidRetainage { get; set; }

		public DecimalValue? UnpaidRetainage { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}