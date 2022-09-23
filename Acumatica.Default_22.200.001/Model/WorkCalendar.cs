using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class WorkCalendar : Entity_v4
	{

		[DataMember(Name="CalendarExceptions", EmitDefaultValue=false)]
		public List<WorkCalendarExceptionDetail> CalendarExceptions { get; set; }

		[DataMember(Name="CalendarSettings", EmitDefaultValue=false)]
		public CalendarSettings CalendarSettings { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="TimeZone", EmitDefaultValue=false)]
		public StringValue TimeZone { get; set; }

		[DataMember(Name="WorkCalendarID", EmitDefaultValue=false)]
		public StringValue WorkCalendarID { get; set; }

	}
}