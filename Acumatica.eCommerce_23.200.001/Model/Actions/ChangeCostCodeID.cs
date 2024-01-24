using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class ChangeCostCodeID : EntityActionWithParameters<CostCode, ChangeCostCodeIDParameters>
	{
		public ChangeCostCodeID(CostCode entity, ChangeCostCodeIDParameters parameters) : base(entity, parameters)
		{ }

		public StringValue? CostCodeID
		{
			get { return Parameters.CostCodeID; }
			set { Parameters.CostCodeID = value; }
		}
	}
}