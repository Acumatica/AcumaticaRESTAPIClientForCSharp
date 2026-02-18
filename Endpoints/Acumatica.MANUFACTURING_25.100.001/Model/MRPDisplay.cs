using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM400000</c> in the Acumatica ERP
	/// <para>Key Fields: RecordID</para>
	/// </summary>
	public class MRPDisplay : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Action Date</para>
		/// </summary>
		public DateTimeValue? ActionDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Action Lead Time</para>
		/// </summary>
		public IntValue? ActionLeadTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Base Qty.</para>
		/// </summary>
		public DecimalValue? BaseQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Base UOM</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? BaseUOM { get; set; }

		/// <summary>
		/// BOM ID - ID of Bill of materials record
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// Bill of material Revision ID
		/// <para>DAC Field Name: BOMRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: BOM Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_descr</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC Field Name: CreatedDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Inventory Planning Date</para>
		/// </summary>
		public DateTimeValue? MRPDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Parent Inventory ID</para>
		/// </summary>
		public StringValue? ParentInventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentSubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Parent Subitem</para>
		/// </summary>
		public StringValue? ParentSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Preferred Vendor ID</para>
		/// </summary>
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Product Inventory ID</para>
		/// </summary>
		public StringValue? ProductInventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Product Manager ID</para>
		/// </summary>
		public StringValue? ProductManagerID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductSubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Product Subitem</para>
		/// </summary>
		public StringValue? ProductSubitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Promise Date</para>
		/// </summary>
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Record ID</para>
		/// Key Field
		/// </summary>
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// Plan type related to the RefOrdertype and RefOrderNbr
		/// <para>DAC Field Name: RefType</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Reference Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? ReferenceType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Related Document</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? RelatedDocument { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentRefNbr</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Related Parent Document</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? RelatedParentDocument { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductRefNbr</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Related Product Document</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? RelatedProductDocument { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: SD Flag</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? SDFlag { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// </summary>
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// Replenishment source
		/// <para>DAC Field Name: ReplenishmentSource</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Source { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// Transfer Warehouse ID
		/// <para>DAC Field Name: TransferSiteID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>Display Name: Transfer Warehouse</para>
		/// </summary>
		public StringValue? TransferWarehouse { get; set; }

		/// <summary>
		/// Planning Type
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		public StringValue? VendorName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMRPDetail</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}