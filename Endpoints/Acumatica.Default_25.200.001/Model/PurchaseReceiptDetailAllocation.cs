using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class PurchaseReceiptDetailAllocation : Entity
	{

		public IntValue? LineNbr { get; set; }

		public StringValue? Location { get; set; }

		public StringValue? LotSerialNbr { get; set; }

		public DecimalValue? Qty { get; set; }

		public StringValue? ReceiptNbr { get; set; }

		public IntValue? SplitLineNbr { get; set; }

		public DateTimeValue? ExpirationDate { get; set; }

	}
}