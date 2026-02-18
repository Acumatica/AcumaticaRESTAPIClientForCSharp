using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class OpportunityTaxDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Tax__ExemptTax</para>
		/// <para>DAC: PX.Objects.CR.CRTaxTran</para>
		/// </summary>
		public BooleanValue? IncludeInVATExemptTotal { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__PendingTax</para>
		/// <para>DAC: PX.Objects.CR.CRTaxTran</para>
		/// </summary>
		public BooleanValue? PendingVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__ReverseTax</para>
		/// <para>DAC: PX.Objects.CR.CRTaxTran</para>
		/// </summary>
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__StatisticalTax</para>
		/// <para>DAC: PX.Objects.CR.CRTaxTran</para>
		/// </summary>
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxableAmt</para>
		/// <para>DAC: PX.Objects.CR.CRTaxTran</para>
		/// <para>Display Name: Taxable Amount</para>
		/// </summary>
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxAmt</para>
		/// <para>DAC: PX.Objects.CR.CRTaxTran</para>
		/// <para>Display Name: Tax Amount</para>
		/// </summary>
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRTaxTran</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRTaxTran</para>
		/// </summary>
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__TaxType</para>
		/// <para>DAC: PX.Objects.CR.CRTaxTran</para>
		/// </summary>
		public StringValue? TaxType { get; set; }

	}
}