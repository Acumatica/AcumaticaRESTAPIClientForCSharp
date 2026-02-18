using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM401200</c> in the Acumatica ERP
	/// </summary>
	public class MRPRequirementsByItem : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Bucket ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? BucketID { get; set; }

		public List<MRPRequirementsByItemDetail>? Detail { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Lead Time</para>
		/// </summary>
		public IntValue? LeadTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Preferred Vendor</para>
		/// </summary>
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductManagerID</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Product Mgr.</para>
		/// </summary>
		public IntValue? ProductMgr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductManagerID_description</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// </summary>
		public StringValue? ProductMgrContact { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyOnHand</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Qty. On Hand</para>
		/// </summary>
		public DecimalValue? QtyonHand { get; set; }

		/// <summary>
		/// Replenishment source
		/// <para>DAC Field Name: ReplenishmentSource</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Replenishment Source</para>
		/// <para>SQL Type: nchar(1)</para>
		/// </summary>
		public StringValue? RepSource { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Safety Stock</para>
		/// </summary>
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Detail = "Detail";
			public const string Detail_Files = "Detail/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Detail,Detail/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}