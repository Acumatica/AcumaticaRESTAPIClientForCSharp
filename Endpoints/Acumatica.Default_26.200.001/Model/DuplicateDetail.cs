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
	public class DuplicateDetail : Entity
	{

		[DataMember(Name="AccountName", EmitDefaultValue=false)]
		public StringValue? AccountName { get; set; }

		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		[DataMember(Name="BusinessAccountType", EmitDefaultValue=false)]
		public StringValue? BusinessAccountType { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue? DisplayName { get; set; }

		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue? Duplicate { get; set; }

		[DataMember(Name="DuplicateContactID", EmitDefaultValue=false)]
		public IntValue? DuplicateContactID { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="EntityType", EmitDefaultValue=false)]
		public StringValue? EntityType { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

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