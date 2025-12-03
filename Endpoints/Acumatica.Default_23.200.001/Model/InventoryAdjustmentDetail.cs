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
	public class InventoryAdjustmentDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>Display Name: Branch</para>
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Cost Layer Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="CostLayerType", EmitDefaultValue=false)]
		public StringValue? CostLayerType { get; set; }

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
		/// <para>DAC Field Name: TranCost</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Ext. Cost</para>
		/// </summary>
		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue? ExtendedCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

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
		/// <para>DAC Field Name: OrigRefNbr</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Receipt Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ReceiptNbr", EmitDefaultValue=false)]
		public StringValue? ReceiptNbr { get; set; }

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
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

	}
}