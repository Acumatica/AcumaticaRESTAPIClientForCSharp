using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_18_200_001.Model
{
	[DataContract]
	public class OrderMaterialDetail : Entity_v3
	{

		[DataMember(Name="Backflush", EmitDefaultValue=false)]
		public BooleanValue Backflush { get; set; }

		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue BatchSize { get; set; }

		[DataMember(Name="Byproduct", EmitDefaultValue=false)]
		public BooleanValue Byproduct { get; set; }

		[DataMember(Name="CompBOMEffDate", EmitDefaultValue=false)]
		public DateTimeValue CompBOMEffDate { get; set; }

		[DataMember(Name="CompBOMID", EmitDefaultValue=false)]
		public StringValue CompBOMID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="LineOrder", EmitDefaultValue=false)]
		public IntValue LineOrder { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="MaterialType", EmitDefaultValue=false)]
		public StringValue MaterialType { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue OperationNbr { get; set; }

		[DataMember(Name="PhantomBomID", EmitDefaultValue=false)]
		public StringValue PhantomBomID { get; set; }

		[DataMember(Name="PhantomBOMLineID", EmitDefaultValue=false)]
		public IntValue PhantomBOMLineID { get; set; }

		[DataMember(Name="PhantomBOMOperNbr", EmitDefaultValue=false)]
		public StringValue PhantomBOMOperNbr { get; set; }

		[DataMember(Name="PhantomLevel", EmitDefaultValue=false)]
		public IntValue PhantomLevel { get; set; }

		[DataMember(Name="PhantomMatlLineID", EmitDefaultValue=false)]
		public IntValue PhantomMatlLineID { get; set; }

		[DataMember(Name="PhantomMatlOperNbr", EmitDefaultValue=false)]
		public StringValue PhantomMatlOperNbr { get; set; }

		[DataMember(Name="QtyActual", EmitDefaultValue=false)]
		public DecimalValue QtyActual { get; set; }

		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue QtyRemaining { get; set; }

		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue QtyRequired { get; set; }

		[DataMember(Name="QtyRoundUp", EmitDefaultValue=false)]
		public BooleanValue QtyRoundUp { get; set; }

		[DataMember(Name="ScrapFactor", EmitDefaultValue=false)]
		public DecimalValue ScrapFactor { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="TotalActualCost", EmitDefaultValue=false)]
		public DecimalValue TotalActualCost { get; set; }

		[DataMember(Name="TotalRequired", EmitDefaultValue=false)]
		public DecimalValue TotalRequired { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}