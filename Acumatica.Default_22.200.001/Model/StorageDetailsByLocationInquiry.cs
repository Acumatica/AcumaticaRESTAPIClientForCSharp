using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN408055 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class StorageDetailsByLocationInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: SplitLocations 
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="SplitByLocation", EmitDefaultValue=false)]
		public BooleanValue? SplitByLocation { get; set; }

		[DataMember(Name="StorageDetailsByLocation", EmitDefaultValue=false)]
		public List<StorageDetailByLocation>? StorageDetailsByLocation { get; set; }

		/// <summary>
		/// DAC Field Name: Warehouse 
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}