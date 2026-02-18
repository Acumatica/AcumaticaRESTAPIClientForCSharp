using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class MRPBucketDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMRPBucketDetail</para>
		/// Key Field
		/// </summary>
		public IntValue? Bucket { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMRPBucket</para>
		/// <para>Display Name: Bucket ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? BucketID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMRPBucketDetail</para>
		/// </summary>
		public StringValue? Interval { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMRPBucketDetail</para>
		/// </summary>
		public IntValue? Value { get; set; }

	}
}