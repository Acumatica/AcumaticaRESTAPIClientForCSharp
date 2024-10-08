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
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Action Date 
		/// </summary>
		[DataMember(Name="ActionDate", EmitDefaultValue=false)]
		public DateTimeValue? ActionDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Action Lead Time 
		/// </summary>
		[DataMember(Name="ActionLeadTime", EmitDefaultValue=false)]
		public IntValue? ActionLeadTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Base Qty 
		/// </summary>
		[DataMember(Name="BaseQty", EmitDefaultValue=false)]
		public DecimalValue? BaseQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Base UOM 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		/// <summary>
		/// BOM ID - ID of Bill of materials record
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// Bill of material Revision ID
		/// DAC Field Name: BOMRevisionID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: BOM Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryID_InventoryItem_descr 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Item Class 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Inventory Planning Date 
		/// </summary>
		[DataMember(Name="MRPDate", EmitDefaultValue=false)]
		public DateTimeValue? MRPDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Parent Inventory ID 
		/// </summary>
		[DataMember(Name="ParentInventoryID", EmitDefaultValue=false)]
		public StringValue? ParentInventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ParentSubItemID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Parent Subitem 
		/// </summary>
		[DataMember(Name="ParentSubitem", EmitDefaultValue=false)]
		public StringValue? ParentSubitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Preferred Vendor ID 
		/// </summary>
		[DataMember(Name="PreferredVendorID", EmitDefaultValue=false)]
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Product Inventory ID 
		/// </summary>
		[DataMember(Name="ProductInventoryID", EmitDefaultValue=false)]
		public StringValue? ProductInventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Product Manager ID 
		/// </summary>
		[DataMember(Name="ProductManagerID", EmitDefaultValue=false)]
		public StringValue? ProductManagerID { get; set; }

		/// <summary>
		/// DAC Field Name: ProductSubItemID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Product Subitem 
		/// </summary>
		[DataMember(Name="ProductSubitem", EmitDefaultValue=false)]
		public StringValue? ProductSubitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Promise Date 
		/// </summary>
		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Record ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// Plan type related to the RefOrdertype and RefOrderNbr
		/// DAC Field Name: RefType 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Reference Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="ReferenceType", EmitDefaultValue=false)]
		public StringValue? ReferenceType { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Related Document 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// DAC Field Name: ParentRefNbr 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Related Parent Document 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="RelatedParentDocument", EmitDefaultValue=false)]
		public StringValue? RelatedParentDocument { get; set; }

		/// <summary>
		/// DAC Field Name: ProductRefNbr 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Related Product Document 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="RelatedProductDocument", EmitDefaultValue=false)]
		public StringValue? RelatedProductDocument { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: SD Flag 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="SDFlag", EmitDefaultValue=false)]
		public StringValue? SDFlag { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// Replenishment source
		/// DAC Field Name: ReplenishmentSource 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// Transfer Warehouse ID
		/// DAC Field Name: TransferSiteID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// Display Name: Transfer Warehouse 
		/// </summary>
		[DataMember(Name="TransferWarehouse", EmitDefaultValue=false)]
		public StringValue? TransferWarehouse { get; set; }

		/// <summary>
		/// Planning Type
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMRPDetail 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}