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
	public class ServiceLocationContactDetail : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		[DataMember(Name="Phone3", EmitDefaultValue=false)]
		public StringValue? Phone3 { get; set; }

		[DataMember(Name="Primary", EmitDefaultValue=false)]
		public BooleanValue? Primary { get; set; }

		[DataMember(Name="Salutation", EmitDefaultValue=false)]
		public StringValue? Salutation { get; set; }

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