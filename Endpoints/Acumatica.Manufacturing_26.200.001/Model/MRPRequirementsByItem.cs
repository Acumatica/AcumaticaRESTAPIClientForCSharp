using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM401200</c> in the Acumatica ERP
	/// </summary>
	public class MRPRequirementsByItem : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Bucket ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? BucketID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

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

		/// <summary>
		/// <para>DAC Field Name: QtyOnHand</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Qty. On Hand</para>
		/// </summary>
		public DecimalValue? QtyonHand { get; set; }

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
		/// Replenishment source
		/// <para>DAC Field Name: ReplenishmentSource</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Replenishment Source</para>
		/// <para>SQL Type: nchar(1)</para>
		/// </summary>
		public StringValue? RepSource { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Preferred Vendor</para>
		/// </summary>
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Lead Time</para>
		/// </summary>
		public IntValue? LeadTime { get; set; }

		public DecimalValue? ReorderPoint { get; set; }

		#endregion

		#region Details
		public List<MRPRequirementsByItemDetail>? Detail { get; set; }

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
			public const string Detail = "Detail";

			//Intentionally excluded
			//public const string All = "Files,Translations,Detail";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}