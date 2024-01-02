using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class FirmProductionOrder : EntityAction<ProductionOrder>
	{
		public FirmProductionOrder(ProductionOrder entity) : base(entity)
		{ }
		public FirmProductionOrder() : base()
		{ }
	}
}
