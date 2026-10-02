using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ChangeRequestMarkup : Entity
	{

		#region Fields
		public StringValue? AccountGroup { get; set; }

		public DecimalValue? AmountSubjectToMarkup { get; set; }

		public StringValue? CostCode { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? InventoryID { get; set; }

		public DecimalValue? MarkupAmount { get; set; }

		public StringValue? ProjectTask { get; set; }

		public StringValue? TaxCategory { get; set; }

		public StringValue? Type { get; set; }

		public DecimalValue? Value { get; set; }

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