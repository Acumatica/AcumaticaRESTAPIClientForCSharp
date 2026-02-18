using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class EngineeringChangeOrderTool : Entity
	{

		public StringValue? ChangeStatus { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? ECOID { get; set; }

		public IntValue? LineID { get; set; }

		public StringValue? OperationID { get; set; }

		public DecimalValue? QtyRequired { get; set; }

		public StringValue? Revision { get; set; }

		public StringValue? ToolID { get; set; }

		public DecimalValue? UnitCost { get; set; }

	}
}