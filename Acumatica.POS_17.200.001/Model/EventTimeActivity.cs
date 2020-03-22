using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class EventTimeActivity : Entity
	{

		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public StringValue BillableOvertime { get; set; }

		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue BillableTime { get; set; }

		[DataMember(Name="Overtime", EmitDefaultValue=false)]
		public StringValue Overtime { get; set; }

		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue TimeSpent { get; set; }

	}
}