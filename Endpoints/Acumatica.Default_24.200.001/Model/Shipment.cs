using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SO302000</c> in the Acumatica ERP
	/// <para>Key Fields: ShipmentNbr</para>
	/// </summary>
	public class Shipment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Identifier of the base Currency.
		/// <para>DAC Field Name: BaseCuryID</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Base Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Control Quantity</para>
		/// </summary>
		public DecimalValue? ControlQty { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The exchange rate used for calculations and determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// <para>DAC Field Name: SampleCuryRate</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Curr. Rate</para>
		/// </summary>
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// The identifier of the Rate Type associated with this object.
		/// <para>DAC Field Name: CuryRateTypeID</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Curr. Rate Type ID</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryViewState</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// </summary>
		public BooleanValue? CurrencyViewState { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Customer</para>
		/// </summary>
		public StringValue? CustomerID { get; set; }

		public BooleanValue? CreateNewShipmentForEveryOrder { get; set; }

		public List<ShipmentDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentDesc</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The date, starting from which the specified rate is considered current.
		/// <para>DAC Field Name: CuryEffDate</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: FOB Point</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideFreightAmount</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Override Freight Price</para>
		/// </summary>
		public BooleanValue? OverrideFreightPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryFreightAmt</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Freight Price</para>
		/// </summary>
		public DecimalValue? FreightPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryFreightCost</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Freight Cost</para>
		/// </summary>
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Freight Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? FreightCurrencyID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Ground Collect</para>
		/// </summary>
		public BooleanValue? GroundCollect { get; set; }

		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// </summary>
		public BooleanValue? Insurance { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerLocationID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Operation { get; set; }

		public List<ShipmentOrderDetail>? Orders { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Packages</para>
		/// </summary>
		public IntValue? PackageCount { get; set; }

		public List<ShipmentPackage>? Packages { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Package Weight</para>
		/// </summary>
		public DecimalValue? PackageWeight { get; set; }

		public BooleanValue? Picked { get; set; }

		/// <summary>
		/// The inverse of the SampleCuryRate. This value is also determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// <para>DAC Field Name: SampleRecipRate</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Reciprocal Rate</para>
		/// </summary>
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Resedential</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Residential Delivery</para>
		/// </summary>
		public BooleanValue? ResidentialDelivery { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Saturday Delivery</para>
		/// </summary>
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipDate</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipment Date</para>
		/// </summary>
		public DateTimeValue? ShipmentDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipment Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ShipmentNbr { get; set; }

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

		public ShipToSettings? ShippingSettings { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipTermsID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipping Terms</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipZoneID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipping Zone ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ShippingZoneID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Ship Via</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DestinationSiteID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: To Warehouse</para>
		/// </summary>
		public StringValue? ToWarehouseID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentType</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		public BooleanValue? UnlimitedPackages { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseCustomerAccount</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Use Customer's Account</para>
		/// </summary>
		public BooleanValue? UseCustomersAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Warehouse ID</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Workgroup</para>
		/// </summary>
		public StringValue? WorkgroupID { get; set; }

		public GuidValue? NoteID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string Details_Allocations = "Details/Allocations";
			public const string Details_Allocations_Files = "Details/Allocations/Files";
			public const string Orders = "Orders";
			public const string Orders_Files = "Orders/Files";
			public const string Packages = "Packages";
			public const string Packages_Files = "Packages/Files";
			public const string Packages_PackageContents = "Packages/PackageContents";
			public const string Packages_PackageContents_Files = "Packages/PackageContents/Files";
			public const string ShippingSettings = "ShippingSettings";
			public const string ShippingSettings_ShipToAddress = "ShippingSettings/ShipToAddress";
			public const string ShippingSettings_ShipToContact = "ShippingSettings/ShipToContact";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files,Details/Allocations,Details/Allocations/Files,Orders,Orders/Files,Packages,Packages/Files,Packages/PackageContents,Packages/PackageContents/Files,ShippingSettings,ShippingSettings/ShipToAddress,ShippingSettings/ShipToContact";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}