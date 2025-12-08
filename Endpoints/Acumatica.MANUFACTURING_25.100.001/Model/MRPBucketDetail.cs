using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	[DataContract]
	public class MRPBucketDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMRPBucketDetail</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Bucket", EmitDefaultValue=false)]
		public IntValue? Bucket { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMRPBucket</para>
		/// <para>Display Name: Bucket ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BucketID", EmitDefaultValue=false)]
		public StringValue? BucketID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMRPBucketDetail</para>
		/// </summary>
		[DataMember(Name="Interval", EmitDefaultValue=false)]
		public StringValue? Interval { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMRPBucketDetail</para>
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public IntValue? Value { get; set; }

	}
}