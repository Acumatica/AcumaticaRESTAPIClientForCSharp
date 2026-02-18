using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class ConfigurationMaintFeatureOption : Entity
	{

		public BooleanValue? Backflush { get; set; }

		public DecimalValue? BatchSize { get; set; }

		public StringValue? ConfigurationID { get; set; }

		public StringValue? Description { get; set; }

		public IntValue? FeatureLineNbr { get; set; }

		public BooleanValue? FixedInclude { get; set; }

		public StringValue? InventoryID { get; set; }

		public StringValue? Label { get; set; }

		public IntValue? LineNbr { get; set; }

		public StringValue? Location { get; set; }

		public StringValue? LotQty { get; set; }

		public StringValue? MaterialType { get; set; }

		public StringValue? MaxQty { get; set; }

		public StringValue? MinQty { get; set; }

		public StringValue? OperationID { get; set; }

		public StringValue? PhantomRouting { get; set; }

		public StringValue? PriceFactor { get; set; }

		public BooleanValue? PrintResults { get; set; }

		public BooleanValue? QtyEnabled { get; set; }

		public StringValue? QtyRequired { get; set; }

		public BooleanValue? QtyRoundUp { get; set; }

		public BooleanValue? ResultsCopy { get; set; }

		public StringValue? Revision { get; set; }

		public StringValue? ScrapFactor { get; set; }

		public IntValue? SortOrder { get; set; }

		public StringValue? SubcontractSource { get; set; }

		public StringValue? Subitem { get; set; }

		public StringValue? UOM { get; set; }

		public StringValue? Warehouse { get; set; }

	}
}