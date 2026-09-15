using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class TaxSettingsUS : Entity
	{

		/// <summary>
		/// A boolean value that specifies (if set to true) that supplemental earnings are included in the calculation of this deduction and benefit code.
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Include Supplemental Earnings</para>
		/// </summary>
		[DataMember(Name="AllowSupplementalElection", EmitDefaultValue=false)]
		public BooleanValue? AllowSupplementalElection { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the benefit type that is used for reporting and calculation purposes.
		/// <para>DAC Field Name: BenefitTypeCD</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Code Type</para>
		/// </summary>
		[DataMember(Name="CodeType", EmitDefaultValue=false)]
		public StringValue? CodeType { get; set; }

		/// <summary>
		/// The method to be used to determine the list of applicable taxes.
		/// <para>DAC Field Name: IncludeType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Impact on Taxable Wage</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="ImpactonTaxableWage", EmitDefaultValue=false)]
		public StringValue? ImpactonTaxableWage { get; set; }

		[DataMember(Name="TaxDetailsUS", EmitDefaultValue=false)]
		public List<DeductionOrBenefitTaxDetailUS>? TaxDetailsUS { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string TaxDetailsUS = "TaxDetailsUS";

			//Intentionally excluded
			//public const string All = "TaxDetailsUS";
		}
	}
}