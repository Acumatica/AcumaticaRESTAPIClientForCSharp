using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class TaxSettingsUS : Entity
	{

		/// <summary>
		/// A boolean value that specifies (if set to true) that supplemental earnings are included in the calculation of this deduction and benefit code.
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Include Supplemental Earnings 
		/// </summary>
		[DataMember(Name="AllowSupplementalElection", EmitDefaultValue=false)]
		public BooleanValue? AllowSupplementalElection { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the benefit type that is used for reporting and calculation purposes.
		/// DAC Field Name: BenefitTypeCD 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Code Type 
		/// </summary>
		[DataMember(Name="CodeType", EmitDefaultValue=false)]
		public StringValue? CodeType { get; set; }

		/// <summary>
		/// The method to be used to determine the list of applicable taxes.
		/// DAC Field Name: IncludeType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Impact on Taxable Wage 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="ImpactonTaxableWage", EmitDefaultValue=false)]
		public StringValue? ImpactonTaxableWage { get; set; }

		[DataMember(Name="TaxDetailsUS", EmitDefaultValue=false)]
		public List<DeductionOrBenefitTaxDetailUS>? TaxDetailsUS { get; set; }

	}
}