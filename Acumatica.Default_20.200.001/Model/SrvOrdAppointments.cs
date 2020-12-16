using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SrvOrdAppointments : Entity_v4
	{

		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue AppointmentNbr { get; set; }

		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue Confirmed { get; set; }

		[DataMember(Name="ScheduledEndDate", EmitDefaultValue=false)]
		public DateTimeValue ScheduledEndDate { get; set; }

		[DataMember(Name="ScheduledEndTime", EmitDefaultValue=false)]
		public DateTimeValue ScheduledEndTime { get; set; }

		[DataMember(Name="ScheduledStartDate", EmitDefaultValue=false)]
		public DateTimeValue ScheduledStartDate { get; set; }

		[DataMember(Name="ScheduledStartTime", EmitDefaultValue=false)]
		public DateTimeValue ScheduledStartTime { get; set; }

		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue ServiceOrderType { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

	}
}