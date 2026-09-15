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
	public class WorkEventLaborDetail : Entity
	{

		[DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
		public StringValue? ContactDisplayName { get; set; }

		[DataMember(Name="EventNoteID", EmitDefaultValue=false)]
		public GuidValue? EventNoteID { get; set; }

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue? Phone1Type { get; set; }

		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		[DataMember(Name="Phone2Type", EmitDefaultValue=false)]
		public StringValue? Phone2Type { get; set; }

		[DataMember(Name="Position", EmitDefaultValue=false)]
		public StringValue? Position { get; set; }

		[DataMember(Name="PositionDescription", EmitDefaultValue=false)]
		public StringValue? PositionDescription { get; set; }

		[DataMember(Name="ResourceNoteID", EmitDefaultValue=false)]
		public GuidValue? ResourceNoteID { get; set; }

		[DataMember(Name="Subcontractor", EmitDefaultValue=false)]
		public StringValue? Subcontractor { get; set; }

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