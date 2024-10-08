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
	public class DeductionBenefitWCCCode : Entity
	{

		/// <summary>
		/// The state or province to which the deduction or benefit corresponds.The field is included in State.
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		[DataMember(Name="WCCCodeRates", EmitDefaultValue=false)]
		public List<WCCCodeRateDetail>? WCCCodeRates { get; set; }

	}
}