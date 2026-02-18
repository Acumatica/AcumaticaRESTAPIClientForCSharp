using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class BillTaxDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryTaxableAmt</para>
		/// <para>DAC: PX.Objects.AP.APTaxTran</para>
		/// <para>Display Name: Taxable Amount</para>
		/// </summary>
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxAmt</para>
		/// <para>DAC: PX.Objects.AP.APInvoice</para>
		/// <para>Display Name: Tax Amount</para>
		/// </summary>
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APTaxTran</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// The tax rate of the relevant Tax record.
		/// <para>DAC: PX.Objects.AP.APTaxTran</para>
		/// <para>Display Name: Tax Rate</para>
		/// </summary>
		public DecimalValue? TaxRate { get; set; }

	}
}