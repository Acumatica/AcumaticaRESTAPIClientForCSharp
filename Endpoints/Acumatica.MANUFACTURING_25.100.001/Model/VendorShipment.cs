using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM310000</c> in the Acumatica ERP
	/// <para>Key Fields: ShipmentID</para>
	/// </summary>
	public class VendorShipment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: ControlQty</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Control Quantity</para>
		/// </summary>
		public DecimalValue? ControlQuantity { get; set; }

		public List<VendorShipmentDetails>? Details { get; set; }

		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Shipment Date</para>
		/// </summary>
		public DateTimeValue? ShipmentDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentNbr</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Shipment ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ShipmentID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentQty</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Shipped Quantity</para>
		/// </summary>
		public DecimalValue? ShippedQuantity { get; set; }

		public ShipToSettings? ShippingSettings { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentType</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		public StringValue? Workgroup { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string ShippingSettings = "ShippingSettings";
			public const string ShippingSettings_ShipToAddress = "ShippingSettings/ShipToAddress";
			public const string ShippingSettings_ShipToContact = "ShippingSettings/ShipToContact";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files,ShippingSettings,ShippingSettings/ShipToAddress,ShippingSettings/ShipToContact";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}