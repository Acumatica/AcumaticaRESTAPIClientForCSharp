using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class DisassemblyEntryMaterial : Entity
	{

		public List<DisassemblyEntryMaterialAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranAmt</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: Ext. Cost</para>
		/// </summary>
		public DecimalValue? ExtCost { get; set; }

		/// <summary>
		/// Reference to journal transaction field LineNbr
		/// <para>DAC Field Name: GLLineNbr</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: GL Batch Line Nbr</para>
		/// </summary>
		public IntValue? GLBatchLineNbr { get; set; }

		/// <summary>
		/// Reference to journal transaction field BatchNbr
		/// <para>DAC Field Name: GLBatNbr</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: GL Batch Nbr</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? GLBatchNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: IN Doc Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? INDocType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: IN Line Nbr</para>
		/// </summary>
		public IntValue? INLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INBatNbr</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: IN Ref Nbr</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? INRefNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MatlLineId</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: Material Line Nbr</para>
		/// </summary>
		public IntValue? MaterialLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OperationID</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: Operation ID</para>
		/// </summary>
		public StringValue? OperationNbr { get; set; }

		public StringValue? ParentLotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsScrap</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: Scrapped</para>
		/// </summary>
		public BooleanValue? QtyisScrap { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// </summary>
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// Scrap reason code selector for production transaction. Results are limited to Production.
		/// <para>DAC Field Name: ReasonCodeID</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>Display Name: Tran. Type</para>
		/// <para>SQL Type: nchar(3)</para>
		/// </summary>
		public StringValue? TranType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleTran</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMDisassembleBatch</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}