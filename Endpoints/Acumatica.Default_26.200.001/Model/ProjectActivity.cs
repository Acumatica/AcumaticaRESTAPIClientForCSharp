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
	public class ProjectActivity : Entity
	{

		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public IntSingleSelectValue? BillableOvertime { get; set; }

		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public IntSingleSelectValue? BillableTime { get; set; }

		[DataMember(Name="Category", EmitDefaultValue=false)]
		public StringValue? Category { get; set; }

		[DataMember(Name="Overtime", EmitDefaultValue=false)]
		public IntSingleSelectValue? Overtime { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public IntSingleSelectValue? TimeSpent { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

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