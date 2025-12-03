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
	/// Corresponds to the screen <c>AM400000</c> in the Acumatica ERP
	/// <para>Key Fields: RecordID</para>
	/// </summary>
	[DataContract]
	public class MRPDisplay : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Action Date</para>
		/// </summary>
		[DataMember(Name="ActionDate", EmitDefaultValue=false)]
		public DateTimeValue? ActionDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Action Lead Time</para>
		/// </summary>
		[DataMember(Name="ActionLeadTime", EmitDefaultValue=false)]
		public IntValue? ActionLeadTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Base Qty</para>
		/// </summary>
		[DataMember(Name="BaseQty", EmitDefaultValue=false)]
		public DecimalValue? BaseQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Base UOM</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		/// <summary>
		/// BOM ID - ID of Bill of materials record
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// Bill of material Revision ID
		/// <para>DAC Field Name: BOMRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: BOM Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_descr</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC Field Name: CreatedDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Inventory Planning Date</para>
		/// </summary>
		[DataMember(Name="MRPDate", EmitDefaultValue=false)]
		public DateTimeValue? MRPDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Parent Inventory ID</para>
		/// </summary>
		[DataMember(Name="ParentInventoryID", EmitDefaultValue=false)]
		public StringValue? ParentInventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentSubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Parent Subitem</para>
		/// </summary>
		[DataMember(Name="ParentSubitem", EmitDefaultValue=false)]
		public StringValue? ParentSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Preferred Vendor ID</para>
		/// </summary>
		[DataMember(Name="PreferredVendorID", EmitDefaultValue=false)]
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Product Inventory ID</para>
		/// </summary>
		[DataMember(Name="ProductInventoryID", EmitDefaultValue=false)]
		public StringValue? ProductInventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Product Manager ID</para>
		/// </summary>
		[DataMember(Name="ProductManagerID", EmitDefaultValue=false)]
		public StringValue? ProductManagerID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductSubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Product Subitem</para>
		/// </summary>
		[DataMember(Name="ProductSubitem", EmitDefaultValue=false)]
		public StringValue? ProductSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Promise Date</para>
		/// </summary>
		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Record ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// Plan type related to the RefOrdertype and RefOrderNbr
		/// <para>DAC Field Name: RefType</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Reference Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="ReferenceType", EmitDefaultValue=false)]
		public StringValue? ReferenceType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Related Document</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentRefNbr</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Related Parent Document</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="RelatedParentDocument", EmitDefaultValue=false)]
		public StringValue? RelatedParentDocument { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductRefNbr</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Related Product Document</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="RelatedProductDocument", EmitDefaultValue=false)]
		public StringValue? RelatedProductDocument { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: SD Flag</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="SDFlag", EmitDefaultValue=false)]
		public StringValue? SDFlag { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// Replenishment source
		/// <para>DAC Field Name: ReplenishmentSource</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// Transfer Warehouse ID
		/// <para>DAC Field Name: TransferSiteID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Transfer Warehouse</para>
		/// </summary>
		[DataMember(Name="TransferWarehouse", EmitDefaultValue=false)]
		public StringValue? TransferWarehouse { get; set; }

		/// <summary>
		/// Planning Type
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}