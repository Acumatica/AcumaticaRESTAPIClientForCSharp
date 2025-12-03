using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN408055</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class StorageDetailsByLocationInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: SplitLocations</para>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		[DataMember(Name="SplitByLocation", EmitDefaultValue=false)]
		public BooleanValue? SplitByLocation { get; set; }

		[DataMember(Name="StorageDetailsByLocation", EmitDefaultValue=false)]
		public List<StorageDetailByLocation>? StorageDetailsByLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Warehouse</para>
		/// <para>DAC: PX.Data.GenericFilter</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string StorageDetailsByLocation = "StorageDetailsByLocation";
			public const string StorageDetailsByLocation_Files = "StorageDetailsByLocation/Files";

			//Intentionally excluded
			//public const string All = "Files,StorageDetailsByLocation,StorageDetailsByLocation/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}