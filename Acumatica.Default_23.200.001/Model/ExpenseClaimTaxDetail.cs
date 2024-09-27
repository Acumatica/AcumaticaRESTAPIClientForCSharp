using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class ExpenseClaimTaxDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: NonDeductibleTaxRate 
		/// DAC: PX.Objects.EP.EPTaxTran 
		/// Display Name: Deductible Tax Rate 
		/// </summary>
		[DataMember(Name="DeductibleTaxRate", EmitDefaultValue=false)]
		public DecimalValue? DeductibleTaxRate { get; set; }

		/// <summary>
		/// DAC Field Name: CuryExpenseAmt 
		/// DAC: PX.Objects.EP.EPTaxTran 
		/// Display Name: Expense Amount 
		/// </summary>
		[DataMember(Name="ExpenseAmount", EmitDefaultValue=false)]
		public DecimalValue? ExpenseAmount { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__ExemptTax 
		/// DAC: PX.Objects.EP.EPTaxTran 
		/// </summary>
		[DataMember(Name="IncludeinVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeinVATExemptTotal { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__PendingTax 
		/// DAC: PX.Objects.EP.EPTaxTran 
		/// </summary>
		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue? PendingVAT { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__ReverseTax 
		/// DAC: PX.Objects.EP.EPTaxTran 
		/// </summary>
		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__StatisticalTax 
		/// DAC: PX.Objects.EP.EPTaxTran 
		/// </summary>
		[DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxableAmt 
		/// DAC: PX.Objects.EP.EPTaxTran 
		/// Display Name: Taxable Amount 
		/// </summary>
		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxAmt 
		/// DAC: PX.Objects.EP.EPTaxTran 
		/// Display Name: Tax Amount 
		/// </summary>
		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.EP.EPTaxTran 
		/// Display Name: Tax ID 
		/// SQL Type: nvarchar(60) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// The tax rate of the relevant Tax record.
		/// DAC: PX.Objects.EP.EPTaxTran 
		/// Display Name: Tax Rate 
		/// </summary>
		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__TaxType 
		/// DAC: PX.Objects.EP.EPTaxTran 
		/// </summary>
		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue? TaxType { get; set; }

	}
}