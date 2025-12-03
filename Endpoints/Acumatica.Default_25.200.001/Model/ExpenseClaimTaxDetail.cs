using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class ExpenseClaimTaxDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: NonDeductibleTaxRate</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Deductible Tax Rate</para>
		/// </summary>
		[DataMember(Name="DeductibleTaxRate", EmitDefaultValue=false)]
		public DecimalValue? DeductibleTaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExpenseAmt</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Expense Amount</para>
		/// </summary>
		[DataMember(Name="ExpenseAmount", EmitDefaultValue=false)]
		public DecimalValue? ExpenseAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__ExemptTax</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		[DataMember(Name="IncludeinVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeinVATExemptTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__PendingTax</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue? PendingVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__ReverseTax</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__StatisticalTax</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		[DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxableAmt</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Taxable Amount</para>
		/// </summary>
		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxAmt</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Tax Amount</para>
		/// </summary>
		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// The tax rate of the relevant Tax record.
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// <para>Display Name: Tax Rate</para>
		/// </summary>
		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Tax__TaxType</para>
		/// <para>DAC: PX.Objects.EP.EPTaxTran</para>
		/// </summary>
		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue? TaxType { get; set; }

	}
}