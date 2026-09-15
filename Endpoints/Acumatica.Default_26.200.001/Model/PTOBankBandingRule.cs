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
	public class PTOBankBandingRule : Entity
	{

		[DataMember(Name="BandingRuleDetails", EmitDefaultValue=false)]
		public List<PTOBankBandingRuleDetail>? BandingRuleDetails { get; set; }

		/// <summary>
		/// The rounding method for Years of Service.
		/// <para>DAC Field Name: BandingRuleRoundingMethod</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Rounding Method for Years of Service</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="RoundingMethodforYearsofService", EmitDefaultValue=false)]
		public StringValue? RoundingMethodforYearsofService { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string BandingRuleDetails = "BandingRuleDetails";

			//Intentionally excluded
			//public const string All = "BandingRuleDetails";
		}
	}
}