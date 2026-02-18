using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class ToolDetail : Entity
	{

		public StringValue? Description { get; set; }

		public IntValue? LineID { get; set; }

		public DecimalValue? QtyRequired { get; set; }

		public StringValue? ToolID { get; set; }

		public DecimalValue? UnitCost { get; set; }

	}
}