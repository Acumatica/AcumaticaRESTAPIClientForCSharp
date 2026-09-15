using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
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

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}