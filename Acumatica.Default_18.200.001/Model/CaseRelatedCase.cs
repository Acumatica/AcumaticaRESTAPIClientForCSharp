using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class CaseRelatedCase : Entity
	{

		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue CaseID { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="ParentCaseID", EmitDefaultValue=false)]
		public IntValue ParentCaseID { get; set; }

		[DataMember(Name="RelationType", EmitDefaultValue=false)]
		public StringValue RelationType { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue Subject { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

	}
}