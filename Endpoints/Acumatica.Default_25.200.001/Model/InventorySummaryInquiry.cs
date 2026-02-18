using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN401000</c> in the Acumatica ERP
	/// </summary>
	public class InventorySummaryInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Expand by Lot/Serial Numbers</para>
		/// </summary>
		public BooleanValue? ExpandByLotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		public StringValue? LocationID { get; set; }

		public List<InventorySummaryRow>? Results { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemCD</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

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
			return "entity/Default/25.200.001";
		}
	}
}