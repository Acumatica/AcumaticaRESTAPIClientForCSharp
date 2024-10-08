using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class CostRollResult : Entity
	{

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// The current standard cost if the item has the Standard valuation method.
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Current Standard Cost 
		/// </summary>
		[DataMember(Name="CurrentStandardCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentStandardCost { get; set; }

		/// <summary>
		/// Is the given BOM a default BOM
		/// DAC Field Name: IsDefaultBom 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Default BOM 
		/// </summary>
		[DataMember(Name="DefaultBOM", EmitDefaultValue=false)]
		public BooleanValue? DefaultBOM { get; set; }

		/// <summary>
		/// DAC Field Name: AMBomItem__Descr 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The fixed labor cost.
		/// DAC Field Name: FLaborCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Fixed Labor 
		/// </summary>
		[DataMember(Name="FixedLabor", EmitDefaultValue=false)]
		public DecimalValue? FixedLabor { get; set; }

		/// <summary>
		/// The total setup time for all operations of the BOM.
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Fixed Labor Time 
		/// </summary>
		[DataMember(Name="FixedLaborTime", EmitDefaultValue=false)]
		public StringValue? FixedLaborTime { get; set; }

		/// <summary>
		/// The total cost of fixed overhead.
		/// DAC Field Name: FOvdCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Fixed Overhead 
		/// </summary>
		[DataMember(Name="FixedOverhead", EmitDefaultValue=false)]
		public DecimalValue? FixedOverhead { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassID 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// BOM Level based on the entered cost roll filter criteria (not max low level).This field is important to the order of processing cost roll boms. Highest value (lowest level) are calculated first
		/// DAC: PX.Objects.AM.AMBomCost 
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public IntValue? Level { get; set; }

		/// <summary>
		/// The lot size, which the system uses to apportion fixed costs, such as fixed labor costs and fixed overhead costs.
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Lot Size 
		/// </summary>
		[DataMember(Name="LotSize", EmitDefaultValue=false)]
		public DecimalValue? LotSize { get; set; }

		/// <summary>
		/// The total machine cost.
		/// DAC Field Name: MachCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// </summary>
		[DataMember(Name="Machine", EmitDefaultValue=false)]
		public DecimalValue? Machine { get; set; }

		/// <summary>
		/// The total machine time for all operations of the BOM.
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Machine Time 
		/// </summary>
		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public StringValue? MachineTime { get; set; }

		/// <summary>
		/// The manufactured material.
		/// DAC Field Name: MatlManufacturedCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Manufactured Material 
		/// </summary>
		[DataMember(Name="ManufacturedMaterial", EmitDefaultValue=false)]
		public DecimalValue? ManufacturedMaterial { get; set; }

		/// <summary>
		/// The total cost of the BOM materials.
		/// DAC Field Name: MatlCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// </summary>
		[DataMember(Name="Material", EmitDefaultValue=false)]
		public DecimalValue? Material { get; set; }

		/// <summary>
		/// Indicates if the record was processed using Multi level
		/// DAC Field Name: MultiLevelProcess 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Multi Level 
		/// </summary>
		[DataMember(Name="MultiLevel", EmitDefaultValue=false)]
		public BooleanValue? MultiLevel { get; set; }

		/// <summary>
		/// The pending cost if the item has the Standard valuation method.
		/// DAC Field Name: PendingStdCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Pending Standard Cost 
		/// </summary>
		[DataMember(Name="PendingStandardCost", EmitDefaultValue=false)]
		public DecimalValue? PendingStandardCost { get; set; }

		/// <summary>
		/// The purchase material.
		/// DAC Field Name: MatlNonManufacturedCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Purchase Material 
		/// </summary>
		[DataMember(Name="PurchaseMaterial", EmitDefaultValue=false)]
		public DecimalValue? PurchaseMaterial { get; set; }

		/// <summary>
		/// The cost of materials that have the Subcontract type and the Vendor Supplied subcontract source.
		/// DAC Field Name: ReferenceMaterialCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Ref. Material 
		/// </summary>
		[DataMember(Name="RefMaterial", EmitDefaultValue=false)]
		public DecimalValue? RefMaterial { get; set; }

		/// <summary>
		/// DAC Field Name: RevisionID 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// DAC: PX.Objects.AM.AMBomCost 
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// DAC Field Name: AMBomItem__Status 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The cost of materials with the Subcontract type and the Purchase or Ship to Vendor subcontract source.
		/// DAC Field Name: SubcontractMaterialCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// </summary>
		[DataMember(Name="Subcontract", EmitDefaultValue=false)]
		public DecimalValue? Subcontract { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The total cost of tools.
		/// DAC Field Name: ToolCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// </summary>
		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public DecimalValue? Tools { get; set; }

		/// <summary>
		/// The unit cost of the item, which has been calculated during the cost rollup process.
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UserID", EmitDefaultValue=false)]
		public GuidValue? UserID { get; set; }

		/// <summary>
		/// The variable labor cost.
		/// DAC Field Name: VLaborCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Variable Labor 
		/// </summary>
		[DataMember(Name="VariableLabor", EmitDefaultValue=false)]
		public DecimalValue? VariableLabor { get; set; }

		/// <summary>
		/// The total run time for all operations of the BOM.
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Variable Labor Time 
		/// </summary>
		[DataMember(Name="VariableLaborTime", EmitDefaultValue=false)]
		public StringValue? VariableLaborTime { get; set; }

		/// <summary>
		/// The total cost of variable overhead.
		/// DAC Field Name: VOvdCost 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// Display Name: Variable Overhead 
		/// </summary>
		[DataMember(Name="VariableOverhead", EmitDefaultValue=false)]
		public DecimalValue? VariableOverhead { get; set; }

		/// <summary>
		/// The warehouse assigned to the BOM.
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMBomCost 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}