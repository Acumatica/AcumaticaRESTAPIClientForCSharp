using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class Email : Entity
	{

		[DataMember(Name="Bcc", EmitDefaultValue=false)]
		public StringValue Bcc { get; set; }

		[DataMember(Name="Body", EmitDefaultValue=false)]
		public StringValue Body { get; set; }

		[DataMember(Name="Cc", EmitDefaultValue=false)]
		public StringValue Cc { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="From", EmitDefaultValue=false)]
		public StringValue From { get; set; }

		[DataMember(Name="FromEmailAccountDisplayName", EmitDefaultValue=false)]
		public StringValue FromEmailAccountDisplayName { get; set; }

		[DataMember(Name="FromEmailAccountID", EmitDefaultValue=false)]
		public IntValue FromEmailAccountID { get; set; }

		[DataMember(Name="Incoming", EmitDefaultValue=false)]
		public BooleanValue Incoming { get; set; }

		[DataMember(Name="Internal", EmitDefaultValue=false)]
		public BooleanValue Internal { get; set; }

		[DataMember(Name="MailStatus", EmitDefaultValue=false)]
		public StringValue MailStatus { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="Parent", EmitDefaultValue=false)]
		public GuidValue Parent { get; set; }

		[DataMember(Name="ParentSummary", EmitDefaultValue=false)]
		public StringValue ParentSummary { get; set; }

		[DataMember(Name="RelatedEntityDescription", EmitDefaultValue=false)]
		public StringValue RelatedEntityDescription { get; set; }

		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue StartTime { get; set; }

		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue Subject { get; set; }

		[DataMember(Name="TimeActivity", EmitDefaultValue=false)]
		public TimeActivity TimeActivity { get; set; }

		[DataMember(Name="To", EmitDefaultValue=false)]
		public StringValue To { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

	}
}