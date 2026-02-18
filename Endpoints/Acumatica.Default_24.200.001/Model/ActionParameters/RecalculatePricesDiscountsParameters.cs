using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class RecalculatePricesDiscountsParameters
	{
		public RecalculatePricesDiscountsParameters() { }


		public BooleanValue? OverrideManualDiscounts { get; set; }

		public BooleanValue? OverrideManualDocGroupDiscounts { get; set; }

		public BooleanValue? OverrideManualPrices { get; set; }

		public BooleanValue? RecalcDiscounts { get; set; }

		public BooleanValue? RecalcUnitPrices { get; set; }
	}
}