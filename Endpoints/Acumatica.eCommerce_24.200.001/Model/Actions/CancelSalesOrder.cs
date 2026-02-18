using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	public class CancelSalesOrder : EntityAction<SalesOrder>
	{
		public CancelSalesOrder(SalesOrder entity) : base(entity)
		{ }
	}
}
