using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class WCCCodeRateDetail : Entity
	{

		#region Fields
		public GuidValue? Active { get; set; }

		public DecimalValue? BenefitRate { get; set; }

		public StringValue? Branch { get; set; }

		public DecimalValue? DeductionRate { get; set; }

		public StringValue? Description { get; set; }

		public DateTimeValue? EffectiveDate { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? WCCCode { get; set; }

		#endregion

		#region Details
		public List<WCCCodeMaxInsurableWageDetail>? WCCCodeMaxInsurableWages { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string WCCCodeMaxInsurableWages = "WCCCodeMaxInsurableWages";

			//Intentionally excluded
			//public const string All = "Files,WCCCodeMaxInsurableWages";
		}
	}
}