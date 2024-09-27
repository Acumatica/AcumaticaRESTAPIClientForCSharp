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
	/// Corresponds to the screen IN408050 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class StorageDetailsInquiry : Entity, ITopLevelEntity
	{

		[DataMember(Name="StorageDetails", EmitDefaultValue=false)]
		public List<StorageDetail>? StorageDetails { get; set; }

		/// <summary>
		/// DAC Field Name: Warehouse 
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}