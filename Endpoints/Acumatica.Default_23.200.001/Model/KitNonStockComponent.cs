using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class KitNonStockComponent : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AllowQtyVariation</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>Display Name: Allow Component Qty. Variance</para>
		/// </summary>
		public BooleanValue? AllowComponentQtyVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltCompQty</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>Display Name: Component Qty.</para>
		/// </summary>
		public DecimalValue? ComponentQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MaxCompQty</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>Display Name: Max. Component Qty.</para>
		/// </summary>
		public DecimalValue? MaxComponentQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinCompQty</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>Display Name: Min. Component Qty.</para>
		/// </summary>
		public DecimalValue? MinComponentQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CompInventoryID</para>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>Display Name: Component ID</para>
		/// </summary>
		public StringValue? NonStockInventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INKitSpecStkDet</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

	}
}