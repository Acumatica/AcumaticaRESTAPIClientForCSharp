using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ExpenseClaimTaxDetail : Entity
	{

		#region Fields
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
		/// <para>DAC Field Name: Tax__TaxType</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		public StringValue? TaxType { get; set; }

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
		/// <para>DAC Field Name: Tax__ExemptTax</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		public BooleanValue? IncludeinVATExemptTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__StatisticalTax</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		public BooleanValue? StatisticalVAT { get; set; }

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