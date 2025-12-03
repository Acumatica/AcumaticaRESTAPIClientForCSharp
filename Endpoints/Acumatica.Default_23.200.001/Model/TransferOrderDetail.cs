using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class TransferOrderDetail : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<TransferOrderDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="FromLocationID", EmitDefaultValue=false)]
		public StringValue? FromLocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Line Number</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SpecialOrderCostCenterID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Special Order Nbr.</para>
		/// </summary>
		[DataMember(Name="SpecialOrderNbr", EmitDefaultValue=false)]
		public StringValue? SpecialOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Location ID</para>
		/// </summary>
		[DataMember(Name="ToLocationID", EmitDefaultValue=false)]
		public StringValue? ToLocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ToCostCodeID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Cost Code</para>
		/// </summary>
		[DataMember(Name="ToCostCode", EmitDefaultValue=false)]
		public StringValue? ToCostCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Cost Layer Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="ToCostLayerType", EmitDefaultValue=false)]
		public StringValue? ToCostLayerType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ToProjectID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Project</para>
		/// </summary>
		[DataMember(Name="ToProject", EmitDefaultValue=false)]
		public StringValue? ToProject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ToTaskID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Project Task</para>
		/// </summary>
		[DataMember(Name="ToProjectTask", EmitDefaultValue=false)]
		public StringValue? ToProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ToSpecialOrderCostCenterID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Special Order Nbr.</para>
		/// </summary>
		[DataMember(Name="ToSpecialOrderNbr", EmitDefaultValue=false)]
		public StringValue? ToSpecialOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}