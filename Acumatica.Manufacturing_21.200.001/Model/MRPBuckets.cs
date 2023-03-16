using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class MRPBuckets : Entity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="BucketID", EmitDefaultValue=false)]
		public StringValue BucketID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<MRPBucketDetail> Details { get; set; }

	}
}