using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class Activity : Entity
	{

		[DataMember(Name="Body", EmitDefaultValue=false)]
		public StringValue Body { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="Internal", EmitDefaultValue=false)]
		public BooleanValue Internal { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="RelatedEntityDescription", EmitDefaultValue=false)]
		public StringValue RelatedEntityDescription { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue Summary { get; set; }

		[DataMember(Name="Task", EmitDefaultValue=false)]
		public StringValue Task { get; set; }

		[DataMember(Name="TimeActivity", EmitDefaultValue=false)]
		public TimeActivity TimeActivity { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

	}
}