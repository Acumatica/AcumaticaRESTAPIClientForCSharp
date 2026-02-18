using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	public class PrepareSalesInvoice : EntityAction<SalesOrder>
	{
		public PrepareSalesInvoice(SalesOrder entity) : base(entity)
		{ }
	}
}
