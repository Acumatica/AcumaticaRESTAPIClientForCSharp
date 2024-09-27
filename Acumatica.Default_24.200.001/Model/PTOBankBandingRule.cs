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
	public class PTOBankBandingRule : Entity
	{

		[DataMember(Name="BandingRuleDetails", EmitDefaultValue=false)]
		public List<PTOBankBandingRuleDetail>? BandingRuleDetails { get; set; }

		/// <summary>
		/// The rounding method for Years of Service.
		/// DAC Field Name: BandingRuleRoundingMethod 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Rounding Method for Years of Service 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="RoundingMethodforYearsofService", EmitDefaultValue=false)]
		public StringValue? RoundingMethodforYearsofService { get; set; }

	}
}