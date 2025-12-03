using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
	[DataContract]
	public class Shipment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Identifier of the base Currency.
		/// <para>DAC Field Name: BaseCuryID</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Base Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Control Quantity</para>
		/// </summary>
		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue? ControlQty { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The exchange rate used for calculations and determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// <para>DAC Field Name: SampleCuryRate</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Curr. Rate</para>
		/// </summary>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// The identifier of the Rate Type associated with this object.
		/// <para>DAC Field Name: CuryRateTypeID</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Curr. Rate Type ID</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryViewState</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// </summary>
		[DataMember(Name="CurrencyViewState", EmitDefaultValue=false)]
		public BooleanValue? CurrencyViewState { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Customer</para>
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		[DataMember(Name="CreateNewShipmentForEveryOrder", EmitDefaultValue=false)]
		public BooleanValue? CreateNewShipmentForEveryOrder { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ShipmentDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentDesc</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The date, starting from which the specified rate is considered current.
		/// <para>DAC Field Name: CuryEffDate</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: FOB Point</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideFreightAmount</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Override Freight Price</para>
		/// </summary>
		[DataMember(Name="OverrideFreightPrice", EmitDefaultValue=false)]
		public BooleanValue? OverrideFreightPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryFreightAmt</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Freight Price</para>
		/// </summary>
		[DataMember(Name="FreightPrice", EmitDefaultValue=false)]
		public DecimalValue? FreightPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryFreightCost</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Freight Cost</para>
		/// </summary>
		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Freight Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="FreightCurrencyID", EmitDefaultValue=false)]
		public StringValue? FreightCurrencyID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Ground Collect</para>
		/// </summary>
		[DataMember(Name="GroundCollect", EmitDefaultValue=false)]
		public BooleanValue? GroundCollect { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// </summary>
		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue? Insurance { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerLocationID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public StringValue? Operation { get; set; }

		[DataMember(Name="Orders", EmitDefaultValue=false)]
		public List<ShipmentOrderDetail>? Orders { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Packages</para>
		/// </summary>
		[DataMember(Name="PackageCount", EmitDefaultValue=false)]
		public IntValue? PackageCount { get; set; }

		[DataMember(Name="Packages", EmitDefaultValue=false)]
		public List<ShipmentPackage>? Packages { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Package Weight</para>
		/// </summary>
		[DataMember(Name="PackageWeight", EmitDefaultValue=false)]
		public DecimalValue? PackageWeight { get; set; }

		[DataMember(Name="Picked", EmitDefaultValue=false)]
		public BooleanValue? Picked { get; set; }

		/// <summary>
		/// The inverse of the SampleCuryRate. This value is also determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// <para>DAC Field Name: SampleRecipRate</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Reciprocal Rate</para>
		/// </summary>
		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Resedential</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Residential Delivery</para>
		/// </summary>
		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Saturday Delivery</para>
		/// </summary>
		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipDate</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipment Date</para>
		/// </summary>
		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue? ShipmentDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipment Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

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

		[DataMember(Name="ShippingSettings", EmitDefaultValue=false)]
		public ShipToSettings? ShippingSettings { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipTermsID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipping Terms</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipZoneID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Shipping Zone ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ShippingZoneID", EmitDefaultValue=false)]
		public StringValue? ShippingZoneID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Ship Via</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DestinationSiteID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: To Warehouse</para>
		/// </summary>
		[DataMember(Name="ToWarehouseID", EmitDefaultValue=false)]
		public StringValue? ToWarehouseID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipmentType</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="UnlimitedPackages", EmitDefaultValue=false)]
		public BooleanValue? UnlimitedPackages { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UseCustomerAccount</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Use Customer's Account</para>
		/// </summary>
		[DataMember(Name="UseCustomersAccount", EmitDefaultValue=false)]
		public BooleanValue? UseCustomersAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Warehouse ID</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Workgroup</para>
		/// </summary>
		[DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
		public StringValue? WorkgroupID { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
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
			//public const string All = "Files,Details,Details/Files,Details/Allocations,Details/Allocations/Files,Orders,Orders/Files,Packages,Packages/Files,Packages/PackageContents,Packages/PackageContents/Files,ShippingSettings,ShippingSettings/ShipToAddress,ShippingSettings/ShipToContact";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}