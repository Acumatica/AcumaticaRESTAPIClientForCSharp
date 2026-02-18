using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class KitAssemblyNonStockComponent : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: INKitSpecNonStkDet__DfltCompQty</para>
		/// <para>DAC: PX.Objects.IN.INOverheadTran</para>
		/// </summary>
		public DecimalValue? ComponentQty { get; set; }

		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID</para>
		/// <para>DAC: PX.Objects.IN.INComponentTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? NonStockInventoryID { get; set; }

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