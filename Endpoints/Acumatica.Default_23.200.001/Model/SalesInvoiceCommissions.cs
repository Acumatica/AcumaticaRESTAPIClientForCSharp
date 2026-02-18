using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class SalesInvoiceCommissions : Entity
	{

		/// <summary>
		/// The commission amount calculated on this document for the salesperson.Given in the currency of the document.
		/// <para>DAC Field Name: CuryCommnAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Commission Amt.</para>
		/// </summary>
		public DecimalValue? CommissionAmount { get; set; }

		public List<SalesInvoiceSalesPersonDetail>? SalesPersons { get; set; }

		/// <summary>
		/// The amount used as the base to calculate commission for this document.Given in the currency of the document.
		/// <para>DAC Field Name: CuryCommnblAmt</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Total Commissionable</para>
		/// </summary>
		public DecimalValue? TotalCommissionableAmount { get; set; }

	}
}