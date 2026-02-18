using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class TaxSettingsUS : Entity
	{

		/// <summary>
		/// A boolean value that specifies (if set to true) that supplemental earnings are included in the calculation of this deduction and benefit code.
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Include Supplemental Earnings</para>
		/// </summary>
		public BooleanValue? AllowSupplementalElection { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the benefit type that is used for reporting and calculation purposes.
		/// <para>DAC Field Name: BenefitTypeCD</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Code Type</para>
		/// </summary>
		public StringValue? CodeType { get; set; }

		/// <summary>
		/// The method to be used to determine the list of applicable taxes.
		/// <para>DAC Field Name: IncludeType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Impact on Taxable Wage</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? ImpactonTaxableWage { get; set; }

		public List<DeductionOrBenefitTaxDetailUS>? TaxDetailsUS { get; set; }

	}
}