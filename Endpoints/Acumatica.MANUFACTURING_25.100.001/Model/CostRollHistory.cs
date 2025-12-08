using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM408000</c> in the Acumatica ERP
	/// <para>Key Fields: BOMID, Revision, Warehouse</para>
	/// </summary>
	[DataContract]
	public class CostRollHistory : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The ID of the bill of material that was rolled up.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// The current cost, which is displayed on the Item Warehouse Details (IN204500) form, for the items that use the standard cost valuation method.
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Current Cost</para>
		/// </summary>
		[DataMember(Name="CurrentCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__Status</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		[DataMember(Name="CurrentStatus", EmitDefaultValue=false)]
		public StringValue? CurrentStatus { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC Field Name: CreatedDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Created Date Time</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// Is the given BOM a default BOM
		/// <para>DAC Field Name: IsDefaultBom</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Default BOM</para>
		/// </summary>
		[DataMember(Name="DefaultBOM", EmitDefaultValue=false)]
		public BooleanValue? DefaultBOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__Descr</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The calculated total cost of setup hours multiplied by the standard rates of the work center for the lot size.
		/// <para>DAC Field Name: FLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Fixed Labor</para>
		/// </summary>
		[DataMember(Name="FixedLabor", EmitDefaultValue=false)]
		public DecimalValue? FixedLabor { get; set; }

		/// <summary>
		/// The total setup time for the level.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Fixed Labor Time</para>
		/// </summary>
		[DataMember(Name="FixedLaborTime", EmitDefaultValue=false)]
		public StringValue? FixedLaborTime { get; set; }

		/// <summary>
		/// The total cost of fixed overhead for the lot size.
		/// <para>DAC Field Name: FOvdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Fixed Overhead</para>
		/// </summary>
		[DataMember(Name="FixedOverhead", EmitDefaultValue=false)]
		public DecimalValue? FixedOverhead { get; set; }

		/// <summary>
		/// The stock item for the BOM ID.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The item class of the stock item.
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// <para>DAC Field Name: LastModifiedDateTime</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Last Updated Date Time</para>
		/// </summary>
		[DataMember(Name="LastUpdatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastUpdatedDateTime { get; set; }

		/// <summary>
		/// BOM Level based on the entered cost roll filter criteria (not max low level).This field is important to the order of processing cost roll boms. Highest value (lowest level) are calculated first
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public IntValue? Level { get; set; }

		/// <summary>
		/// The lot size that is used to allocate the fixed cost elements.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Lot Size</para>
		/// </summary>
		[DataMember(Name="LotSize", EmitDefaultValue=false)]
		public DecimalValue? LotSize { get; set; }

		/// <summary>
		/// The total cost of machine hours multiplied by the machine per hour rate for the lot size.
		/// <para>DAC Field Name: MachCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		[DataMember(Name="Machine", EmitDefaultValue=false)]
		public DecimalValue? Machine { get; set; }

		/// <summary>
		/// The total machine time for the level based on the minimum, maximum, and lot size values.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Machine Time</para>
		/// </summary>
		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public StringValue? MachineTime { get; set; }

		/// <summary>
		/// The total level cost of all subassemblies.
		/// <para>DAC Field Name: MatlManufacturedCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Manufactured Material</para>
		/// </summary>
		[DataMember(Name="ManufacturedMaterial", EmitDefaultValue=false)]
		public DecimalValue? ManufacturedMaterial { get; set; }

		/// <summary>
		/// The total cost of the BOM materials.
		/// <para>DAC Field Name: MatlCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		[DataMember(Name="Material", EmitDefaultValue=false)]
		public DecimalValue? Material { get; set; }

		/// <summary>
		/// Indicates if the record was processed using Multi level
		/// <para>DAC Field Name: MultiLevelProcess</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Multi Level</para>
		/// </summary>
		[DataMember(Name="MultiLevel", EmitDefaultValue=false)]
		public BooleanValue? MultiLevel { get; set; }

		/// <summary>
		/// The pending cost, which is displayed on the Item Warehouse Details (IN204500) form, for the items that use the standard cost valuation method.
		/// <para>DAC Field Name: PendingStdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Pending Cost</para>
		/// </summary>
		[DataMember(Name="PendingCost", EmitDefaultValue=false)]
		public DecimalValue? PendingCost { get; set; }

		/// <summary>
		/// The total level cost of all purchased items.
		/// <para>DAC Field Name: MatlNonManufacturedCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Purchase Material</para>
		/// </summary>
		[DataMember(Name="PurchaseMaterial", EmitDefaultValue=false)]
		public DecimalValue? PurchaseMaterial { get; set; }

		/// <summary>
		/// The reference materials that have the Subcontract material type and the Vendor Supplied subcontract source.
		/// <para>DAC Field Name: ReferenceMaterialCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Ref. Material</para>
		/// </summary>
		[DataMember(Name="RefMaterial", EmitDefaultValue=false)]
		public DecimalValue? RefMaterial { get; set; }

		/// <summary>
		/// The revision of the bill of material that is specified in BOMID.
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// The cost of materials with the Subcontract material type and the Purchase or Ship to Vendor subcontract source.
		/// <para>DAC Field Name: SubcontractMaterialCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		[DataMember(Name="Subcontract", EmitDefaultValue=false)]
		public DecimalValue? Subcontract { get; set; }

		/// <summary>
		/// The subitem of the inventory item
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The total cost of tooling for the lot size.
		/// <para>DAC Field Name: ToolCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// </summary>
		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public DecimalValue? Tools { get; set; }

		/// <summary>
		/// The calculated unit cost that will update the pending cost when the update pending process runs.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// The calculated total cost of labor multiplied by the standard rates of the work center for the lot size.
		/// <para>DAC Field Name: VLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Variable Labor</para>
		/// </summary>
		[DataMember(Name="VariableLabor", EmitDefaultValue=false)]
		public DecimalValue? VariableLabor { get; set; }

		/// <summary>
		/// The total labor run time for the level based on the minimum, maximum, and lot size values.
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Variable Labor Time</para>
		/// </summary>
		[DataMember(Name="VariableLaborTime", EmitDefaultValue=false)]
		public StringValue? VariableLaborTime { get; set; }

		/// <summary>
		/// The total cost of variable overheads for the lot size.
		/// <para>DAC Field Name: VOvdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// <para>Display Name: Variable Overhead</para>
		/// </summary>
		[DataMember(Name="VariableOverhead", EmitDefaultValue=false)]
		public DecimalValue? VariableOverhead { get; set; }

		/// <summary>
		/// The warehouse for the BOM ID.
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMBomCostHistory</para>
		/// Key Field
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
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}