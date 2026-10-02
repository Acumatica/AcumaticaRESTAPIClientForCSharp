using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ActivityDetail : Entity
	{

		#region Fields
		public StringValue? AIResponsePriority { get; set; }

		public BooleanValue? Billable { get; set; }

		public IntSingleSelectValue? Overtime { get; set; }

		public IntSingleSelectValue? BillableOvertime { get; set; }

		public IntSingleSelectValue? BillableTime { get; set; }

		public StringValue? Category { get; set; }

		public StringValue? CostCode { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? CreatedByID { get; set; }

		public GuidValue? NoteID { get; set; }

		public StringValue? Owner { get; set; }

		public StringValue? Project { get; set; }

		public StringValue? ProjectTask { get; set; }

		public GuidValue? RefNoteID { get; set; }

		public BooleanValue? Released { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public StringSingleSelectValue? Status { get; set; }

		public StringValue? Summary { get; set; }

		public IntSingleSelectValue? TimeSpent { get; set; }

		public StringValue? Type { get; set; }

		public StringValue? WorkgroupID { get; set; }

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