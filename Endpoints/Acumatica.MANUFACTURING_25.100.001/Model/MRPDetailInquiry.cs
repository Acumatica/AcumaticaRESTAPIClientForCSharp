using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM404000</c> in the Acumatica ERP
	/// </summary>
	public class MRPDetailInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// U o m
		/// <para>DAC Field Name: UOM</para>
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Base Unit</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? BaseUnit { get; set; }

		/// <summary>
		/// Inventory ID
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// Lot qty
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Lot Qty.</para>
		/// </summary>
		public DecimalValue? LotQty { get; set; }

		/// <summary>
		/// Max order qty
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Max. Order Qty.</para>
		/// </summary>
		public DecimalValue? MaxOrderQty { get; set; }

		/// <summary>
		/// Min order qty
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Min. Order Qty.</para>
		/// </summary>
		public DecimalValue? MinOrderQty { get; set; }

		/// <summary>
		/// Qty on hand
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Qty. On Hand</para>
		/// </summary>
		public DecimalValue? QtyOnHand { get; set; }

		public List<MRPDetailInquiryResult>? Results { get; set; }

		/// <summary>
		/// Safety stock
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Safety Stock</para>
		/// </summary>
		public DecimalValue? SafetyStock { get; set; }

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

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}