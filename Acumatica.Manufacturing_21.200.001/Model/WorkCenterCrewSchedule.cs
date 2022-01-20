using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class WorkCenterCrewSchedule : Entity_v4
	{

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<WorkCenterCrewScheduleDetail> Details { get; set; }

		[DataMember(Name="FromDate", EmitDefaultValue=false)]
		public DateTimeValue FromDate { get; set; }

		[DataMember(Name="Shift", EmitDefaultValue=false)]
		public StringValue Shift { get; set; }

		[DataMember(Name="ShowAll", EmitDefaultValue=false)]
		public BooleanValue ShowAll { get; set; }

		[DataMember(Name="ToDate", EmitDefaultValue=false)]
		public DateTimeValue ToDate { get; set; }

		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue WorkCenter { get; set; }

	}
}