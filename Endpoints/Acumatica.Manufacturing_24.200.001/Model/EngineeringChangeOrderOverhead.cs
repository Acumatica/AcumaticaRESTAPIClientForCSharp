using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class EngineeringChangeOrderOverhead : Entity
	{

		public StringValue? ChangeStatus { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? ECOID { get; set; }

		public DecimalValue? Factor { get; set; }

		public IntValue? LineID { get; set; }

		public StringValue? OperationID { get; set; }

		public StringValue? OverheadID { get; set; }

		public StringValue? Revision { get; set; }

		public StringValue? Type { get; set; }

	}
}