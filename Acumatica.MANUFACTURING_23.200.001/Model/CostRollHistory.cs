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
	/// Corresponds to the screen AM408000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CostRollHistory : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The ID of the bill of material that was rolled up.
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// The current cost, which is displayed on the Item Warehouse Details (IN204500) form, for the items that use the standard cost valuation method.
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Current Cost 
		/// </summary>
		[DataMember(Name="CurrentCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentCost { get; set; }

		/// <summary>
		/// DAC Field Name: AMBomItem__Status 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		[DataMember(Name="CurrentStatus", EmitDefaultValue=false)]
		public StringValue? CurrentStatus { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Created Date Time 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// Is the given BOM a default BOM
		/// DAC Field Name: IsDefaultBom 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Default BOM 
		/// </summary>
		[DataMember(Name="DefaultBOM", EmitDefaultValue=false)]
		public BooleanValue? DefaultBOM { get; set; }

		/// <summary>
		/// DAC Field Name: AMBomItem__Descr 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The calculated total cost of setup hours multiplied by the standard rates of the work center for the lot size.
		/// DAC Field Name: FLaborCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Fixed Labor 
		/// </summary>
		[DataMember(Name="FixedLabor", EmitDefaultValue=false)]
		public DecimalValue? FixedLabor { get; set; }

		/// <summary>
		/// The total setup time for the level.
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Fixed Labor Time 
		/// </summary>
		[DataMember(Name="FixedLaborTime", EmitDefaultValue=false)]
		public StringValue? FixedLaborTime { get; set; }

		/// <summary>
		/// The total cost of fixed overhead for the lot size.
		/// DAC Field Name: FOvdCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Fixed Overhead 
		/// </summary>
		[DataMember(Name="FixedOverhead", EmitDefaultValue=false)]
		public DecimalValue? FixedOverhead { get; set; }

		/// <summary>
		/// The stock item for the BOM ID.
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The item class of the stock item.
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Item Class 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// DAC Field Name: LastModifiedDateTime 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Last Updated Date Time 
		/// </summary>
		[DataMember(Name="LastUpdatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastUpdatedDateTime { get; set; }

		/// <summary>
		/// BOM Level based on the entered cost roll filter criteria (not max low level).This field is important to the order of processing cost roll boms. Highest value (lowest level) are calculated first
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public IntValue? Level { get; set; }

		/// <summary>
		/// The lot size that is used to allocate the fixed cost elements.
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Lot Size 
		/// </summary>
		[DataMember(Name="LotSize", EmitDefaultValue=false)]
		public DecimalValue? LotSize { get; set; }

		/// <summary>
		/// The total cost of machine hours multiplied by the machine per hour rate for the lot size.
		/// DAC Field Name: MachCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		[DataMember(Name="Machine", EmitDefaultValue=false)]
		public DecimalValue? Machine { get; set; }

		/// <summary>
		/// The total machine time for the level based on the minimum, maximum, and lot size values.
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Machine Time 
		/// </summary>
		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public StringValue? MachineTime { get; set; }

		/// <summary>
		/// The total level cost of all subassemblies.
		/// DAC Field Name: MatlManufacturedCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Manufactured Material 
		/// </summary>
		[DataMember(Name="ManufacturedMaterial", EmitDefaultValue=false)]
		public DecimalValue? ManufacturedMaterial { get; set; }

		/// <summary>
		/// The total cost of the BOM materials.
		/// DAC Field Name: MatlCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		[DataMember(Name="Material", EmitDefaultValue=false)]
		public DecimalValue? Material { get; set; }

		/// <summary>
		/// Indicates if the record was processed using Multi level
		/// DAC Field Name: MultiLevelProcess 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Multi Level 
		/// </summary>
		[DataMember(Name="MultiLevel", EmitDefaultValue=false)]
		public BooleanValue? MultiLevel { get; set; }

		/// <summary>
		/// The pending cost, which is displayed on the Item Warehouse Details (IN204500) form, for the items that use the standard cost valuation method.
		/// DAC Field Name: PendingStdCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Pending Cost 
		/// </summary>
		[DataMember(Name="PendingCost", EmitDefaultValue=false)]
		public DecimalValue? PendingCost { get; set; }

		/// <summary>
		/// The total level cost of all purchased items.
		/// DAC Field Name: MatlNonManufacturedCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Purchase Material 
		/// </summary>
		[DataMember(Name="PurchaseMaterial", EmitDefaultValue=false)]
		public DecimalValue? PurchaseMaterial { get; set; }

		/// <summary>
		/// The reference materials that have the Subcontract material type and the Vendor Supplied subcontract source.
		/// DAC Field Name: ReferenceMaterialCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Ref. Material 
		/// </summary>
		[DataMember(Name="RefMaterial", EmitDefaultValue=false)]
		public DecimalValue? RefMaterial { get; set; }

		/// <summary>
		/// The revision of the bill of material that is specified in BOMID.
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// The cost of materials with the Subcontract material type and the Purchase or Ship to Vendor subcontract source.
		/// DAC Field Name: SubcontractMaterialCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		[DataMember(Name="Subcontract", EmitDefaultValue=false)]
		public DecimalValue? Subcontract { get; set; }

		/// <summary>
		/// The subitem of the inventory item
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The total cost of tooling for the lot size.
		/// DAC Field Name: ToolCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public DecimalValue? Tools { get; set; }

		/// <summary>
		/// The calculated unit cost that will update the pending cost when the update pending process runs.
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// The calculated total cost of labor multiplied by the standard rates of the work center for the lot size.
		/// DAC Field Name: VLaborCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Variable Labor 
		/// </summary>
		[DataMember(Name="VariableLabor", EmitDefaultValue=false)]
		public DecimalValue? VariableLabor { get; set; }

		/// <summary>
		/// The total labor run time for the level based on the minimum, maximum, and lot size values.
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Variable Labor Time 
		/// </summary>
		[DataMember(Name="VariableLaborTime", EmitDefaultValue=false)]
		public StringValue? VariableLaborTime { get; set; }

		/// <summary>
		/// The total cost of variable overheads for the lot size.
		/// DAC Field Name: VOvdCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// Display Name: Variable Overhead 
		/// </summary>
		[DataMember(Name="VariableOverhead", EmitDefaultValue=false)]
		public DecimalValue? VariableOverhead { get; set; }

		/// <summary>
		/// The warehouse for the BOM ID.
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}