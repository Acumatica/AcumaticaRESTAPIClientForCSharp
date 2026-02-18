using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class InventoryIssueDetailAllocation : Entity
	{

		public DateTimeValue? ExpirationDate { get; set; }

		public StringValue? InventoryID { get; set; }

		public StringValue? Location { get; set; }

		public StringValue? LotSerialNbr { get; set; }

		public DecimalValue? Qty { get; set; }

		public IntValue? SplitLineNumber { get; set; }

		public StringValue? Subitem { get; set; }

		public StringValue? UOM { get; set; }

	}
}