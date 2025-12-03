using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM310000</c> in the Acumatica ERP
	/// <para>Key Fields: ShipmentID</para>
	/// </summary>
	[DataContract]
	public class VendorShipment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: ControlQty</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Control Quantity</para>
		/// </summary>
		[DataMember(Name="ControlQuantity", EmitDefaultValue=false)]
		public DecimalValue? ControlQuantity { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<VendorShipmentDetails>? Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Shipment Date</para>
		/// </summary>
		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue? ShipmentDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentNbr</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Shipment ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ShipmentID", EmitDefaultValue=false)]
		public StringValue? ShipmentID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentQty</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>Display Name: Shipped Quantity</para>
		/// </summary>
		[DataMember(Name="ShippedQuantity", EmitDefaultValue=false)]
		public DecimalValue? ShippedQuantity { get; set; }

		[DataMember(Name="ShippingSettings", EmitDefaultValue=false)]
		public ShipToSettings? ShippingSettings { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentType</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string ShippingSettings = "ShippingSettings";
			public const string ShippingSettings_ShipToAddress = "ShippingSettings/ShipToAddress";
			public const string ShippingSettings_ShipToContact = "ShippingSettings/ShipToContact";

			//Intentionally excluded
			//public const string All = "Files,Details,Details/Files,ShippingSettings,ShippingSettings/ShipToAddress,ShippingSettings/ShipToContact";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}