using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CostRollResult : Entity_v4
	{

		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue BOMID { get; set; }

		[DataMember(Name="CurrentStandardCost", EmitDefaultValue=false)]
		public DecimalValue CurrentStandardCost { get; set; }

		[DataMember(Name="DefaultBOM", EmitDefaultValue=false)]
		public BooleanValue DefaultBOM { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="FixedLabor", EmitDefaultValue=false)]
		public DecimalValue FixedLabor { get; set; }

		[DataMember(Name="FixedLaborTime", EmitDefaultValue=false)]
		public StringValue FixedLaborTime { get; set; }

		[DataMember(Name="FixedOverhead", EmitDefaultValue=false)]
		public DecimalValue FixedOverhead { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="Level", EmitDefaultValue=false)]
		public IntValue Level { get; set; }

		[DataMember(Name="LotSize", EmitDefaultValue=false)]
		public DecimalValue LotSize { get; set; }

		[DataMember(Name="Machine", EmitDefaultValue=false)]
		public DecimalValue Machine { get; set; }

		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public StringValue MachineTime { get; set; }

		[DataMember(Name="ManufacturedMaterial", EmitDefaultValue=false)]
		public DecimalValue ManufacturedMaterial { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public DecimalValue Material { get; set; }

		[DataMember(Name="MultiLevel", EmitDefaultValue=false)]
		public BooleanValue MultiLevel { get; set; }

		[DataMember(Name="PendingStandardCost", EmitDefaultValue=false)]
		public DecimalValue PendingStandardCost { get; set; }

		[DataMember(Name="PurchaseMaterial", EmitDefaultValue=false)]
		public DecimalValue PurchaseMaterial { get; set; }

		[DataMember(Name="RefMaterial", EmitDefaultValue=false)]
		public DecimalValue RefMaterial { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Subcontract", EmitDefaultValue=false)]
		public DecimalValue Subcontract { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public DecimalValue Tools { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

		[DataMember(Name="UserID", EmitDefaultValue=false)]
		public GuidValue UserID { get; set; }

		[DataMember(Name="VariableLabor", EmitDefaultValue=false)]
		public DecimalValue VariableLabor { get; set; }

		[DataMember(Name="VariableLaborTime", EmitDefaultValue=false)]
		public StringValue VariableLaborTime { get; set; }

		[DataMember(Name="VariableOverhead", EmitDefaultValue=false)]
		public DecimalValue VariableOverhead { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}