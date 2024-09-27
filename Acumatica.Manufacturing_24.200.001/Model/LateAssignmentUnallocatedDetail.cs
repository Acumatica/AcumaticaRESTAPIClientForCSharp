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
	public class LateAssignmentUnallocatedDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMProdMatlLotSerialAssigned 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue? LineID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// Key Field
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		[DataMember(Name="ParentLotSerialNbr", EmitDefaultValue=false)]
		public StringValue? ParentLotSerialNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMProdItemSplitPreassign 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdMatlLotSerialUnassigned 
		/// Display Name: Qty. Required 
		/// </summary>
		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue? QtyRequired { get; set; }

		/// <summary>
		/// DAC Field Name: QtyToAllocate 
		/// DAC: PX.Objects.AM.AMProdMatlLotSerialUnassigned 
		/// Display Name: Qty. to Allocate 
		/// </summary>
		[DataMember(Name="QtytoAllocate", EmitDefaultValue=false)]
		public DecimalValue? QtytoAllocate { get; set; }

		/// <summary>
		/// DAC Field Name: QtyIssued 
		/// DAC: PX.Objects.AM.AMProdMatlLotSerialAssigned 
		/// Display Name: Qty. Allocated 
		/// </summary>
		[DataMember(Name="QtyUnallocated", EmitDefaultValue=false)]
		public DecimalValue? QtyUnallocated { get; set; }

		/// <summary>
		/// DAC Field Name: BaseUnit 
		/// DAC: PX.Objects.AM.AMProdMatlLotSerialAssigned 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}