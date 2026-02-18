using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class WCCCodeCostCodeSource : Entity
	{

		public StringValue? CostCodeFrom { get; set; }

		public StringValue? CostCodeTo { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public IntValue? LineNbr { get; set; }

		public StringValue? WorkCodeID { get; set; }

	}
}