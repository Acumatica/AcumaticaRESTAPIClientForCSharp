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
	public class DeductionBenefitWCCCode : Entity
	{

		/// <summary>
		/// The state or province to which the deduction or benefit corresponds.The field is included in State.
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		[DataMember(Name="WCCCodeRates", EmitDefaultValue=false)]
		public List<WCCCodeRateDetail>? WCCCodeRates { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string WCCCodeRates = "WCCCodeRates";

			//Intentionally excluded
			//public const string All = "WCCCodeRates";
		}
	}
}