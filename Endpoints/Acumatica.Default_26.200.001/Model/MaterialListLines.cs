using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class MaterialListLines : Entity
	{

		#region Fields
		public StringValue? Branch { get; set; }

		public StringValue? CostCode { get; set; }

		public StringValue? Description { get; set; }

		public DateOnlyValue? DispatchOn { get; set; }

		public DateOnlyValue? ExpectedBy { get; set; }

		public DecimalValue? ExtCost { get; set; }

		public StringValue? InventoryID { get; set; }

		public StringValue? InventorySource { get; set; }

		public IntValue? LineNbr { get; set; }

		public DateOnlyValue? NeededBy { get; set; }

		public BooleanValue? POCreate { get; set; }

		public DateOnlyValue? POCreationDate { get; set; }

		public StringValue? ProjectTask { get; set; }

		public StringValue? ProvisioningDocRefNbr { get; set; }

		public StringValue? ProvisioningSource { get; set; }

		public DecimalValue? QtyAvailableforDispatch { get; set; }

		public DecimalValue? QtyAwaitingDelivery { get; set; }

		public DecimalValue? QtyDispatched { get; set; }

		public DecimalValue? QtyonDispatch { get; set; }

		public DecimalValue? QtyonOrders { get; set; }

		public DecimalValue? QtyProcured { get; set; }

		public DecimalValue? QtytoOrderorAllocate { get; set; }

		public DecimalValue? QtyUsed { get; set; }

		public DecimalValue? RequiredQty { get; set; }

		public StringValue? Status { get; set; }

		public DecimalValue? UnitCost { get; set; }

		public StringValue? UOM { get; set; }

		public StringValue? Vendor { get; set; }

		public StringValue? Warehouse { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}