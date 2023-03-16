using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class LateAssignmentUnallocatedDetail : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue LineID { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue LotSerialNbr { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue OperationID { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="ParentLotSerialNbr", EmitDefaultValue=false)]
		public StringValue ParentLotSerialNbr { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue ProductionNbr { get; set; }

		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue QtyRequired { get; set; }

		[DataMember(Name="QtytoAllocate", EmitDefaultValue=false)]
		public DecimalValue QtytoAllocate { get; set; }

		[DataMember(Name="QtyUnallocated", EmitDefaultValue=false)]
		public DecimalValue QtyUnallocated { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}