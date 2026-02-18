using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class TransferOrderDetailAllocation : Entity
	{

		public StringValue? LocationID { get; set; }

		public StringValue? LotSerialNbr { get; set; }

		public DecimalValue? Qty { get; set; }

		public IntValue? SplitLineNumber { get; set; }

		public StringValue? Subitem { get; set; }

	}
}