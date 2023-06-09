using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class StorageDetailsByLocationInquiry : Entity
	{

		[DataMember(Name="SplitByLocation", EmitDefaultValue=false)]
		public BooleanValue SplitByLocation { get; set; }

		[DataMember(Name="StorageDetailsByLocation", EmitDefaultValue=false)]
		public List<StorageDetailByLocation> StorageDetailsByLocation { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

	}
}