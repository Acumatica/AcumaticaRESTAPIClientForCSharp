using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM201200</c> in the Acumatica ERP
	/// <para>Key Fields: BucketID</para>
	/// </summary>
	public class MRPBuckets : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: ActiveFlg</para>
		/// <para>DAC: PX.Objects.AM.AMMRPBucket</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMRPBucket</para>
		/// <para>Display Name: Bucket ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? BucketID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMMRPBucket</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<MRPBucketDetail>? Details { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}