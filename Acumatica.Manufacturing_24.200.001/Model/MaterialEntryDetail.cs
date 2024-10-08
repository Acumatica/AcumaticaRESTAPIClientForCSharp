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
	public class MaterialEntryDetail : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<MaterialEntryDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// DAC Field Name: IsByproduct 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: By-product 
		/// </summary>
		[DataMember(Name="Byproduct", EmitDefaultValue=false)]
		public BooleanValue? Byproduct { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryID_description 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: ExpireDate 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// DAC Field Name: TranAmt 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Ext. Cost 
		/// </summary>
		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		/// <summary>
		/// DAC Field Name: GLLineNbr 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: GL Batch Line Nbr 
		/// </summary>
		[DataMember(Name="GLBatchLineNbr", EmitDefaultValue=false)]
		public IntValue? GLBatchLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: GLBatNbr 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: GL Batch Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="GLBatchNbr", EmitDefaultValue=false)]
		public StringValue? GLBatchNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: IN Doc Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="INDocType", EmitDefaultValue=false)]
		public StringValue? INDocType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: IN Line Nbr 
		/// </summary>
		[DataMember(Name="INLineNbr", EmitDefaultValue=false)]
		public IntValue? INLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: INBatNbr 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: IN Ref Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="INRefNbr", EmitDefaultValue=false)]
		public StringValue? INRefNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC Field Name: MatlLineId 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Material Line ID 
		/// </summary>
		[DataMember(Name="MaterialLineID", EmitDefaultValue=false)]
		public IntValue? MaterialLineID { get; set; }

		/// <summary>
		/// DAC Field Name: OperationID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Operation ID 
		/// </summary>
		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Parent Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="ParentLotSerialNbr", EmitDefaultValue=false)]
		public StringValue? ParentLotSerialNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// A brief description of the transaction.
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AM.AMBatch 
		/// Display Name: Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="TranDescription", EmitDefaultValue=false)]
		public StringValue? TranDescription { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}