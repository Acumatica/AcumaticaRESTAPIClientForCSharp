using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Approval : Entity_v4
	{

		[DataMember(Name="ApprovedBy", EmitDefaultValue=false)]
		public StringValue ApprovedBy { get; set; }

		[DataMember(Name="ApprovedByName", EmitDefaultValue=false)]
		public StringValue ApprovedByName { get; set; }

		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue Approver { get; set; }

		[DataMember(Name="ApproverName", EmitDefaultValue=false)]
		public StringValue ApproverName { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

	}
}