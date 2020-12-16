using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class RelationDetail : Entity_v4
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="AddToCc", EmitDefaultValue=false)]
		public BooleanValue AddToCc { get; set; }

		[DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
		public StringValue ContactDisplayName { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue ContactID { get; set; }

		[DataMember(Name="Document", EmitDefaultValue=false)]
		public GuidValue Document { get; set; }

		[DataMember(Name="DocumentTargetNoteIDDescription", EmitDefaultValue=false)]
		public StringValue DocumentTargetNoteIDDescription { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue Email { get; set; }

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue Name { get; set; }

		[DataMember(Name="Primary", EmitDefaultValue=false)]
		public BooleanValue Primary { get; set; }

		[DataMember(Name="RelationID", EmitDefaultValue=false)]
		public IntValue RelationID { get; set; }

		[DataMember(Name="Role", EmitDefaultValue=false)]
		public StringValue Role { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}