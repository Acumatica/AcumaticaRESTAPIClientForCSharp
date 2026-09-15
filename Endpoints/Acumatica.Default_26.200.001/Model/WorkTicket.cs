using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SV302000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WorkTicket : Entity, ITopLevelEntity
	{

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail>? Activities { get; set; }

		[DataMember(Name="CustomerSigned", EmitDefaultValue=false)]
		public BooleanValue? CustomerSigned { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<WorkTicketDetail>? Details { get; set; }

		[DataMember(Name="DocDate", EmitDefaultValue=false)]
		public DateOnlyValue? DocDate { get; set; }

		[DataMember(Name="EventNoteID", EmitDefaultValue=false)]
		public GuidValue? EventNoteID { get; set; }

		[DataMember(Name="Expenses", EmitDefaultValue=false)]
		public List<WorkTicketExpenseDetail>? Expenses { get; set; }

		[DataMember(Name="RefNoteID", EmitDefaultValue=false)]
		public GuidValue? RefNoteID { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		[DataMember(Name="TicketNbr", EmitDefaultValue=false)]
		public StringValue? TicketNbr { get; set; }

		[DataMember(Name="TimeActivities", EmitDefaultValue=false)]
		public List<WorkTicketTimeActivityDetail>? TimeActivities { get; set; }

		[DataMember(Name="WorkTasks", EmitDefaultValue=false)]
		public List<WorkTaskDetail>? WorkTasks { get; set; }

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
			public const string Translations = "Translations";
			public const string Activities = "Activities";
			public const string Details = "Details";
			public const string Expenses = "Expenses";
			public const string TimeActivities = "TimeActivities";
			public const string WorkTasks = "WorkTasks";

			//Intentionally excluded
			//public const string All = "Files,Translations,Activities,Details,Expenses,TimeActivities,WorkTasks";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}