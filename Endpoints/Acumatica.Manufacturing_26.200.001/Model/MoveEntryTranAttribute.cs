using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	public class MoveEntryTranAttribute : Entity
	{

		#region Fields
		public StringValue? Attribute { get; set; }

		public StringValue? AttributeID { get; set; }

		public StringValue? Description { get; set; }

		public IntValue? ProdAttributeLineNbr { get; set; }

		public BooleanValue? Required { get; set; }

		public IntValue? TranLineNbr { get; set; }

		public StringValue? Value { get; set; }

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