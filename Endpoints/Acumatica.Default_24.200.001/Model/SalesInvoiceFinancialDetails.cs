using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class SalesInvoiceFinancialDetails : Entity
	{

		/// <summary>
		/// The number of the Batch created from the document on release.
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Batch Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// The identifier of the branch to which the document belongs.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the TaxZone associated with the document.
		/// <para>DAC Field Name: TaxZoneID</para>
		/// <para>DAC: PX.Objects.AR.ARInvoice</para>
		/// <para>Display Name: Customer Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? CustomerTaxZone { get; set; }

	}
}