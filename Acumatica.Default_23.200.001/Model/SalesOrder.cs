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
	/// Corresponds to the screen SO301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class SalesOrder : Entity, ITopLevelEntity
	{

		[DataMember(Name="Approved", EmitDefaultValue=false)]
		public BooleanValue? Approved { get; set; }

		/// <summary>
		/// Identifier of the base Currency.
		/// DAC Field Name: BaseCuryID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Base Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		[DataMember(Name="BillToAddress", EmitDefaultValue=false)]
		public Address? BillToAddress { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address is overriden.
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.SO.SOBillingAddress 
		/// Display Name: Override Address 
		/// </summary>
		[DataMember(Name="BillToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? BillToAddressOverride { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address has been validated with a third-party specialized software or service.
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.SO.SOBillingAddress 
		/// Display Name: Validated 
		/// </summary>
		[DataMember(Name="BillToAddressValidated", EmitDefaultValue=false)]
		public BooleanValue? BillToAddressValidated { get; set; }

		[DataMember(Name="BillToContact", EmitDefaultValue=false)]
		public DocContact? BillToContact { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact is overriden.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.SO.SOBillingContact 
		/// Display Name: Override Contact 
		/// </summary>
		[DataMember(Name="BillToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? BillToContactOverride { get; set; }

		/// <summary>
		/// The identifier of the branch.The field is included in the Branch foreign key.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the cash account associated with the customer payment method.The field is included in the CashAccount foreign key.
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="Commissions", EmitDefaultValue=false)]
		public Commissions? Commissions { get; set; }

		/// <summary>
		/// The identifier of the contact.The field is included in the Contact foreign key.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Contact 
		/// </summary>
		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public StringValue? ContactID { get; set; }

		/// <summary>
		/// The control total of the document (in the currency of the document).A user enters this amount manually.
		/// DAC Field Name: CuryControlTotal 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Control Total 
		/// </summary>
		[DataMember(Name="ControlTotal", EmitDefaultValue=false)]
		public DecimalValue? ControlTotal { get; set; }

		[DataMember(Name="CreditHold", EmitDefaultValue=false)]
		public BooleanValue? CreditHold { get; set; }

		/// <summary>
		/// The identifier of the currency of the document.The field is included in the Currency foreign key.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		/// <remarks>
		/// This field is available only if theMulticurrency Accounting feature is enabled onthe Enable/Disable Features (CS100000) form.
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

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
		/// The identifier of the customer. The field is a part of the identifier of thecustomer location.The field is included in the foreign keys Customer and CustomerLocation.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Customer 
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The reference number of the original customer document that the sales order is based on.
		/// DAC Field Name: CustomerOrderNbr 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Customer Order Nbr. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		/// <remarks>
		/// A reference number must be specified if theRequire Customer Order Nbr field istrue for the order type.This field is available for orders of the TR type.
		/// </remarks>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// The date of the document.
		/// DAC Field Name: OrderDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// A brief description of the document.
		/// DAC Field Name: OrderDesc 
		/// DAC: PX.Objects.SO.SOOrder 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The identifier of the destination warehouse for the items to be transferred.The field is included in the foreign keys DestinationSite and ToSite.
		/// DAC Field Name: DestinationSiteID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Destination Warehouse 
		/// </summary>
		/// <remarks>
		/// This field is available only if the Multiple Warehousesfeature is enabled on the Enable/Disable Features (CS100000) form.
		/// </remarks>
		[DataMember(Name="DestinationWarehouseID", EmitDefaultValue=false)]
		public StringValue? DestinationWarehouseID { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SalesOrderDetail>? Details { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the system treats discounts that have already been applied to theselected sales order as manual.
		/// DAC Field Name: DisableAutomaticDiscountCalculation 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Disable Automatic Discount Update 
		/// </summary>
		[DataMember(Name="DisableAutomaticDiscountUpdate", EmitDefaultValue=false)]
		public BooleanValue? DisableAutomaticDiscountUpdate { get; set; }

		/// <summary>
		/// A Boolean value that specifies (if set to true)that the system does not need to calculate taxes, because they are already calculated.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Disable Automatic Tax Calculation 
		/// </summary>
		[DataMember(Name="DisableAutomaticTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue? DisableAutomaticTaxCalculation { get; set; }

		[DataMember(Name="DiscountDetails", EmitDefaultValue=false)]
		public List<SalesOrdersDiscountDetails>? DiscountDetails { get; set; }

		/// <summary>
		/// The date, starting from which the specified rate is considered current.
		/// DAC Field Name: CuryEffDate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Effective Date 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// The reference number of the sales order in a third-party application if Acumatica ERP is integrated withsuch an application and imports the sales orders from it.
		/// DAC Field Name: CustomerRefNbr 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: External Reference 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		[DataMember(Name="FinancialSettings", EmitDefaultValue=false)]
		public FinancialSettings? FinancialSettings { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="IsTaxValid", EmitDefaultValue=false)]
		public BooleanValue? IsTaxValid { get; set; }

		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue? LastModified { get; set; }

		/// <summary>
		/// The identifier of the customer location.The field is included in the CustomerLocation foreign key.
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		[DataMember(Name="MaxRiskScore", EmitDefaultValue=false)]
		public DecimalValue? MaxRiskScore { get; set; }

		/// <summary>
		/// The summarized quantity of all items that have been added to the child order from the blanket sales order.
		/// DAC Field Name: OrderQty 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Ordered Qty. 
		/// </summary>
		/// <remarks>
		/// If any items that are not from the current blanket sales order have been added to the child order,their quantity is not summed up to the value in this field.
		/// </remarks>
		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// The unique reference number of the order.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		/// <remarks>
		/// When the new sales order is saved for the first time, the system automatically generatesthis number by using the numbering sequence assigned to orders of SOOrderType.
		/// </remarks>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		[DataMember(Name="OrderRisks", EmitDefaultValue=false)]
		public List<OrderRisks>? OrderRisks { get; set; }

		/// <summary>
		/// The total amount of the document (in the currency of the document).
		/// DAC Field Name: CuryOrderTotal 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Total 
		/// </summary>
		[DataMember(Name="OrderTotal", EmitDefaultValue=false)]
		public DecimalValue? OrderTotal { get; set; }

		/// <summary>
		/// The type of the document, which is a part of the identifier of the order.The identifier of the order type.The field is included in the OrderType foreign key.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		/// <remarks>
		/// The type of the document, which is one of the predefined order types or a custom order type created byusing the Order Types (SO201000) form.
		/// </remarks>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// The identifier of the payment method to be used to pay for the salesorder. The field is included in the PaymentMethod foreign key.
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Payment Method 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		[DataMember(Name="Payments", EmitDefaultValue=false)]
		public List<SalesOrderPayment>? Payments { get; set; }

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
		/// The identifier of the project.The field is included in the Project foreign key.
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		/// <remarks>
		/// This field is available only if theProject Accountingfeature is enabled on the Enable/Disable Features (CS100000) form and the integration of the Projectssubmodule with Sales Orders has been enabled(that is,  is .
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// The inverse of the SampleCuryRate. This value is also determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// DAC Field Name: SampleRecipRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Reciprocal Rate 
		/// </summary>
		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// The date when the customer wants to receive the goods.
		/// DAC Field Name: RequestDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Requested On 
		/// </summary>
		/// <remarks>
		/// This date provides the default values for the requestDate dates for order lines.
		/// </remarks>
		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOn { get; set; }

		[DataMember(Name="Shipments", EmitDefaultValue=false)]
		public List<SalesOrderShipment>? Shipments { get; set; }

		[DataMember(Name="ShippingSettings", EmitDefaultValue=false)]
		public ShippingSettings? ShippingSettings { get; set; }

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public Address? ShipToAddress { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address is overriden.
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.SO.SOBillingAddress 
		/// Display Name: Override Address 
		/// </summary>
		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressOverride { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address has been validated with a third-party specialized software or service.
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.SO.SOBillingAddress 
		/// Display Name: Validated 
		/// </summary>
		[DataMember(Name="ShipToAddressValidated", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressValidated { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact? ShipToContact { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact is overriden.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.SO.SOBillingContact 
		/// Display Name: Override Contact 
		/// </summary>
		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

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

		/// <summary>
		/// The status of the order.
		/// DAC: PX.Objects.SO.SOOrder 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<TaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The total amount of tax paid on the document (in the currency of the document).
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public Totals? Totals { get; set; }

		/// <summary>
		/// The document total that is exemptfrom VAT (in the currency of the document).
		/// DAC Field Name: CuryVatExemptTotal 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Tax Exempt Total 
		/// </summary>
		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue? VATExemptTotal { get; set; }

		/// <summary>
		/// The document total that is subjectto VAT (in the currency of the document).
		/// DAC Field Name: CuryVatTaxableTotal 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Taxable Total 
		/// </summary>
		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue? VATTaxableTotal { get; set; }

		[DataMember(Name="ExternalOrderOriginal", EmitDefaultValue=false)]
		public BooleanValue? ExternalOrderOriginal { get; set; }

		[DataMember(Name="ExternalRefundRef", EmitDefaultValue=false)]
		public StringValue? ExternalRefundRef { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the customer picks the goods from the warehouse (will call).
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Will Call 
		/// </summary>
		[DataMember(Name="WillCall", EmitDefaultValue=false)]
		public BooleanValue? WillCall { get; set; }

		/// <summary>
		/// The reference number of the payment.
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Payment Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		/// <remarks>
		/// This field is available only for sales orders of the Cash Sales or Cash Return type.
		/// </remarks>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="UsrExternalOrderOriginal", EmitDefaultValue=false)]
		public BooleanValue? UsrExternalOrderOriginal { get; set; }

		[DataMember(Name="ExternalOrderOrigin", EmitDefaultValue=false)]
		public StringValue? ExternalOrderOrigin { get; set; }

		[DataMember(Name="ExternalOrderSource", EmitDefaultValue=false)]
		public StringValue? ExternalOrderSource { get; set; }

		/// <summary>
		/// The tax calculation mode to be used for the sales order.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Tax Calculation Mode 
		/// SQL Type: char(1) 
		/// </summary>
		/// <remarks>
		/// This field is available only if theNet/Gross Entry Modefeature has been enabled on the Enable/Disable Features (CS100000) form.
		/// </remarks>
		[DataMember(Name="TaxCalcMode", EmitDefaultValue=false)]
		public StringValue? TaxCalcMode { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.EP.EPApproval 
		/// Display Name: Assignment Date 
		/// </summary>
		[DataMember(Name="CreatedDate", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}