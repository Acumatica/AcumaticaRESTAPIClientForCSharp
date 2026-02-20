using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ChangeCostCodeID : EntityActionWithParameters<CostCode, ChangeCostCodeIDParameters>
	{
		public ChangeCostCodeID(CostCode entity, ChangeCostCodeIDParameters parameters) : base(entity, parameters)
		{ }
	}
}