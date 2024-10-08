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
	public class TaxSettingsCA : Entity
	{

		/// <summary>
		/// The benefit type that is used for reporting and calculation purposes in Canada.
		/// DAC Field Name: BenefitTypeCDCAN 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Code Type 
		/// </summary>
		[DataMember(Name="CodeType", EmitDefaultValue=false)]
		public StringValue? CodeType { get; set; }

		[DataMember(Name="TaxDetailsCA", EmitDefaultValue=false)]
		public List<DeductionOrBenefitTaxDetailCA>? TaxDetailsCA { get; set; }

	}
}