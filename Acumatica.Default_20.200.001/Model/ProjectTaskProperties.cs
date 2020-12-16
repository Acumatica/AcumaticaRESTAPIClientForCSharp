using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectTaskProperties : Entity_v4
	{

		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue Approver { get; set; }

		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public DecimalValue Completed { get; set; }

		[DataMember(Name="CompletionMethod", EmitDefaultValue=false)]
		public StringValue CompletionMethod { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="PlannedEndDate", EmitDefaultValue=false)]
		public DateTimeValue PlannedEndDate { get; set; }

		[DataMember(Name="PlannedStartDate", EmitDefaultValue=false)]
		public DateTimeValue PlannedStartDate { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

	}
}