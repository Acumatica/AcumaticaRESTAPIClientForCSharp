using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class CostRollResult : Entity
	{

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// The current standard cost if the item has the Standard valuation method.
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Current Standard Cost</para>
		/// </summary>
		public DecimalValue? CurrentStandardCost { get; set; }

		/// <summary>
		/// Is the given BOM a default BOM
		/// <para>DAC Field Name: IsDefaultBom</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Default BOM</para>
		/// </summary>
		public BooleanValue? DefaultBOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__Descr</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The fixed labor cost.
		/// <para>DAC Field Name: FLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Fixed Labor</para>
		/// </summary>
		public DecimalValue? FixedLabor { get; set; }

		/// <summary>
		/// The total setup time for all operations of the BOM.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Fixed Labor Time</para>
		/// </summary>
		public StringValue? FixedLaborTime { get; set; }

		/// <summary>
		/// The total cost of fixed overhead.
		/// <para>DAC Field Name: FOvdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Fixed Overhead</para>
		/// </summary>
		public DecimalValue? FixedOverhead { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// BOM Level based on the entered cost roll filter criteria (not max low level).This field is important to the order of processing cost roll boms. Highest value (lowest level) are calculated first
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		public IntValue? Level { get; set; }

		/// <summary>
		/// The lot size, which the system uses to apportion fixed costs, such as fixed labor costs and fixed overhead costs.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Lot Size</para>
		/// </summary>
		public DecimalValue? LotSize { get; set; }

		/// <summary>
		/// The total machine cost.
		/// <para>DAC Field Name: MachCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		public DecimalValue? Machine { get; set; }

		/// <summary>
		/// The total machine time for all operations of the BOM.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Machine Time</para>
		/// </summary>
		public StringValue? MachineTime { get; set; }

		/// <summary>
		/// The manufactured material.
		/// <para>DAC Field Name: MatlManufacturedCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Manufactured Material</para>
		/// </summary>
		public DecimalValue? ManufacturedMaterial { get; set; }

		/// <summary>
		/// The total cost of the BOM materials.
		/// <para>DAC Field Name: MatlCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		public DecimalValue? Material { get; set; }

		/// <summary>
		/// Indicates if the record was processed using Multi level
		/// <para>DAC Field Name: MultiLevelProcess</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Multi Level</para>
		/// </summary>
		public BooleanValue? MultiLevel { get; set; }

		/// <summary>
		/// The pending cost if the item has the Standard valuation method.
		/// <para>DAC Field Name: PendingStdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Pending Standard Cost</para>
		/// </summary>
		public DecimalValue? PendingStandardCost { get; set; }

		/// <summary>
		/// The purchase material.
		/// <para>DAC Field Name: MatlNonManufacturedCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Purchase Material</para>
		/// </summary>
		public DecimalValue? PurchaseMaterial { get; set; }

		/// <summary>
		/// The cost of materials that have the Subcontract type and the Vendor Supplied subcontract source.
		/// <para>DAC Field Name: ReferenceMaterialCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Ref. Material</para>
		/// </summary>
		public DecimalValue? RefMaterial { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? Revision { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMBomItem__Status</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// The cost of materials with the Subcontract type and the Purchase or Ship to Vendor subcontract source.
		/// <para>DAC Field Name: SubcontractMaterialCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		public DecimalValue? Subcontract { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The total cost of tools.
		/// <para>DAC Field Name: ToolCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// </summary>
		public DecimalValue? Tools { get; set; }

		/// <summary>
		/// The unit cost of the item, which has been calculated during the cost rollup process.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		public GuidValue? UserID { get; set; }

		/// <summary>
		/// The variable labor cost.
		/// <para>DAC Field Name: VLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Variable Labor</para>
		/// </summary>
		public DecimalValue? VariableLabor { get; set; }

		/// <summary>
		/// The total run time for all operations of the BOM.
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Variable Labor Time</para>
		/// </summary>
		public StringValue? VariableLaborTime { get; set; }

		/// <summary>
		/// The total cost of variable overhead.
		/// <para>DAC Field Name: VOvdCost</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// <para>Display Name: Variable Overhead</para>
		/// </summary>
		public DecimalValue? VariableOverhead { get; set; }

		/// <summary>
		/// The warehouse assigned to the BOM.
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMBomCost</para>
		/// Key Field
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}