using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class LateAssignmentUnallocatedDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMProdMatlLotSerialAssigned</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public IntValue? LineID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// Key Field
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		public StringValue? OperationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderType { get; set; }

		public StringValue? ParentLotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// Key Field
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdMatlLotSerialUnassigned</para>
		/// <para>Display Name: Required Qty.</para>
		/// </summary>
		public DecimalValue? QtyRequired { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyToAllocate</para>
		/// <para>DAC: PX.Objects.AM.AMProdMatlLotSerialUnassigned</para>
		/// <para>Display Name: Qty. to Allocate</para>
		/// </summary>
		public DecimalValue? QtytoAllocate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyIssued</para>
		/// <para>DAC: PX.Objects.AM.AMProdMatlLotSerialAssigned</para>
		/// <para>Display Name: Allocated Qty.</para>
		/// </summary>
		public DecimalValue? QtyUnallocated { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BaseUnit</para>
		/// <para>DAC: PX.Objects.AM.AMProdMatlLotSerialAssigned</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

	}
}