using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ProFormaFinancialDetails : Entity
	{

		/// <summary>
		/// The type of the corresponding accounts receivable document created on release of the pro forma invoice.
		/// <para>DAC Field Name: ARInvoiceDocType</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: AR Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? ARDocType { get; set; }

		/// <summary>
		/// The reference number of the corresponding accounts receivable document created on release of the pro forma invoice.
		/// <para>DAC Field Name: ARInvoiceRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: AR Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ARRefNbr { get; set; }

		/// <summary>
		/// The identifier of the Branch to which the pro forma invoice belongs.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The end date of the cash discount period, which the system calculates by using the credit terms.
		/// <para>DAC Field Name: DiscDate</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Cash Discount Date</para>
		/// </summary>
		public DateTimeValue? CashDiscountDate { get; set; }

		/// <summary>
		/// The identifier of the TaxZone associated with the document.
		/// <para>DAC Field Name: TaxZoneID</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Customer Tax Zone</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? CustomerTaxZone { get; set; }

		/// <summary>
		/// The customer entity type for reporting purposes. The field is used if the system is integrated with an external tax calculation system and the External Tax            Calculation Integration feature is enabled.
		/// <para>DAC Field Name: AvalaraCustomerUsageType</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Tax Exemption Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? CustomerUsageType { get; set; }

		/// <summary>
		/// The date when the payment for the document is due, in accordance with the credit terms.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Due Date</para>
		/// </summary>
		public DateTimeValue? DueDate { get; set; }

		/// <summary>
		/// The identifier of the credit terms object associated with the document.
		/// <para>DAC Field Name: TermsID</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Terms { get; set; }

	}
}