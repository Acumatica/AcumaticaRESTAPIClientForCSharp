using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ShipmentOrderDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: InvtDocType</para>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Inventory Doc. Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? InventoryDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtRefNbr</para>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Inventory Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? InventoryRefNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Invoice Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Invoice Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? InvoiceType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipment Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ShipmentType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentQty</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipped Quantity</para>
		/// </summary>
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentVolume</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipped Volume</para>
		/// </summary>
		public DecimalValue? ShippedVolume { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentWeight</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipped Weight</para>
		/// </summary>
		public DecimalValue? ShippedWeight { get; set; }

		public GuidValue? OrderNoteID { get; set; }

	}
}