using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SV302000</c> in the Acumatica ERP
	/// </summary>
	public class WorkTicket : Entity, ITopLevelEntity
	{

		#region Fields
		public BooleanValue? CustomerSigned { get; set; }

		public StringValue? Description { get; set; }

		public DateOnlyValue? DocDate { get; set; }

		public GuidValue? EventNoteID { get; set; }

		public GuidValue? RefNoteID { get; set; }

		public StringSingleSelectValue? Status { get; set; }

		public StringValue? Summary { get; set; }

		public StringValue? TicketNbr { get; set; }

		#endregion

		#region Details
		public List<ActivityDetail>? Activities { get; set; }

		public List<WorkTicketDetail>? Details { get; set; }

		public List<WorkTicketExpenseDetail>? Expenses { get; set; }

		public List<WorkTicketTimeActivityDetail>? TimeActivities { get; set; }

		public List<WorkTaskDetail>? WorkTasks { get; set; }

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