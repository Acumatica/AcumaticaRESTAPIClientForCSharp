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
	public class WorkTicketTimeActivityDetail : Entity
	{

		[DataMember(Name="ApprovalStatus", EmitDefaultValue=false)]
		public StringSingleSelectValue? ApprovalStatus { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		[DataMember(Name="EarningTypeID", EmitDefaultValue=false)]
		public StringValue? EarningTypeID { get; set; }

		[DataMember(Name="LabourItemID", EmitDefaultValue=false)]
		public StringValue? LabourItemID { get; set; }

		[DataMember(Name="OwnerID", EmitDefaultValue=false)]
		public StringValue? OwnerID { get; set; }

		[DataMember(Name="RefNoteID", EmitDefaultValue=false)]
		public GuidValue? RefNoteID { get; set; }

		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public IntSingleSelectValue? TimeSpent { get; set; }

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