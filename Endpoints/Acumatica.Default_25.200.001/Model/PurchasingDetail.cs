using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class PurchasingDetail : Entity
	{

		public IntValue? POOrderLineNbr { get; set; }

		public StringValue? POOrderNbr { get; set; }

		public StringValue? POOrderType { get; set; }

		public BooleanValue? Selected { get; set; }

	}
}