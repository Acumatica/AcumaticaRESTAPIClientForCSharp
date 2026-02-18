using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class KitAssemblyStockComponent : Entity
	{

		public List<KitAssemblyStockComponentAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INKitSpecStkDet__DfltCompQty</para>
		/// <para>DAC: PX.Objects.IN.INComponentTran</para>
		/// </summary>
		public DecimalValue? ComponentQty { get; set; }

		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID</para>
		/// <para>DAC: PX.Objects.IN.INComponentTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? StockInventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INComponentTran</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitRegister</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

	}
}