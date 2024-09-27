using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class MRPBucketDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMMRPBucketDetail 
		/// Key Field
		/// </summary>
		[DataMember(Name="Bucket", EmitDefaultValue=false)]
		public IntValue? Bucket { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMRPBucket 
		/// Display Name: Bucket ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BucketID", EmitDefaultValue=false)]
		public StringValue? BucketID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMRPBucketDetail 
		/// </summary>
		[DataMember(Name="Interval", EmitDefaultValue=false)]
		public StringValue? Interval { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMRPBucketDetail 
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public IntValue? Value { get; set; }

	}
}