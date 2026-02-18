using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class OrderMaterialDetail : Entity
	{

		public BooleanValue? Backflush { get; set; }

		public DecimalValue? BatchSize { get; set; }

		public BooleanValue? Byproduct { get; set; }

		public StringValue? CompBOMID { get; set; }

		public StringValue? CompBOMRevision { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? InventoryID { get; set; }

		public IntValue? LineNbr { get; set; }

		public IntValue? LineOrder { get; set; }

		public StringValue? Location { get; set; }

		public BooleanValue? MarkforPO { get; set; }

		public BooleanValue? MarkforProduction { get; set; }

		public StringValue? MaterialStatus { get; set; }

		public StringValue? MaterialType { get; set; }

		public StringValue? PhantomBomID { get; set; }

		public IntValue? PhantomBOMLineID { get; set; }

		public StringValue? PhantomBOMOperNbr { get; set; }

		public IntValue? PhantomLevel { get; set; }

		public IntValue? PhantomMatlLineID { get; set; }

		public StringValue? PhantomMatlOperNbr { get; set; }

		public DecimalValue? PlannedCost { get; set; }

		public DecimalValue? QtyActual { get; set; }

		public DecimalValue? QtyRemaining { get; set; }

		public DecimalValue? QtyRequired { get; set; }

		public BooleanValue? QtyRoundUp { get; set; }

		public DecimalValue? ScrapFactor { get; set; }

		public StringValue? SubcontractSource { get; set; }

		public StringValue? Subitem { get; set; }

		public DecimalValue? TotalActualCost { get; set; }

		public DecimalValue? TotalRequired { get; set; }

		public DecimalValue? UnitCost { get; set; }

		public StringValue? UOM { get; set; }

		public StringValue? Warehouse { get; set; }

		public BooleanValue? WarehouseOverride { get; set; }

	}
}