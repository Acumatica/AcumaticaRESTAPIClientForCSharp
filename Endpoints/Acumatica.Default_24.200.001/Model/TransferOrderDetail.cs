using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class TransferOrderDetail : Entity
	{

		public List<TransferOrderDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		public StringValue? FromLocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Line Number</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SpecialOrderCostCenterID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Special Order Nbr.</para>
		/// </summary>
		public StringValue? SpecialOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Location ID</para>
		/// </summary>
		public StringValue? ToLocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ToCostCodeID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Cost Code</para>
		/// </summary>
		public StringValue? ToCostCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Cost Layer Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ToCostLayerType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ToProjectID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Project</para>
		/// </summary>
		public StringValue? ToProject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ToTaskID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Project Task</para>
		/// </summary>
		public StringValue? ToProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ToSpecialOrderCostCenterID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: To Special Order Nbr.</para>
		/// </summary>
		public StringValue? ToSpecialOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

	}
}