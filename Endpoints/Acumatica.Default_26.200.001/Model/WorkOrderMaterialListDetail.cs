using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class WorkOrderMaterialListDetail : Entity
	{

		#region Fields
		public StringValue? BranchID { get; set; }

		public BooleanValue? CreatedFromWorkTicket { get; set; }

		public StringValue? Description { get; set; }

		public DateOnlyValue? ExpectedByDate { get; set; }

		public DecimalValue? ExtCost { get; set; }

		public StringValue? InventoryID { get; set; }

		public IntValue? LineNbr { get; set; }

		public DateOnlyValue? NeededByDate { get; set; }

		public GuidValue? ProvisionNoteID { get; set; }

		public StringSingleSelectValue? ProvisioningSource { get; set; }

		public DecimalValue? QtyAvailableForDispatch { get; set; }

		public DecimalValue? QtyAwaiting { get; set; }

		public DecimalValue? QtyDispatched { get; set; }

		public DecimalValue? QtyOnDispatch { get; set; }

		public DecimalValue? QtyOnOrders { get; set; }

		public DecimalValue? QtyProcured { get; set; }

		public DecimalValue? QtyToOrder { get; set; }

		public DecimalValue? QtyUsed { get; set; }

		public DecimalValue? RequiredQty { get; set; }

		public DateOnlyValue? ShipDate { get; set; }

		public StringValue? SiteID { get; set; }

		public StringSingleSelectValue? Status { get; set; }

		public StringValue? ToLocationID { get; set; }

		public StringValue? ToSiteID { get; set; }

		public StringValue? UOM { get; set; }

		public DecimalValue? UnitCost { get; set; }

		public StringValue? VendorID { get; set; }

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