using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CaseDetail : Entity_v4
	{

		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue CaseID { get; set; }

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue ClassID { get; set; }

		[DataMember(Name="ClosingDate", EmitDefaultValue=false)]
		public DateTimeValue ClosingDate { get; set; }

		[DataMember(Name="DateReported", EmitDefaultValue=false)]
		public DateTimeValue DateReported { get; set; }

		[DataMember(Name="Estimation", EmitDefaultValue=false)]
		public StringValue Estimation { get; set; }

		[DataMember(Name="InitialResponse", EmitDefaultValue=false)]
		public StringValue InitialResponse { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue Reason { get; set; }

		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringValue Severity { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue Subject { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

	}
}