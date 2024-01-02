using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class WCCCodeMaxInsurableWageDetail : Entity
	{

		[DataMember(Name="DeductionandBenefitCode", EmitDefaultValue=false)]
		public StringValue? DeductionandBenefitCode { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		[DataMember(Name="Wage", EmitDefaultValue=false)]
		public DecimalValue? Wage { get; set; }

	}
}