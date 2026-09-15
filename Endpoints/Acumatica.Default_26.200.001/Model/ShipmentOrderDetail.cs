using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class ShipmentOrderDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: InvtDocType</para>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Inventory Doc. Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="InventoryDocType", EmitDefaultValue=false)]
		public StringSingleSelectValue? InventoryDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtRefNbr</para>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Inventory Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
		public StringValue? InventoryRefNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Invoice Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Invoice Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="InvoiceType", EmitDefaultValue=false)]
		public StringSingleSelectValue? InvoiceType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOOrderShipment</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipment Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringSingleSelectValue? ShipmentType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentQty</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipped Quantity</para>
		/// </summary>
		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentVolume</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipped Volume</para>
		/// </summary>
		[DataMember(Name="ShippedVolume", EmitDefaultValue=false)]
		public DecimalValue? ShippedVolume { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentWeight</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipped Weight</para>
		/// </summary>
		[DataMember(Name="ShippedWeight", EmitDefaultValue=false)]
		public DecimalValue? ShippedWeight { get; set; }

		[DataMember(Name="OrderNoteID", EmitDefaultValue=false)]
		public GuidValue? OrderNoteID { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}