using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CancelPhysicalInventory : EntityAction<PhysicalInventoryReview>
	{
		public CancelPhysicalInventory(PhysicalInventoryReview entity) : base(entity)
		{ }
		public CancelPhysicalInventory() : base()
		{ }
	}
}
