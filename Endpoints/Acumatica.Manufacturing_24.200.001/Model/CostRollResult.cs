using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class CostRollResult : Entity
	{

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// The current standard cost if the item has the Standard valuation method.
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Current Standard Cost</para>
		/// </summary>
		[DataMember(Name="CurrentStandardCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentStandardCost { get; set; }

		/// <summary>
		/// Is the given BOM a default BOM
		/// <para>DAC Field Name: IsDefaultBom</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Default BOM</para>
		/// </summary>
		[DataMember(Name="DefaultBOM", EmitDefaultValue=false)]
		public BooleanValue? DefaultBOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__Descr</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The fixed labor cost.
		/// <para>DAC Field Name: FLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Fixed Labor</para>
		/// </summary>
		[DataMember(Name="FixedLabor", EmitDefaultValue=false)]
		public DecimalValue? FixedLabor { get; set; }

		/// <summary>
		/// The total setup time for all operations of the BOM.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Fixed Labor Time</para>
		/// </summary>
		[DataMember(Name="FixedLaborTime", EmitDefaultValue=false)]
		public StringValue? FixedLaborTime { get; set; }

		/// <summary>
		/// The total cost of fixed overhead.
		/// <para>DAC Field Name: FOvdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Fixed Overhead</para>
		/// </summary>
		[DataMember(Name="FixedOverhead", EmitDefaultValue=false)]
		public DecimalValue? FixedOverhead { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// BOM Level based on the entered cost roll filter criteria (not max low level).This field is important to the order of processing cost roll boms. Highest value (lowest level) are calculated first
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public IntValue? Level { get; set; }

		/// <summary>
		/// The lot size, which the system uses to apportion fixed costs, such as fixed labor costs and fixed overhead costs.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Lot Size</para>
		/// </summary>
		[DataMember(Name="LotSize", EmitDefaultValue=false)]
		public DecimalValue? LotSize { get; set; }

		/// <summary>
		/// The total machine cost.
		/// <para>DAC Field Name: MachCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		[DataMember(Name="Machine", EmitDefaultValue=false)]
		public DecimalValue? Machine { get; set; }

		/// <summary>
		/// The total machine time for all operations of the BOM.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Machine Time</para>
		/// </summary>
		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public StringValue? MachineTime { get; set; }

		/// <summary>
		/// The manufactured material.
		/// <para>DAC Field Name: MatlManufacturedCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Manufactured Material</para>
		/// </summary>
		[DataMember(Name="ManufacturedMaterial", EmitDefaultValue=false)]
		public DecimalValue? ManufacturedMaterial { get; set; }

		/// <summary>
		/// The total cost of the BOM materials.
		/// <para>DAC Field Name: MatlCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		[DataMember(Name="Material", EmitDefaultValue=false)]
		public DecimalValue? Material { get; set; }

		/// <summary>
		/// Indicates if the record was processed using Multi level
		/// <para>DAC Field Name: MultiLevelProcess</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Multi Level</para>
		/// </summary>
		[DataMember(Name="MultiLevel", EmitDefaultValue=false)]
		public BooleanValue? MultiLevel { get; set; }

		/// <summary>
		/// The pending cost if the item has the Standard valuation method.
		/// <para>DAC Field Name: PendingStdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Pending Standard Cost</para>
		/// </summary>
		[DataMember(Name="PendingStandardCost", EmitDefaultValue=false)]
		public DecimalValue? PendingStandardCost { get; set; }

		/// <summary>
		/// The purchase material.
		/// <para>DAC Field Name: MatlNonManufacturedCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Purchase Material</para>
		/// </summary>
		[DataMember(Name="PurchaseMaterial", EmitDefaultValue=false)]
		public DecimalValue? PurchaseMaterial { get; set; }

		/// <summary>
		/// The cost of materials that have the Subcontract type and the Vendor Supplied subcontract source.
		/// <para>DAC Field Name: ReferenceMaterialCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Ref. Material</para>
		/// </summary>
		[DataMember(Name="RefMaterial", EmitDefaultValue=false)]
		public DecimalValue? RefMaterial { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__Status</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The cost of materials with the Subcontract type and the Purchase or Ship to Vendor subcontract source.
		/// <para>DAC Field Name: SubcontractMaterialCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		[DataMember(Name="Subcontract", EmitDefaultValue=false)]
		public DecimalValue? Subcontract { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The total cost of tools.
		/// <para>DAC Field Name: ToolCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public DecimalValue? Tools { get; set; }

		/// <summary>
		/// The unit cost of the item, which has been calculated during the cost rollup process.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		[DataMember(Name="UserID", EmitDefaultValue=false)]
		public GuidValue? UserID { get; set; }

		/// <summary>
		/// The variable labor cost.
		/// <para>DAC Field Name: VLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Variable Labor</para>
		/// </summary>
		[DataMember(Name="VariableLabor", EmitDefaultValue=false)]
		public DecimalValue? VariableLabor { get; set; }

		/// <summary>
		/// The total run time for all operations of the BOM.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Variable Labor Time</para>
		/// </summary>
		[DataMember(Name="VariableLaborTime", EmitDefaultValue=false)]
		public StringValue? VariableLaborTime { get; set; }

		/// <summary>
		/// The total cost of variable overhead.
		/// <para>DAC Field Name: VOvdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Variable Overhead</para>
		/// </summary>
		[DataMember(Name="VariableOverhead", EmitDefaultValue=false)]
		public DecimalValue? VariableOverhead { get; set; }

		/// <summary>
		/// The warehouse assigned to the BOM.
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}