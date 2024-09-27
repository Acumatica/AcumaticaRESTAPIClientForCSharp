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
	public class DisassemblyEntryMaterial : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<DisassemblyEntryMaterialAllocation>? Allocations { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: ExpireDate 
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// DAC Field Name: TranAmt 
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: Ext. Cost 
		/// </summary>
		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		/// <summary>
		/// DAC Field Name: GLLineNbr 
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: GL Batch Line Nbr 
		/// </summary>
		[DataMember(Name="GLBatchLineNbr", EmitDefaultValue=false)]
		public IntValue? GLBatchLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: GLBatNbr 
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: GL Batch Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="GLBatchNbr", EmitDefaultValue=false)]
		public StringValue? GLBatchNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: IN Doc Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="INDocType", EmitDefaultValue=false)]
		public StringValue? INDocType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: IN Line Nbr 
		/// </summary>
		[DataMember(Name="INLineNbr", EmitDefaultValue=false)]
		public IntValue? INLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: INBatNbr 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: IN Ref Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="INRefNbr", EmitDefaultValue=false)]
		public StringValue? INRefNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC Field Name: MatlLineId 
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: Material Line Nbr 
		/// </summary>
		[DataMember(Name="MaterialLineNbr", EmitDefaultValue=false)]
		public IntValue? MaterialLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OperationID 
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: Operation ID 
		/// </summary>
		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue? OperationNbr { get; set; }

		[DataMember(Name="ParentLotSerialNbr", EmitDefaultValue=false)]
		public StringValue? ParentLotSerialNbr { get; set; }

		/// <summary>
		/// DAC Field Name: IsScrap 
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: Qty is Scrap 
		/// </summary>
		[DataMember(Name="QtyisScrap", EmitDefaultValue=false)]
		public BooleanValue? QtyisScrap { get; set; }

		/// <summary>
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// DAC Field Name: ReasonCodeID 
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: Reason Code 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// Display Name: Tran. Type 
		/// SQL Type: nchar(3) 
		/// </summary>
		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue? TranType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleTran 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMDisassembleBatch 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}