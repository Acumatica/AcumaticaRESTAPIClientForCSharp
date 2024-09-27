using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class InventoryReceiptDetail : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<InventoryReceiptDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Cost Layer Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="CostLayerType", EmitDefaultValue=false)]
		public StringValue? CostLayerType { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.IN.INRegister 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: ExpireDate 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// DAC Field Name: TranCost 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Ext. Cost 
		/// </summary>
		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LineNumber", EmitDefaultValue=false)]
		public IntValue? LineNumber { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.IN.INTran 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: PO Receipt Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="POReceiptNbr", EmitDefaultValue=false)]
		public StringValue? POReceiptNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.IN.INTran 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Quantity 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// DAC Field Name: SpecialOrderCostCenterID 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Special Order Nbr. 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="SpecialOrderNbr", EmitDefaultValue=false)]
		public StringValue? SpecialOrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.IN.INTran 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Warehouse 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

	}
}