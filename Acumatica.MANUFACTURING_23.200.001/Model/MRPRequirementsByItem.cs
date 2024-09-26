using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM401200 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MRPRequirementsByItem : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BucketID 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BucketID", EmitDefaultValue=false)]
		public StringValue? BucketID { get; set; }

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<MRPRequirementsByItemDetail>? Detail { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LeadTime 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LeadTime", EmitDefaultValue=false)]
		public IntValue? LeadTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PreferredVendorID 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PreferredVendorID", EmitDefaultValue=false)]
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductManagerID 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductMgr", EmitDefaultValue=false)]
		public IntValue? ProductMgr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductManagerID_description 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductMgrContact", EmitDefaultValue=false)]
		public StringValue? ProductMgrContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyOnHand 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QtyonHand", EmitDefaultValue=false)]
		public DecimalValue? QtyonHand { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReplenishmentSource 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RepSource", EmitDefaultValue=false)]
		public StringValue? RepSource { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SafetyStock 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.BucketFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}