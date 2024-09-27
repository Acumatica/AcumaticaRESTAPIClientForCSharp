using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM401200 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MRPRequirementsByItem : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.BucketFilter 
		/// Display Name: Bucket ID 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="BucketID", EmitDefaultValue=false)]
		public StringValue? BucketID { get; set; }

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<MRPRequirementsByItemDetail>? Detail { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.BucketFilter 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.BucketFilter 
		/// Display Name: Lead Time 
		/// </summary>
		[DataMember(Name="LeadTime", EmitDefaultValue=false)]
		public IntValue? LeadTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.BucketFilter 
		/// Display Name: Preferred Vendor ID 
		/// </summary>
		[DataMember(Name="PreferredVendorID", EmitDefaultValue=false)]
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// DAC Field Name: ProductManagerID 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// Display Name: Product Mgr. 
		/// </summary>
		[DataMember(Name="ProductMgr", EmitDefaultValue=false)]
		public IntValue? ProductMgr { get; set; }

		/// <summary>
		/// DAC Field Name: ProductManagerID_description 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		[DataMember(Name="ProductMgrContact", EmitDefaultValue=false)]
		public StringValue? ProductMgrContact { get; set; }

		/// <summary>
		/// DAC Field Name: QtyOnHand 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// Display Name: Qty. on Hand 
		/// </summary>
		[DataMember(Name="QtyonHand", EmitDefaultValue=false)]
		public DecimalValue? QtyonHand { get; set; }

		/// <summary>
		/// Replenishment source
		/// DAC Field Name: ReplenishmentSource 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// Display Name: Rep. Source 
		/// SQL Type: nchar(1) 
		/// </summary>
		[DataMember(Name="RepSource", EmitDefaultValue=false)]
		public StringValue? RepSource { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.BucketFilter 
		/// Display Name: Safety Stock 
		/// </summary>
		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}