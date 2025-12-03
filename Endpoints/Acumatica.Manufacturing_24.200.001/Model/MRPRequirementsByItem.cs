using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM401200</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MRPRequirementsByItem : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Bucket ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="BucketID", EmitDefaultValue=false)]
		public StringValue? BucketID { get; set; }

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<MRPRequirementsByItemDetail>? Detail { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Lead Time</para>
		/// </summary>
		[DataMember(Name="LeadTime", EmitDefaultValue=false)]
		public IntValue? LeadTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Preferred Vendor ID</para>
		/// </summary>
		[DataMember(Name="PreferredVendorID", EmitDefaultValue=false)]
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductManagerID</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Product Mgr.</para>
		/// </summary>
		[DataMember(Name="ProductMgr", EmitDefaultValue=false)]
		public IntValue? ProductMgr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductManagerID_description</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// </summary>
		[DataMember(Name="ProductMgrContact", EmitDefaultValue=false)]
		public StringValue? ProductMgrContact { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyOnHand</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Qty. on Hand</para>
		/// </summary>
		[DataMember(Name="QtyonHand", EmitDefaultValue=false)]
		public DecimalValue? QtyonHand { get; set; }

		/// <summary>
		/// Replenishment source
		/// <para>DAC Field Name: ReplenishmentSource</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Rep. Source</para>
		/// <para>SQL Type: nchar(1)</para>
		/// </summary>
		[DataMember(Name="RepSource", EmitDefaultValue=false)]
		public StringValue? RepSource { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// <para>Display Name: Safety Stock</para>
		/// </summary>
		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.BucketFilter</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Detail = "Detail";
			public const string Detail_Files = "Detail/Files";

			//Intentionally excluded
			//public const string All = "Files,Detail,Detail/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}