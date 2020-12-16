using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class LotSerialClass : Entity_v4
	{

		[DataMember(Name="AssignmentMethod", EmitDefaultValue=false)]
		public StringValue AssignmentMethod { get; set; }

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue ClassID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="IssueMethod", EmitDefaultValue=false)]
		public StringValue IssueMethod { get; set; }

		[DataMember(Name="Segments", EmitDefaultValue=false)]
		public List<LotSerialClassSegment> Segments { get; set; }

		[DataMember(Name="TrackExpirationDate", EmitDefaultValue=false)]
		public BooleanValue TrackExpirationDate { get; set; }

		[DataMember(Name="TrackingMethod", EmitDefaultValue=false)]
		public StringValue TrackingMethod { get; set; }

	}
}