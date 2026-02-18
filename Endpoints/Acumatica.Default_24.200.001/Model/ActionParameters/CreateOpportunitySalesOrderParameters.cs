using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class CreateOpportunitySalesOrderParameters
	{
		public CreateOpportunitySalesOrderParameters() { }


		public StringValue? OrderType { get; set; }

		public BooleanValue? RecalculatePricesandDiscounts { get; set; }
	}
}