using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN408050</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class StorageDetailsInquiry : Entity, ITopLevelEntity
	{

		[DataMember(Name="StorageDetails", EmitDefaultValue=false)]
		public List<StorageDetail>? StorageDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Warehouse</para>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string StorageDetails = "StorageDetails";
			public const string StorageDetails_Files = "StorageDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,StorageDetails,StorageDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}