using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class MRPBucketDetail : Entity_v4
	{

		[DataMember(Name="Bucket", EmitDefaultValue=false)]
		public IntValue Bucket { get; set; }

		[DataMember(Name="BucketID", EmitDefaultValue=false)]
		public StringValue BucketID { get; set; }

		[DataMember(Name="Interval", EmitDefaultValue=false)]
		public StringValue Interval { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public IntValue Value { get; set; }

	}
}