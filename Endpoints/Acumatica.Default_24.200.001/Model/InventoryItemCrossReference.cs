using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class InventoryItemCrossReference : Entity
	{

		public StringValue? AlternateID { get; set; }

		public StringValue? AlternateType { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? Subitem { get; set; }

		public StringValue? VendorOrCustomer { get; set; }

		public StringValue? UOM { get; set; }

	}
}