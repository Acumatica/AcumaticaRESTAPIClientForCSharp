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
	public class WorkEventTaskDetail : Entity
	{

		[DataMember(Name="EstimatedDuration", EmitDefaultValue=false)]
		public IntValue? EstimatedDuration { get; set; }

		[DataMember(Name="EventNoteID", EmitDefaultValue=false)]
		public GuidValue? EventNoteID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaskNoteID", EmitDefaultValue=false)]
		public GuidValue? TaskNoteID { get; set; }

		[DataMember(Name="TaskSummary", EmitDefaultValue=false)]
		public StringValue? TaskSummary { get; set; }

		[DataMember(Name="TaskType", EmitDefaultValue=false)]
		public StringValue? TaskType { get; set; }

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