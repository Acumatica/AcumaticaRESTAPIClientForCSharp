using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class EventRelatedActivity : Entity
	{

		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue Billable { get; set; }

		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public StringValue BillableOvertime { get; set; }

		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue BillableTime { get; set; }

		[DataMember(Name="Overtime", EmitDefaultValue=false)]
		public StringValue Overtime { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue Summary { get; set; }

		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue TimeSpent { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}