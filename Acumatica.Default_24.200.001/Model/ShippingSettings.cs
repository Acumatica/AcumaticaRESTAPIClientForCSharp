using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class ShippingSettings : Entity
	{

		/// <summary>
		/// The expiration date of the order, by which the order can be selected for canceling onthe Process Orders (SO501000) form.
		/// DAC Field Name: CancelDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Cancel By 
		/// </summary>
		[DataMember(Name="CancelByDate", EmitDefaultValue=false)]
		public DateTimeValue? CancelByDate { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the order has been canceled on thedate specified in CancelDate.
		/// DAC Field Name: Cancelled 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		[DataMember(Name="Canceled", EmitDefaultValue=false)]
		public BooleanValue? Canceled { get; set; }

		/// <summary>
		/// The identifier of the point where ownership ofthe goods is transferred to the customer.The field is included in the FOBPoint foreign key.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: FOB Point 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		/// <remarks>
		/// This field is available only for blanket sales orders and cannot be empty.
		/// </remarks>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether a user selects to use the FedEx Ground Collect option.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Ground Collect 
		/// </summary>
		/// <remarks>
		/// This field is available only if theShipping Carrier Integrationfeature is enabled on the Enable/Disable Features (CS100000) form, integration with the FedEx carrieris established, and FedEx is selected in the Ship Via field.
		/// </remarks>
		[DataMember(Name="GroundCollect", EmitDefaultValue=false)]
		public BooleanValue? GroundCollect { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether a user selects to indicate that insurance is required for this order.
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue? Insurance { get; set; }

		/// <summary>
		/// The identifier of the warehouse from which the goods should be shipped.The field is included in the DefaultSite foreign key.
		/// DAC Field Name: DefaultSiteID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Preferred Warehouse ID 
		/// </summary>
		/// <remarks>
		/// This field is available only if the Inventoryfeature is enabled on the Enable/Disable Features (CS100000) form.
		/// </remarks>
		[DataMember(Name="PreferredWarehouseID", EmitDefaultValue=false)]
		public StringValue? PreferredWarehouseID { get; set; }

		/// <summary>
		/// The level of priority for processing orders of this customer, as specifiedcOrderPriority field for the customer.
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public ShortValue? Priority { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the shipment should be delivered to a residential area.
		/// DAC Field Name: Resedential 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Residential Delivery 
		/// </summary>
		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the order may be delivered on Saturday.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Saturday Delivery 
		/// </summary>
		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// The date when the ordered goods are scheduled to be shipped.
		/// DAC Field Name: ShipDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Sched. Shipment 
		/// </summary>
		/// <remarks>
		/// By default, it is the date that is specified in requestDate minus the number of lead days,but it is not earlier than the current business date.
		/// </remarks>
		[DataMember(Name="ScheduledShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledShipmentDate { get; set; }

		/// <summary>
		/// An option that controls whether incomplete and partial shipments for the order are allowed.
		/// DAC Field Name: ShipComplete 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Shipping Rule 
		/// SQL Type: char(1) 
		/// </summary>
		/// <remarks>
		/// This field is available only if the Inventoryfeature is enabled on the Enable/Disable Features (CS100000) form.form.
		/// </remarks>
		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// The identifier of the shipping terms used for this customer.The field is included in the ShipTerms foreign key.
		/// DAC Field Name: ShipTermsID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Shipping Terms 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// The identifier of the shipping zone of the customer to be used tocalculate freight.The field is included in the ShippingZone foreign key.
		/// DAC Field Name: ShipZoneID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Shipping Zone 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShippingZone", EmitDefaultValue=false)]
		public StringValue? ShippingZone { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the goods for the customer should be shipped separately for eachsales order.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Ship Separately 
		/// </summary>
		/// <remarks>
		/// This field is available only if the Inventoryfeature is enabled on the Enable/Disable Features (CS100000) form.
		/// </remarks>
		[DataMember(Name="ShipSeparately", EmitDefaultValue=false)]
		public BooleanValue? ShipSeparately { get; set; }

		/// <summary>
		/// The identifier of the ship via code that represents the carrier andits service to be used for shipping the ordered goods.The field is included in the Carrier foreign key.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Ship Via 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		/// <remarks>
		/// For this ship via code, if Manual is specified as the freight calculation method, the freight amount mustbe specified in the Freight Price field.Changing the Ship Via code for an open sales order may update thecustomer tax zone field.
		/// </remarks>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		[DataMember(Name="ShopForRates", EmitDefaultValue=false)]
		public ShopForRates? ShopForRates { get; set; }

		/// <summary>
		/// A Boolean value that specifies (if set to true) that the customer account with thecarrier should be billed for the shipping of this order.
		/// DAC Field Name: UseCustomerAccount 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Use Customer's Account 
		/// </summary>
		/// <remarks>
		/// This field is available only if theShipping Carrier Integrationfeature is enabled on the Enable/Disable Features (CS100000) form.
		/// </remarks>
		[DataMember(Name="UseCustomersAccount", EmitDefaultValue=false)]
		public BooleanValue? UseCustomersAccount { get; set; }

		/// <summary>
		/// The freight amount calculated in accordance withthe shipping terms (in the currency of the document).
		/// DAC Field Name: CuryFreightAmt 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Freight Price 
		/// </summary>
		[DataMember(Name="FreightPrice", EmitDefaultValue=false)]
		public DecimalValue? FreightPrice { get; set; }

		/// <summary>
		/// The freight cost calculated for the document(in the currency of the document).
		/// DAC Field Name: CuryFreightCost 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Freight Cost 
		/// </summary>
		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the freight rates are up to date.
		/// DAC Field Name: FreightCostIsValid 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Freight Cost Is up-to-date 
		/// </summary>
		[DataMember(Name="FreightCostIsuptodate", EmitDefaultValue=false)]
		public BooleanValue? FreightCostIsuptodate { get; set; }

		/// <summary>
		/// The identifier of the tax category that applies to the total freight amount.The field is included in the FreightTaxCategory foreign key.
		/// DAC Field Name: FreightTaxCategoryID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Freight Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		/// <remarks>
		/// The default value is the tax category associated with the ship via codeship via code of the order.This field is not available for transfer orders.
		/// </remarks>
		[DataMember(Name="FreightTaxCategory", EmitDefaultValue=false)]
		public StringValue? FreightTaxCategory { get; set; }

		/// <summary>
		/// The total volume of goods according to the document.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Volume 
		/// </summary>
		[DataMember(Name="OrderVolume", EmitDefaultValue=false)]
		public DecimalValue? OrderVolume { get; set; }

		/// <summary>
		/// The total weight of the goods according to the document.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Weight 
		/// </summary>
		[DataMember(Name="OrderWeight", EmitDefaultValue=false)]
		public DecimalValue? OrderWeight { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the Freight Price can be changedmanually.
		/// DAC Field Name: OverrideFreightAmount 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Override Freight Price 
		/// </summary>
		/// <remarks>
		/// The system will preserve the manually entered Freight Price value inthe sales order and will not recalculate the value if the quantity, extended price, or amount is modifiedin order lines.
		/// </remarks>
		[DataMember(Name="OverrideFreightPrice", EmitDefaultValue=false)]
		public BooleanValue? OverrideFreightPrice { get; set; }

		/// <summary>
		/// The total (gross) weight of the packages for this sales order, including the weight of the boxes used forpackages.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Package Weight 
		/// </summary>
		[DataMember(Name="PackageWeight", EmitDefaultValue=false)]
		public DecimalValue? PackageWeight { get; set; }

		/// <summary>
		/// Any additional freight charges for handling the order(in the currency of the document).
		/// DAC Field Name: CuryPremiumFreightAmt 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Premium Freight Price 
		/// </summary>
		[DataMember(Name="PremiumFreight", EmitDefaultValue=false)]
		public DecimalValue? PremiumFreight { get; set; }

	}
}