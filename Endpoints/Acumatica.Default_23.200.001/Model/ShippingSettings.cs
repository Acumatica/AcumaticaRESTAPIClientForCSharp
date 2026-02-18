using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ShippingSettings : Entity
	{

		/// <summary>
		/// The expiration date of the order, by which the order can be selected for canceling onthe Process Orders (SO501000) form.
		/// <para>DAC Field Name: CancelDate</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Cancel By</para>
		/// </summary>
		public DateTimeValue? CancelByDate { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) that the order has been canceled on thedate specified in CancelDate.
		/// <para>DAC Field Name: Cancelled</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// </summary>
		public BooleanValue? Canceled { get; set; }

		/// <summary>
		/// The identifier of the point where ownership ofthe goods is transferred to the customer.The field is included in the FOBPoint foreign key.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: FOB Point</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		/// <remarks>
		/// This field is available only for blanket sales orders and cannot be empty.
		/// </remarks>
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether a user selects to use the FedEx Ground Collect option.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Ground Collect</para>
		/// </summary>
		/// <remarks>
		/// This field is available only if theShipping Carrier Integrationfeature is enabled on the Enable/Disable Features (CS100000) form, integration with the FedEx carrieris established, and FedEx is selected in the Ship Via field.
		/// </remarks>
		public BooleanValue? GroundCollect { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether a user selects to indicate that insurance is required for this order.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// </summary>
		public BooleanValue? Insurance { get; set; }

		/// <summary>
		/// The identifier of the warehouse from which the goods should be shipped.The field is included in the DefaultSite foreign key.
		/// <para>DAC Field Name: DefaultSiteID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Preferred Warehouse ID</para>
		/// </summary>
		/// <remarks>
		/// This field is available only if the Inventoryfeature is enabled on the Enable/Disable Features (CS100000) form.
		/// </remarks>
		public StringValue? PreferredWarehouseID { get; set; }

		/// <summary>
		/// The level of priority for processing orders of this customer, as specifiedcOrderPriority field for the customer.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// </summary>
		public ShortValue? Priority { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the shipment should be delivered to a residential area.
		/// <para>DAC Field Name: Resedential</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Residential Delivery</para>
		/// </summary>
		public BooleanValue? ResidentialDelivery { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the order may be delivered on Saturday.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Saturday Delivery</para>
		/// </summary>
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// The date when the ordered goods are scheduled to be shipped.
		/// <para>DAC Field Name: ShipDate</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Sched. Shipment</para>
		/// </summary>
		/// <remarks>
		/// By default, it is the date that is specified in requestDate minus the number of lead days,but it is not earlier than the current business date.
		/// </remarks>
		public DateTimeValue? ScheduledShipmentDate { get; set; }

		/// <summary>
		/// An option that controls whether incomplete and partial shipments for the order are allowed.
		/// <para>DAC Field Name: ShipComplete</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Shipping Rule</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		/// <remarks>
		/// This field is available only if the Inventoryfeature is enabled on the Enable/Disable Features (CS100000) form.form.
		/// </remarks>
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// The identifier of the shipping terms used for this customer.The field is included in the ShipTerms foreign key.
		/// <para>DAC Field Name: ShipTermsID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Shipping Terms</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// The identifier of the shipping zone of the customer to be used tocalculate freight.The field is included in the ShippingZone foreign key.
		/// <para>DAC Field Name: ShipZoneID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Shipping Zone</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ShippingZone { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the goods for the customer should be shipped separately for eachsales order.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Ship Separately</para>
		/// </summary>
		/// <remarks>
		/// This field is available only if the Inventoryfeature is enabled on the Enable/Disable Features (CS100000) form.
		/// </remarks>
		public BooleanValue? ShipSeparately { get; set; }

		/// <summary>
		/// The identifier of the ship via code that represents the carrier andits service to be used for shipping the ordered goods.The field is included in the Carrier foreign key.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Ship Via</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		/// <remarks>
		/// For this ship via code, if Manual is specified as the freight calculation method, the freight amount mustbe specified in the Freight Price field.Changing the Ship Via code for an open sales order may update thecustomer tax zone field.
		/// </remarks>
		public StringValue? ShipVia { get; set; }

		public ShopForRates? ShopForRates { get; set; }

		/// <summary>
		/// A Boolean value that specifies (if set to true) that the customer account with thecarrier should be billed for the shipping of this order.
		/// <para>DAC Field Name: UseCustomerAccount</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Use Customer's Account</para>
		/// </summary>
		/// <remarks>
		/// This field is available only if theShipping Carrier Integrationfeature is enabled on the Enable/Disable Features (CS100000) form.
		/// </remarks>
		public BooleanValue? UseCustomersAccount { get; set; }

		/// <summary>
		/// The freight amount calculated in accordance withthe shipping terms (in the currency of the document).
		/// <para>DAC Field Name: CuryFreightAmt</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Freight Price</para>
		/// </summary>
		public DecimalValue? FreightPrice { get; set; }

		/// <summary>
		/// The freight cost calculated for the document(in the currency of the document).
		/// <para>DAC Field Name: CuryFreightCost</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Freight Cost</para>
		/// </summary>
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the freight rates are up to date.
		/// <para>DAC Field Name: FreightCostIsValid</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Freight Cost Is up-to-date</para>
		/// </summary>
		public BooleanValue? FreightCostIsuptodate { get; set; }

		/// <summary>
		/// The identifier of the tax category that applies to the total freight amount.The field is included in the FreightTaxCategory foreign key.
		/// <para>DAC Field Name: FreightTaxCategoryID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Freight Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		/// <remarks>
		/// The default value is the tax category associated with the ship via codeship via code of the order.This field is not available for transfer orders.
		/// </remarks>
		public StringValue? FreightTaxCategory { get; set; }

		/// <summary>
		/// The total volume of goods according to the document.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Order Volume</para>
		/// </summary>
		public DecimalValue? OrderVolume { get; set; }

		/// <summary>
		/// The total weight of the goods according to the document.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Order Weight</para>
		/// </summary>
		public DecimalValue? OrderWeight { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the Freight Price can be changedmanually.
		/// <para>DAC Field Name: OverrideFreightAmount</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Override Freight Price</para>
		/// </summary>
		/// <remarks>
		/// The system will preserve the manually entered Freight Price value inthe sales order and will not recalculate the value if the quantity, extended price, or amount is modifiedin order lines.
		/// </remarks>
		public BooleanValue? OverrideFreightPrice { get; set; }

		/// <summary>
		/// The total (gross) weight of the packages for this sales order, including the weight of the boxes used forpackages.
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Package Weight</para>
		/// </summary>
		public DecimalValue? PackageWeight { get; set; }

		/// <summary>
		/// Any additional freight charges for handling the order(in the currency of the document).
		/// <para>DAC Field Name: CuryPremiumFreightAmt</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Premium Freight Price</para>
		/// </summary>
		public DecimalValue? PremiumFreight { get; set; }

	}
}