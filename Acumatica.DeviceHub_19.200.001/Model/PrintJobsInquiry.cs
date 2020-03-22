using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.DeviceHub_19_200_001.Model
{
	[DataContract]
	public class PrintJobsInquiry : Entity
	{

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="HideProcessed", EmitDefaultValue=false)]
		public BooleanValue HideProcessed { get; set; }

		[DataMember(Name="JobID", EmitDefaultValue=false)]
		public IntValue JobID { get; set; }

		[DataMember(Name="Jobs", EmitDefaultValue=false)]
		public List<PrintJob> Jobs { get; set; }

	}
}