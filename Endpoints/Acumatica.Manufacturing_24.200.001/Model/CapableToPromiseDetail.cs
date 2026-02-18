using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class CapableToPromiseDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AMCTPAccepted</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public BooleanValue? CTPAccepted { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public DateTimeValue? CTPDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public IntValue? LineNbr { get; set; }

		public IntValue? LineOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ManualProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public StringValue? ManualOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMOrigRequestDate</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public DateTimeValue? OriginalRequestDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public StringValue? ProdOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMCTPOrderType</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RequestDate</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public DateTimeValue? RequestedOn { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipDate</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public DateTimeValue? ShipOn { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderNbr</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public StringValue? SONbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderType</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public StringValue? SOType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPLine</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}