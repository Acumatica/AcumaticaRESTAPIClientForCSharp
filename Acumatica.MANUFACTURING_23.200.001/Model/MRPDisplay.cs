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
	/// Corresponds to the screen AM400000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MRPDisplay : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActionDate 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActionDate", EmitDefaultValue=false)]
		public DateTimeValue? ActionDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActionLeadTime 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActionLeadTime", EmitDefaultValue=false)]
		public IntValue? ActionLeadTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseQty 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseQty", EmitDefaultValue=false)]
		public DecimalValue? BaseQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseUOM 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMRevisionID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID_InventoryItem_descr 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MRPDate", EmitDefaultValue=false)]
		public DateTimeValue? MRPDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentInventoryID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ParentInventoryID", EmitDefaultValue=false)]
		public StringValue? ParentInventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentSubItemID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ParentSubitem", EmitDefaultValue=false)]
		public StringValue? ParentSubitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PreferredVendorID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PreferredVendorID", EmitDefaultValue=false)]
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductInventoryID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductInventoryID", EmitDefaultValue=false)]
		public StringValue? ProductInventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductManagerID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductManagerID", EmitDefaultValue=false)]
		public StringValue? ProductManagerID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductSubItemID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductSubitem", EmitDefaultValue=false)]
		public StringValue? ProductSubitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PromiseDate 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RecordID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefType 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReferenceType", EmitDefaultValue=false)]
		public StringValue? ReferenceType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentRefNbr 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RelatedParentDocument", EmitDefaultValue=false)]
		public StringValue? RelatedParentDocument { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductRefNbr 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RelatedProductDocument", EmitDefaultValue=false)]
		public StringValue? RelatedProductDocument { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SDFlag 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SDFlag", EmitDefaultValue=false)]
		public StringValue? SDFlag { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Selected 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReplenishmentSource 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TransferSiteID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TransferWarehouse", EmitDefaultValue=false)]
		public StringValue? TransferWarehouse { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Type 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMRPDetail 
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