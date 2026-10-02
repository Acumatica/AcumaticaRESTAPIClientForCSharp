using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class DuplicateDetail : Entity
	{

		#region Fields
		public StringValue? AccountName { get; set; }

		public StringValue? BusinessAccount { get; set; }

		public StringValue? BusinessAccountType { get; set; }

		public IntValue? ContactID { get; set; }

		public StringValue? DisplayName { get; set; }

		public StringValue? Duplicate { get; set; }

		public IntValue? DuplicateContactID { get; set; }

		public StringValue? Email { get; set; }

		public StringValue? EntityType { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? Type { get; set; }

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

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}