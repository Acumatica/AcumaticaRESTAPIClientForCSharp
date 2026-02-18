using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class InventoryIssueDetail : Entity
	{

		public List<InventoryIssueDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.IN.INRegister</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Cost Layer Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? CostLayerType { get; set; }

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
		/// <para>DAC Field Name: TranCost</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Ext. Cost</para>
		/// </summary>
		public DecimalValue? ExtCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranAmt</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Ext. Price</para>
		/// </summary>
		public DecimalValue? ExtPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public IntValue? LineNumber { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// </summary>
		public StringValue? Location { get; set; }

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
		/// <para>Display Name: Tran. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? TranType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Unit Price</para>
		/// </summary>
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.INTran</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

	}
}