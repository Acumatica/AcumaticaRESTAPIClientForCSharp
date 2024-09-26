using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM408000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CostRollHistory : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMID 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrentCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AMBomItem__Status 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrentStatus", EmitDefaultValue=false)]
		public StringValue? CurrentStatus { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsDefaultBom 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultBOM", EmitDefaultValue=false)]
		public BooleanValue? DefaultBOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AMBomItem__Descr 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FLaborCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixedLabor", EmitDefaultValue=false)]
		public DecimalValue? FixedLabor { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FixedLaborTime 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixedLaborTime", EmitDefaultValue=false)]
		public StringValue? FixedLaborTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FOvdCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixedOverhead", EmitDefaultValue=false)]
		public DecimalValue? FixedOverhead { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
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
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastModifiedDateTime 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastUpdatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastUpdatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Level 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public IntValue? Level { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LotSize 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LotSize", EmitDefaultValue=false)]
		public DecimalValue? LotSize { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Machine", EmitDefaultValue=false)]
		public DecimalValue? Machine { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachineTime 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public StringValue? MachineTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MatlManufacturedCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ManufacturedMaterial", EmitDefaultValue=false)]
		public DecimalValue? ManufacturedMaterial { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MatlCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Material", EmitDefaultValue=false)]
		public DecimalValue? Material { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MultiLevelProcess 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MultiLevel", EmitDefaultValue=false)]
		public BooleanValue? MultiLevel { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PendingStdCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PendingCost", EmitDefaultValue=false)]
		public DecimalValue? PendingCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MatlNonManufacturedCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchaseMaterial", EmitDefaultValue=false)]
		public DecimalValue? PurchaseMaterial { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReferenceMaterialCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RefMaterial", EmitDefaultValue=false)]
		public DecimalValue? RefMaterial { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubcontractMaterialCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subcontract", EmitDefaultValue=false)]
		public DecimalValue? Subcontract { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ToolCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public DecimalValue? Tools { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnitCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VLaborCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VariableLabor", EmitDefaultValue=false)]
		public DecimalValue? VariableLabor { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VariableLaborTime 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VariableLaborTime", EmitDefaultValue=false)]
		public StringValue? VariableLaborTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VOvdCost 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VariableOverhead", EmitDefaultValue=false)]
		public DecimalValue? VariableOverhead { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMBomCostHistory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}