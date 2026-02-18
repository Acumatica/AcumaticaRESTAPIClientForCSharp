using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class InvoiceApplicationsDefault : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryAdjdAmt</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust2</para>
		/// <para>Display Name: Amount Paid</para>
		/// </summary>
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// The open balance of the document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// The cash discount amount displayed for the document.Given in the  currency of the adjusted document.
		/// <para>DAC Field Name: CuryAdjdPPDAmt</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust2</para>
		/// <para>Display Name: Cash Discount Taken</para>
		/// </summary>
		public DecimalValue? CashDiscountTaken { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjgDocType</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust2</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARPayment__DocDate</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust2</para>
		/// </summary>
		public DateTimeValue? PaymentDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjgRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust2</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARPayment__Status</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust2</para>
		/// </summary>
		public StringValue? Status { get; set; }

	}
}