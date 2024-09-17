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

		[DataMember(Name="AllowSupplementalElection", EmitDefaultValue=false)]
		public BooleanValue? AllowSupplementalElection { get; set; }

		[DataMember(Name="CodeType", EmitDefaultValue=false)]
		public StringValue? CodeType { get; set; }

		[DataMember(Name="ImpactonTaxableWage", EmitDefaultValue=false)]
		public StringValue? ImpactonTaxableWage { get; set; }

		[DataMember(Name="TaxDetailsUS", EmitDefaultValue=false)]
		public List<DeductionOrBenefitTaxDetailUS>? TaxDetailsUS { get; set; }

	}
}