using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class CreateProductionOrderProcessAll : EntityAction<CreateProductionOrder>
	{
		public CreateProductionOrderProcessAll(CreateProductionOrder entity) : base(entity)
		{ }
	}
}
