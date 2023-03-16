using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CreateProductionOrderProcess : EntityAction<CreateProductionOrder>
	{
		public CreateProductionOrderProcess(CreateProductionOrder entity) : base(entity)
		{ }
		public CreateProductionOrderProcess() : base()
		{ }
	}
}
