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
	public class TransferOrderDetail : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<TransferOrderDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

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
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="FromLocationID", EmitDefaultValue=false)]
		public StringValue? FromLocationID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Line Number 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

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
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: Reason Code 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

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
		/// Display Name: To Location ID 
		/// </summary>
		[DataMember(Name="ToLocationID", EmitDefaultValue=false)]
		public StringValue? ToLocationID { get; set; }

		/// <summary>
		/// DAC Field Name: ToCostCodeID 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: To Cost Code 
		/// </summary>
		[DataMember(Name="ToCostCode", EmitDefaultValue=false)]
		public StringValue? ToCostCode { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: To Cost Layer Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ToCostLayerType", EmitDefaultValue=false)]
		public StringValue? ToCostLayerType { get; set; }

		/// <summary>
		/// DAC Field Name: ToProjectID 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: To Project 
		/// </summary>
		[DataMember(Name="ToProject", EmitDefaultValue=false)]
		public StringValue? ToProject { get; set; }

		/// <summary>
		/// DAC Field Name: ToTaskID 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: To Project Task 
		/// </summary>
		[DataMember(Name="ToProjectTask", EmitDefaultValue=false)]
		public StringValue? ToProjectTask { get; set; }

		/// <summary>
		/// DAC Field Name: ToSpecialOrderCostCenterID 
		/// DAC: PX.Objects.IN.INTran 
		/// Display Name: To Special Order Nbr. 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="ToSpecialOrderNbr", EmitDefaultValue=false)]
		public StringValue? ToSpecialOrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INTran 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}