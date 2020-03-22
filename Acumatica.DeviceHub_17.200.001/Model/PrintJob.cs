using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.DeviceHub_17_200_001.Model
{
	[DataContract]
	public class PrintJob : Entity
	{

		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue CreatedBy { get; set; }

		[DataMember(Name="CreationDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreationDateTime { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="JobID", EmitDefaultValue=false)]
		public IntValue JobID { get; set; }

		[DataMember(Name="Printer", EmitDefaultValue=false)]
		public StringValue Printer { get; set; }

		[DataMember(Name="ReportID", EmitDefaultValue=false)]
		public StringValue ReportID { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

	}
}