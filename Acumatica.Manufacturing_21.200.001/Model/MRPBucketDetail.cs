using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class MRPBucketDetail : Entity
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