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
	public class MarketingListDetail : Entity
	{

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="DynamicList", EmitDefaultValue=false)]
		public BooleanValue? DynamicList { get; set; }

		[DataMember(Name="Format", EmitDefaultValue=false)]
		public StringValue? Format { get; set; }

		[DataMember(Name="ListName", EmitDefaultValue=false)]
		public StringValue? ListName { get; set; }

		[DataMember(Name="MarketingListID", EmitDefaultValue=false)]
		public IntValue? MarketingListID { get; set; }

		[DataMember(Name="Subscribed", EmitDefaultValue=false)]
		public BooleanValue? Subscribed { get; set; }

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