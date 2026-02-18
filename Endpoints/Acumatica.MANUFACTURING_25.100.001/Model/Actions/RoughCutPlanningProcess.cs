using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class RoughCutPlanningProcess : EntityAction<RoughCutPlanning>
	{
		public RoughCutPlanningProcess(RoughCutPlanning entity) : base(entity)
		{ }
	}
}
