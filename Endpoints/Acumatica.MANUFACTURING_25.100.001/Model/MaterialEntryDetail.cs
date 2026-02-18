using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class MaterialEntryDetail : Entity
	{

		public List<MaterialEntryDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsByproduct</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: By-product</para>
		/// </summary>
		public BooleanValue? Byproduct { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_description</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranAmt</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Ext. Cost</para>
		/// </summary>
		public DecimalValue? ExtCost { get; set; }

		/// <summary>
		/// Reference to journal transaction field LineNbr
		/// <para>DAC Field Name: GLLineNbr</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: GL Batch Line Nbr</para>
		/// </summary>
		public IntValue? GLBatchLineNbr { get; set; }

		/// <summary>
		/// Reference to journal transaction field BatchNbr
		/// <para>DAC Field Name: GLBatNbr</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: GL Batch Nbr</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? GLBatchNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: IN Doc Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? INDocType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: IN Line Nbr</para>
		/// </summary>
		public IntValue? INLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INBatNbr</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: IN Ref Nbr</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? INRefNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MatlLineId</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Material Line ID</para>
		/// </summary>
		public IntValue? MaterialLineID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OperationID</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Operation ID</para>
		/// </summary>
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Parent Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? ParentLotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// </summary>
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// A brief description of the transaction.
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? TranDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}