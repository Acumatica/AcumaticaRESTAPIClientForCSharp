using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_26_200_001.Model
{
	public class ProjectBudget : Acumatica.Default_26_200_001.Model.ProjectBudget, ITopLevelEntity
	{

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/26.200.001";
		}
	}
}