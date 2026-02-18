using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class SrvOrdTaxDetails : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Tax__ExemptTax</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// </summary>
		public BooleanValue? IncludeinVATExemptTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__PendingTax</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// </summary>
		public BooleanValue? PendingVAT { get; set; }

		public IntValue? RecordID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__ReverseTax</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// </summary>
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__StatisticalTax</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// </summary>
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxableAmt</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// <para>Display Name: Taxable Amount</para>
		/// </summary>
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxAmt</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// <para>Display Name: Tax Amount</para>
		/// </summary>
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// <para>Display Name: Tax Rate</para>
		/// </summary>
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__TaxType</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrderTaxTran</para>
		/// </summary>
		public StringValue? TaxType { get; set; }

	}
}