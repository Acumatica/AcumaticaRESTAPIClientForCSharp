using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ProjectActivity : Entity
	{

		#region Fields
		public BooleanValue? Billable { get; set; }

		public IntSingleSelectValue? BillableOvertime { get; set; }

		public IntSingleSelectValue? BillableTime { get; set; }

		public StringValue? Category { get; set; }

		public IntSingleSelectValue? Overtime { get; set; }

		public StringValue? Owner { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public StringSingleSelectValue? Status { get; set; }

		public StringValue? Summary { get; set; }

		public IntSingleSelectValue? TimeSpent { get; set; }

		public StringValue? Type { get; set; }

		public StringValue? Workgroup { get; set; }

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