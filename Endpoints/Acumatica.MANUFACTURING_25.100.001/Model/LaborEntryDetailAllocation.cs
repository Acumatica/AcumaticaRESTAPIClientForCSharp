using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class LaborEntryDetailAllocation : Entity
	{

		public DateTimeValue? ExpirationDate { get; set; }

		public StringValue? InventoryID { get; set; }

		public IntValue? LineNbr { get; set; }

		public StringValue? Location { get; set; }

		public StringValue? LotSerialNbr { get; set; }

		public DecimalValue? Quantity { get; set; }

		public IntValue? SplitLineNbr { get; set; }

		public StringValue? Subitem { get; set; }

		public StringValue? UOM { get; set; }

	}
}