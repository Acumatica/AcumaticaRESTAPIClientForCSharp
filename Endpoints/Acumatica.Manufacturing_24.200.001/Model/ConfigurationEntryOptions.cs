using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class ConfigurationEntryOptions : Entity
	{

		public IntValue? ConfigResultsID { get; set; }

		public StringValue? Description { get; set; }

		public IntValue? FeatureLineNbr { get; set; }

		public BooleanValue? Included { get; set; }

		public StringValue? InventoryID { get; set; }

		public BooleanValue? IsRemovable { get; set; }

		public StringValue? Label { get; set; }

		public IntValue? OptionLineNbr { get; set; }

		public DecimalValue? Qty { get; set; }

		public StringValue? Subitem { get; set; }

		public StringValue? UOM { get; set; }

	}
}