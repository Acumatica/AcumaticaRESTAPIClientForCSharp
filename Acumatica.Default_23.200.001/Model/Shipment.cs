using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen SO302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Shipment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Identifier of the base Currency.
		/// DAC Field Name: BaseCuryID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Base Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Control Quantity 
		/// </summary>
		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue? ControlQty { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The exchange rate used for calculations and determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// DAC Field Name: SampleCuryRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Curr. Rate 
		/// </summary>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// The identifier of the Rate Type associated with this object.
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Curr. Rate Type ID 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// DAC Field Name: CuryViewState 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		[DataMember(Name="CurrencyViewState", EmitDefaultValue=false)]
		public BooleanValue? CurrencyViewState { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Customer 
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		[DataMember(Name="CreateNewShipmentForEveryOrder", EmitDefaultValue=false)]
		public BooleanValue? CreateNewShipmentForEveryOrder { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ShipmentDetail>? Details { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentDesc 
		/// DAC: PX.Objects.SO.SOShipment 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The date, starting from which the specified rate is considered current.
		/// DAC Field Name: CuryEffDate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Effective Date 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: FOB Point 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// DAC Field Name: OverrideFreightAmount 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Override Freight Price 
		/// </summary>
		[DataMember(Name="OverrideFreightPrice", EmitDefaultValue=false)]
		public BooleanValue? OverrideFreightPrice { get; set; }

		/// <summary>
		/// DAC Field Name: CuryFreightAmt 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Freight Price 
		/// </summary>
		[DataMember(Name="FreightPrice", EmitDefaultValue=false)]
		public DecimalValue? FreightPrice { get; set; }

		/// <summary>
		/// DAC Field Name: CuryFreightCost 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Freight Cost 
		/// </summary>
		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Freight Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="FreightCurrencyID", EmitDefaultValue=false)]
		public StringValue? FreightCurrencyID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Ground Collect 
		/// </summary>
		[DataMember(Name="GroundCollect", EmitDefaultValue=false)]
		public BooleanValue? GroundCollect { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue? Insurance { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public StringValue? Operation { get; set; }

		[DataMember(Name="Orders", EmitDefaultValue=false)]
		public List<ShipmentOrderDetail>? Orders { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Packages 
		/// </summary>
		[DataMember(Name="PackageCount", EmitDefaultValue=false)]
		public IntValue? PackageCount { get; set; }

		[DataMember(Name="Packages", EmitDefaultValue=false)]
		public List<ShipmentPackage>? Packages { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Package Weight 
		/// </summary>
		[DataMember(Name="PackageWeight", EmitDefaultValue=false)]
		public DecimalValue? PackageWeight { get; set; }

		[DataMember(Name="Picked", EmitDefaultValue=false)]
		public BooleanValue? Picked { get; set; }

		/// <summary>
		/// The inverse of the SampleCuryRate. This value is also determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// DAC Field Name: SampleRecipRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Reciprocal Rate 
		/// </summary>
		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// DAC Field Name: Resedential 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Residential Delivery 
		/// </summary>
		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Saturday Delivery 
		/// </summary>
		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// DAC Field Name: ShipDate 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Shipment Date 
		/// </summary>
		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue? ShipmentDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Shipment Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentQty 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Shipped Quantity 
		/// </summary>
		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentVolume 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Shipped Volume 
		/// </summary>
		[DataMember(Name="ShippedVolume", EmitDefaultValue=false)]
		public DecimalValue? ShippedVolume { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentWeight 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Shipped Weight 
		/// </summary>
		[DataMember(Name="ShippedWeight", EmitDefaultValue=false)]
		public DecimalValue? ShippedWeight { get; set; }

		[DataMember(Name="ShippingSettings", EmitDefaultValue=false)]
		public ShipToSettings? ShippingSettings { get; set; }

		/// <summary>
		/// DAC Field Name: ShipTermsID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Shipping Terms 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// DAC Field Name: ShipZoneID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Shipping Zone ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShippingZoneID", EmitDefaultValue=false)]
		public StringValue? ShippingZoneID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Ship Via 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: DestinationSiteID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: To Warehouse 
		/// </summary>
		[DataMember(Name="ToWarehouseID", EmitDefaultValue=false)]
		public StringValue? ToWarehouseID { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentType 
		/// DAC: PX.Objects.SO.SOShipment 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC Field Name: UseCustomerAccount 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Use Customer's Account 
		/// </summary>
		[DataMember(Name="UseCustomersAccount", EmitDefaultValue=false)]
		public BooleanValue? UseCustomersAccount { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Warehouse ID 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Workgroup 
		/// </summary>
		[DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
		public StringValue? WorkgroupID { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}