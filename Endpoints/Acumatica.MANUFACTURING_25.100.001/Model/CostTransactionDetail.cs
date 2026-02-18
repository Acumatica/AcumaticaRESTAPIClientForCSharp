using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class CostTransactionDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AcctID</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// </summary>
		public StringValue? Account { get; set; }

		/// <summary>
		/// The reference number of the transaction.
		/// <para>DAC Field Name: BatNbr</para>
		/// <para>DAC: PX.Objects.AM.AMBatch</para>
		/// <para>Display Name: Batch Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? BatchNbr { get; set; }

		public StringValue? DocType { get; set; }

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
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Operation ID</para>
		/// </summary>
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

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
		/// Cost ID value such as Tool ID, Overhead ID, Machine ID, etc.
		/// <para>DAC Field Name: ReferenceCostID</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// <para>Display Name: Ref. Cost ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? RefCostID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.AM.AMMTran</para>
		/// </summary>
		public StringValue? Subaccount { get; set; }

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
		/// <para>Display Name: Tran. Type</para>
		/// <para>SQL Type: nchar(3)</para>
		/// </summary>
		public StringValue? TranType { get; set; }

	}
}