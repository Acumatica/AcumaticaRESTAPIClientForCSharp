using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM408000</c> in the Acumatica ERP
	/// <para>Key Fields: BOMID, Revision, Warehouse</para>
	/// </summary>
	public class CostRollHistory : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The ID of the bill of material that was rolled up.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// The current cost, which is displayed on the Item Warehouse Details (IN204500) form, for the items that use the standard cost valuation method.
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Current Cost</para>
		/// </summary>
		public DecimalValue? CurrentCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__Status</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		public StringValue? CurrentStatus { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC Field Name: CreatedDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Created Date Time</para>
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// Is the given BOM a default BOM
		/// <para>DAC Field Name: IsDefaultBom</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Default BOM</para>
		/// </summary>
		public BooleanValue? DefaultBOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__Descr</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The calculated total cost of setup hours multiplied by the standard rates of the work center for the lot size.
		/// <para>DAC Field Name: FLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Fixed Labor</para>
		/// </summary>
		public DecimalValue? FixedLabor { get; set; }

		/// <summary>
		/// The total setup time for the level.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Fixed Labor Time</para>
		/// </summary>
		public StringValue? FixedLaborTime { get; set; }

		/// <summary>
		/// The total cost of fixed overhead for the lot size.
		/// <para>DAC Field Name: FOvdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Fixed Overhead</para>
		/// </summary>
		public DecimalValue? FixedOverhead { get; set; }

		/// <summary>
		/// The stock item for the BOM ID.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The item class of the stock item.
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// <para>DAC Field Name: LastModifiedDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Last Updated Date Time</para>
		/// </summary>
		public DateTimeValue? LastUpdatedDateTime { get; set; }

		/// <summary>
		/// BOM Level based on the entered cost roll filter criteria (not max low level).This field is important to the order of processing cost roll boms. Highest value (lowest level) are calculated first
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		public IntValue? Level { get; set; }

		/// <summary>
		/// The lot size that is used to allocate the fixed cost elements.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Lot Size</para>
		/// </summary>
		public DecimalValue? LotSize { get; set; }

		/// <summary>
		/// The total cost of machine hours multiplied by the machine per hour rate for the lot size.
		/// <para>DAC Field Name: MachCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		public DecimalValue? Machine { get; set; }

		/// <summary>
		/// The total machine time for the level based on the minimum, maximum, and lot size values.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Machine Time</para>
		/// </summary>
		public StringValue? MachineTime { get; set; }

		/// <summary>
		/// The total level cost of all subassemblies.
		/// <para>DAC Field Name: MatlManufacturedCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Manufactured Material</para>
		/// </summary>
		public DecimalValue? ManufacturedMaterial { get; set; }

		/// <summary>
		/// The total cost of the BOM materials.
		/// <para>DAC Field Name: MatlCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		public DecimalValue? Material { get; set; }

		/// <summary>
		/// Indicates if the record was processed using Multi level
		/// <para>DAC Field Name: MultiLevelProcess</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Multi Level</para>
		/// </summary>
		public BooleanValue? MultiLevel { get; set; }

		/// <summary>
		/// The pending cost, which is displayed on the Item Warehouse Details (IN204500) form, for the items that use the standard cost valuation method.
		/// <para>DAC Field Name: PendingStdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Pending Cost</para>
		/// </summary>
		public DecimalValue? PendingCost { get; set; }

		/// <summary>
		/// The total level cost of all purchased items.
		/// <para>DAC Field Name: MatlNonManufacturedCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Purchase Material</para>
		/// </summary>
		public DecimalValue? PurchaseMaterial { get; set; }

		/// <summary>
		/// The reference materials that have the Subcontract material type and the Vendor Supplied subcontract source.
		/// <para>DAC Field Name: ReferenceMaterialCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Ref. Material</para>
		/// </summary>
		public DecimalValue? RefMaterial { get; set; }

		/// <summary>
		/// The revision of the bill of material that is specified in BOMID.
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Revision { get; set; }

		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// The cost of materials with the Subcontract material type and the Purchase or Ship to Vendor subcontract source.
		/// <para>DAC Field Name: SubcontractMaterialCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		public DecimalValue? Subcontract { get; set; }

		/// <summary>
		/// The subitem of the inventory item
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The total cost of tooling for the lot size.
		/// <para>DAC Field Name: ToolCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		public DecimalValue? Tools { get; set; }

		/// <summary>
		/// The calculated unit cost that will update the pending cost when the update pending process runs.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// The calculated total cost of labor multiplied by the standard rates of the work center for the lot size.
		/// <para>DAC Field Name: VLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Variable Labor</para>
		/// </summary>
		public DecimalValue? VariableLabor { get; set; }

		/// <summary>
		/// The total labor run time for the level based on the minimum, maximum, and lot size values.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Variable Labor Time</para>
		/// </summary>
		public StringValue? VariableLaborTime { get; set; }

		/// <summary>
		/// The total cost of variable overheads for the lot size.
		/// <para>DAC Field Name: VOvdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Variable Overhead</para>
		/// </summary>
		public DecimalValue? VariableOverhead { get; set; }

		/// <summary>
		/// The warehouse for the BOM ID.
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// Key Field
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
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}