using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ExpenseReceiptTaxDetails : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: NonDeductibleTaxRate</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Deductible Tax Rate</para>
		/// </summary>
		public DecimalValue? DeductibleTaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExpenseAmt</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Expense Amount</para>
		/// </summary>
		public DecimalValue? ExpenseAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__ExemptTax</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		public BooleanValue? IncludeInVATExemptTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__PendingTax</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		public BooleanValue? PendingVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__ReverseTax</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__StatisticalTax</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxableAmt</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Taxable Amount</para>
		/// </summary>
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxAmt</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Tax Amount</para>
		/// </summary>
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// The tax rate of the relevant Tax record.
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Tax Rate</para>
		/// </summary>
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__TaxType</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		public StringValue? TaxType { get; set; }

	}
}