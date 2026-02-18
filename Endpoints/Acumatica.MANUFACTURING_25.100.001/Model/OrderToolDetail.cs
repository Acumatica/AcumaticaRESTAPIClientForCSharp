using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class OrderToolDetail : Entity
	{

		public StringValue? Description { get; set; }

		public IntValue? LineID { get; set; }

		public StringValue? PhantomBomID { get; set; }

		public IntValue? PhantomBOMLineID { get; set; }

		public StringValue? PhantomBOMOperNbr { get; set; }

		public StringValue? PhantomBOMRevision { get; set; }

		public IntValue? PhantomLevel { get; set; }

		public StringValue? PhantomMatlBOMID { get; set; }

		public IntValue? PhantomMatlLineID { get; set; }

		public StringValue? PhantomMatlOperNbr { get; set; }

		public StringValue? PhantomMatlRevision { get; set; }

		public DecimalValue? QtyRequired { get; set; }

		public StringValue? ToolID { get; set; }

		public StringValue? ToolIDDescription { get; set; }

		public StringValue? ToolIDToolID { get; set; }

		public DecimalValue? TotalActualCost { get; set; }

		public DecimalValue? TotalActualUses { get; set; }

		public DecimalValue? UnitCost { get; set; }

	}
}