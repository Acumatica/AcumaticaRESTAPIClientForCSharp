using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class PTOBankBandingRule : Entity
	{

		public List<PTOBankBandingRuleDetail>? BandingRuleDetails { get; set; }

		/// <summary>
		/// The rounding method for Years of Service.
		/// <para>DAC Field Name: BandingRuleRoundingMethod</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Rounding Method for Years of Service</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? RoundingMethodforYearsofService { get; set; }

	}
}