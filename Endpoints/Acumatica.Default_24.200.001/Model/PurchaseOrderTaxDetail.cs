using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class PurchaseOrderTaxDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryRetainedTaxableAmt</para>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Retained Taxable</para>
		/// </summary>
		public DecimalValue? RetainedTaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryRetainedTaxAmt</para>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Retained Tax</para>
		/// </summary>
		public DecimalValue? RetainedTaxAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxableAmt</para>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Taxable Amount</para>
		/// </summary>
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxAmt</para>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Tax Amount</para>
		/// </summary>
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POTaxTran</para>
		/// <para>Display Name: Tax Rate</para>
		/// </summary>
		public DecimalValue? TaxRate { get; set; }

	}
}