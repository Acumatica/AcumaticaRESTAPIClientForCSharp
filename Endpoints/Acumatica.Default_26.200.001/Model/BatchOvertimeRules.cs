using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class BatchOvertimeRules : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: ApplyOvertimeRules</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Apply Overtime Rules for the Document</para>
		/// </summary>
		public BooleanValue? ApplyOvertimeRulesfortheDocument { get; set; }

		#endregion

		#region Details
		public List<BatchOvertimeRulesDetail>? OvertimeRulesDetails { get; set; }

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
			public const string OvertimeRulesDetails = "OvertimeRulesDetails";

			//Intentionally excluded
			//public const string All = "OvertimeRulesDetails";
		}
	}
}