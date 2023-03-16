using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class CancelProductionOrder : EntityAction<ProductionOrder>
	{
		public CancelProductionOrder(ProductionOrder entity) : base(entity)
		{ }
		public CancelProductionOrder() : base()
		{ }
	}
}
