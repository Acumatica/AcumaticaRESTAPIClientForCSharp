using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class EngineeringChangeRequestMaterial : Entity
	{

		public BooleanValue? Backflush { get; set; }

		public DecimalValue? BatchSize { get; set; }

		public StringValue? BubbleNbr { get; set; }

		public StringValue? ChangeStatus { get; set; }

		public StringValue? CompBOMID { get; set; }

		public StringValue? CompBOMRevision { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? ECRID { get; set; }

		public DateTimeValue? EffectiveDate { get; set; }

		public DateTimeValue? ExpirationDate { get; set; }

		public StringValue? InventoryID { get; set; }

		public IntValue? LineNbr { get; set; }

		public IntValue? LineOrder { get; set; }

		public StringValue? Location { get; set; }

		public StringValue? MaterialType { get; set; }

		public StringValue? OperationID { get; set; }

		public StringValue? PhantomRouting { get; set; }

		public DecimalValue? PlannedCost { get; set; }

		public DecimalValue? QtyRequired { get; set; }

		public List<ECRReferenceDesignator>? ReferenceDesignators { get; set; }

		public StringValue? Revision { get; set; }

		public DecimalValue? ScrapFactor { get; set; }

		public StringValue? SubcontractSource { get; set; }

		public StringValue? Subitem { get; set; }

		public DecimalValue? UnitCost { get; set; }

		public StringValue? UOM { get; set; }

		public StringValue? Warehouse { get; set; }

	}
}