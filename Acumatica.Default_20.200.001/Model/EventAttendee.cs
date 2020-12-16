using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class EventAttendee : Entity_v4
	{

		[DataMember(Name="Comment", EmitDefaultValue=false)]
		public StringValue Comment { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue Email { get; set; }

		[DataMember(Name="EventNoteID", EmitDefaultValue=false)]
		public GuidValue EventNoteID { get; set; }

		[DataMember(Name="InvitationStatus", EmitDefaultValue=false)]
		public StringValue InvitationStatus { get; set; }

		[DataMember(Name="Key", EmitDefaultValue=false)]
		public StringValue Key { get; set; }

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue Name { get; set; }

		[DataMember(Name="NameAttendeeName", EmitDefaultValue=false)]
		public StringValue NameAttendeeName { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public IntValue Type { get; set; }

	}
}