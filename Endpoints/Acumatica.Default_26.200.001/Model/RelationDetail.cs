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
	public class RelationDetail : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		[DataMember(Name="AddToCc", EmitDefaultValue=false)]
		public BooleanValue? AddToCc { get; set; }

		[DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
		public StringValue? ContactDisplayName { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="Document", EmitDefaultValue=false)]
		public GuidValue? Document { get; set; }

		[DataMember(Name="DocumentTargetNoteIDDescription", EmitDefaultValue=false)]
		public StringValue? DocumentTargetNoteIDDescription { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		[DataMember(Name="Primary", EmitDefaultValue=false)]
		public BooleanValue? Primary { get; set; }

		[DataMember(Name="RelationID", EmitDefaultValue=false)]
		public IntValue? RelationID { get; set; }

		[DataMember(Name="Role", EmitDefaultValue=false)]
		public StringValue? Role { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringSingleSelectValue? Type { get; set; }

		[DataMember(Name="DocumentDate", EmitDefaultValue=false)]
		public DateTimeValue? DocumentDate { get; set; }

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