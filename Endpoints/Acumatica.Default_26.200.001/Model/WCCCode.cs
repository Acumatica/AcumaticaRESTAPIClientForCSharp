using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class WCCCode : Entity
	{

		#region Fields
		/// <summary>
		/// The unique identifier of the workers' compensation code.
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// <para>Display Name: WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? wcccode { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the workers' compensation code is active and can be used.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The description of the workers' compensation code.
		/// <para>DAC: PX.Objects.PM.PMWorkCode</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region Details
		public List<WCCCodeCostCodeSource>? WCCCodeCostCodeSources { get; set; }

		public List<WCCCodeLaborItemSource>? WCCCodeLaborItemSources { get; set; }

		public List<WCCCodeMaxInsurableWage>? WCCCodeMaxInsurableWages { get; set; }

		public List<WCCCodeProjectSource>? WCCCodeProjectSources { get; set; }

		public List<WCCCodeRate>? WCCCodeRates { get; set; }

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
			public const string WCCCodeCostCodeSources = "WCCCodeCostCodeSources";
			public const string WCCCodeLaborItemSources = "WCCCodeLaborItemSources";
			public const string WCCCodeMaxInsurableWages = "WCCCodeMaxInsurableWages";
			public const string WCCCodeProjectSources = "WCCCodeProjectSources";
			public const string WCCCodeRates = "WCCCodeRates";

			//Intentionally excluded
			//public const string All = "Files,WCCCodeCostCodeSources,WCCCodeLaborItemSources,WCCCodeMaxInsurableWages,WCCCodeProjectSources,WCCCodeRates";
		}
	}
}