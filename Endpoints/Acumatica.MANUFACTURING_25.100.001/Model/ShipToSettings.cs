using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class ShipToSettings : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: FOB Point</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryFreightCost</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Freight Cost</para>
		/// </summary>
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryFreightAmt</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Freight Price</para>
		/// </summary>
		public DecimalValue? FreightPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Ground Collect</para>
		/// </summary>
		public BooleanValue? GroundCollect { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		public BooleanValue? Insurance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FreightAmountSource</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Invoice Freight Price Based On</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? InvoiceFreightPriceBasedOn { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideFreightAmount</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Override Freight Price</para>
		/// </summary>
		public BooleanValue? OverrideFreightPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Residential</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Residential Delivery</para>
		/// </summary>
		public BooleanValue? ResidentialDelivery { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Saturday Delivery</para>
		/// </summary>
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipTermsID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Shipping Terms</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipZoneID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Shipping Zone ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ShippingZoneID { get; set; }

		public Address? ShipToAddress { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipmentAddress</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? ShipToAddressOverride { get; set; }

		public DocContact? ShipToContact { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipmentContact</para>
		/// <para>Display Name: Override Contact</para>
		/// </summary>
		public BooleanValue? ShipToContactOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Ship Via</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ShipVia { get; set; }

	}
}