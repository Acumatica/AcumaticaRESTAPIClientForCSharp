using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ProjectGLAccount : Entity
	{

		#region Fields
		public StringValue? AccrualAccount { get; set; }

		public StringValue? AccrualSubaccount { get; set; }

		public StringValue? DefaultAccount { get; set; }

		public StringValue? DefaultSubaccount { get; set; }

		public StringValue? DefaultCostAccount { get; set; }

		public StringValue? DefaultCostSubaccount { get; set; }

		#endregion

		#region Details
		public List<DefaultTaskForGLAccount>? DefaultTaskForGLAccounts { get; set; }

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
			public const string DefaultTaskForGLAccounts = "DefaultTaskForGLAccounts";

			//Intentionally excluded
			//public const string All = "DefaultTaskForGLAccounts";
		}
	}
}