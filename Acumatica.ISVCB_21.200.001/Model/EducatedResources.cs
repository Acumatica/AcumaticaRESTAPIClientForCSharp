using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.ISVCB_21_200_001.Model
{
	[DataContract]
	public class EducatedResources : Entity_v4
	{

		[DataMember(Name="AccountID", EmitDefaultValue=false)]
		public IntValue AccountID { get; set; }

		[DataMember(Name="AccountID_2", EmitDefaultValue=false)]
		public IntValue AccountID_2 { get; set; }

		[DataMember(Name="AccountID_3", EmitDefaultValue=false)]
		public IntValue AccountID_3 { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="Type_2", EmitDefaultValue=false)]
		public StringValue Type_2 { get; set; }

		[DataMember(Name="Class", EmitDefaultValue=false)]
		public StringValue Class { get; set; }

		[DataMember(Name="Class_2", EmitDefaultValue=false)]
		public StringValue Class_2 { get; set; }

		[DataMember(Name="Class_3", EmitDefaultValue=false)]
		public StringValue Class_3 { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue ContactID { get; set; }

		[DataMember(Name="EducatedResourcesDetails", EmitDefaultValue=false)]
		public List<EducatedResourcesDetail> EducatedResourcesDetails { get; set; }

	}
}