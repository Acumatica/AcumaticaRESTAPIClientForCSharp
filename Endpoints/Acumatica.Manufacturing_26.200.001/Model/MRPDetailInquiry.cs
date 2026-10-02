using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM404000</c> in the Acumatica ERP
	/// </summary>
	public class MRPDetailInquiry : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// Inventory ID
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// Sub item ID
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// Warehouse
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// Qty on hand
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Qty. On Hand</para>
		/// </summary>
		public DecimalValue? QtyOnHand { get; set; }

		/// <summary>
		/// U o m
		/// <para>DAC Field Name: UOM</para>
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Base Unit</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? BaseUnit { get; set; }

		/// <summary>
		/// Safety stock
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Safety Stock</para>
		/// </summary>
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// Min order qty
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Min. Order Qty.</para>
		/// </summary>
		public DecimalValue? MinOrderQty { get; set; }

		/// <summary>
		/// Max order qty
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Max. Order Qty.</para>
		/// </summary>
		public DecimalValue? MaxOrderQty { get; set; }

		/// <summary>
		/// Lot qty
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Lot Qty.</para>
		/// </summary>
		public DecimalValue? LotQty { get; set; }

		public IntValue? DaysOfSupply { get; set; }

		public DecimalValue? EOQ { get; set; }

		public DecimalValue? LotMultiple { get; set; }

		public DecimalValue? ManufacturingEOQ { get; set; }

		public DecimalValue? MaxLotSize { get; set; }

		public DecimalValue? MaxQty { get; set; }

		public DecimalValue? MinLotSize { get; set; }

		public DecimalValue? ReorderPoint { get; set; }

		public DecimalValue? TransferERQ { get; set; }

		#endregion

		#region Details
		public List<MRPDetailInquiryResult>? Results { get; set; }

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
			public const string Translations = "Translations";
			public const string Results = "Results";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}