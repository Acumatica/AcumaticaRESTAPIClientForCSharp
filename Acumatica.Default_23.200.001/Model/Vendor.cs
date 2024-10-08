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
	/// Corresponds to the screen AP303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Vendor : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The external reference number of the business account.
		/// DAC Field Name: AcctReferenceNbr 
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: Ext Ref Nbr 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		/// <remarks>
		/// It can be an additional number of the business account used in external integration.            
		/// </remarks>
		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue? AccountRef { get; set; }

		/// <summary>
		/// The identifier of the AP account of the vendor location.
		/// DAC Field Name: VAPAccountID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: AP Account 
		/// </summary>
		[DataMember(Name="APAccount", EmitDefaultValue=false)]
		public StringValue? APAccount { get; set; }

		/// <summary>
		/// The identifier of the AP subaccount of the vendor location.
		/// DAC Field Name: VAPSubID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: AP Sub. 
		/// </summary>
		[DataMember(Name="APSubaccount", EmitDefaultValue=false)]
		public StringValue? APSubaccount { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The cash account indentifier of the vendor location.
		/// DAC Field Name: VCashAccountID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<CustomerContact>? Contacts { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: Curr. Rate Type 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue? CurrencyRateType { get; set; }

		/// <summary>
		/// DAC Field Name: AllowOverrideCury 
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: Enable Currency Override 
		/// </summary>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// DAC Field Name: AllowOverrideRate 
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: Enable Rate Override 
		/// </summary>
		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// DAC Field Name: Box1099 
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: 1099 Box 
		/// </summary>
		[DataMember(Name="F1099Box", EmitDefaultValue=false)]
		public StringValue? F1099Box { get; set; }

		/// <summary>
		/// DAC Field Name: Vendor1099 
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: 1099 Vendor 
		/// </summary>
		[DataMember(Name="F1099Vendor", EmitDefaultValue=false)]
		public BooleanValue? F1099Vendor { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AP.Vendor 
		/// </summary>
		[DataMember(Name="FATCA", EmitDefaultValue=false)]
		public BooleanValue? FATCA { get; set; }

		/// <summary>
		/// The vendor's FOB (free on board) shipping point.
		/// DAC Field Name: VFOBPointID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: FOB Point 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: Foreign Entity 
		/// </summary>
		[DataMember(Name="ForeignEntity", EmitDefaultValue=false)]
		public BooleanValue? ForeignEntity { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: Landed Cost Vendor 
		/// </summary>
		[DataMember(Name="LandedCostVendor", EmitDefaultValue=false)]
		public BooleanValue? LandedCostVendor { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The amount of lead days (the time in days from the moment when the production was finished to the moment when the vendor's order was delivered).
		/// DAC Field Name: VLeadTime 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Lead Time (Days) 
		/// </summary>
		[DataMember(Name="LeadTimedays", EmitDefaultValue=false)]
		public ShortValue? LeadTimedays { get; set; }

		/// <summary>
		/// The legal name of the company that is used by the1099 Reporting feature only (see Organization).
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: Legal Name 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="LegalName", EmitDefaultValue=false)]
		public StringValue? LegalName { get; set; }

		/// <summary>
		/// The name of the location.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Location Name 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		[DataMember(Name="MainContact", EmitDefaultValue=false)]
		public Contact? MainContact { get; set; }

		/// <summary>
		/// The maximum receipt amount for the vendor location in percentages.
		/// DAC Field Name: VRcptQtyMax 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Max. Receipt (%) 
		/// </summary>
		[DataMember(Name="MaxReceipt", EmitDefaultValue=false)]
		public DecimalValue? MaxReceipt { get; set; }

		/// <summary>
		/// The minimal receipt amount for the vendor location in percentages.
		/// DAC Field Name: VRcptQtyMin 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Min. Receipt (%) 
		/// </summary>
		[DataMember(Name="MinReceipt", EmitDefaultValue=false)]
		public DecimalValue? MinReceipt { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// DAC Field Name: ParentBAccountID 
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: Parent Account 
		/// </summary>
		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		/// <summary>
		/// An option that defines when a vendor should be paid at this location.
		/// DAC Field Name: VPaymentByType 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Payment By 
		/// </summary>
		[DataMember(Name="PaymentBy", EmitDefaultValue=false)]
		public StringValue? PaymentBy { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail>? PaymentInstructions { get; set; }

		/// <summary>
		/// The amount of the payment lead days for the vendor location.
		/// DAC Field Name: VPaymentLeadTime 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Payment Lead Time (Days) 
		/// </summary>
		[DataMember(Name="PaymentLeadTimedays", EmitDefaultValue=false)]
		public ShortValue? PaymentLeadTimedays { get; set; }

		/// <summary>
		/// The payment method indentifier of the vendor location.
		/// DAC Field Name: VPaymentMethodID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Payment Method 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// This field indicates whether a vendor should pay separately in this location.
		/// DAC Field Name: VSeparateCheck 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Pay Separately 
		/// </summary>
		[DataMember(Name="PaySeparately", EmitDefaultValue=false)]
		public BooleanValue? PaySeparately { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact? PrimaryContact { get; set; }

		/// <summary>
		/// This field indicates whether the order an order should be printed in the vendor location.
		/// DAC Field Name: VPrintOrder 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Print Order 
		/// </summary>
		[DataMember(Name="PrintOrders", EmitDefaultValue=false)]
		public BooleanValue? PrintOrders { get; set; }

		/// <summary>
		/// The type of the receipt action for the vendor location.
		/// DAC Field Name: VRcptQtyAction 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Receipt Action 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ReceiptAction", EmitDefaultValue=false)]
		public StringValue? ReceiptAction { get; set; }

		/// <summary>
		/// The identifier of the default branch of the vendor location.
		/// DAC Field Name: VBranchID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Receiving Branch 
		/// </summary>
		[DataMember(Name="ReceivingBranch", EmitDefaultValue=false)]
		public StringValue? ReceivingBranch { get; set; }

		/// <summary>
		/// This field indicates whether the remit address is not the same as the default address for this location.
		/// DAC Field Name: OverrideRemitAddress 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="RemittanceAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? RemittanceAddressOverride { get; set; }

		[DataMember(Name="RemittanceContact", EmitDefaultValue=false)]
		public Contact? RemittanceContact { get; set; }

		/// <summary>
		/// This field indicates whether the remit contact is not the same as the default contact for this location.
		/// DAC Field Name: OverrideRemitContact 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="RemittanceContactOverride", EmitDefaultValue=false)]
		public BooleanValue? RemittanceContactOverride { get; set; }

		/// <summary>
		/// This field indicates whether the order should be sent by email in the vendor location.
		/// DAC Field Name: VEmailOrder 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Email Order 
		/// </summary>
		[DataMember(Name="SendOrdersbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendOrdersbyEmail { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Contact record, which isreferenced by DefContactID.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="ShippingContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingContactOverride { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressOverride { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public Contact? ShippingContact { get; set; }

		/// <summary>
		/// The vendor's shipping terms.
		/// DAC Field Name: VShipTermsID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Shipping Terms 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// The shipping carrier for the customer location.
		/// DAC Field Name: VCarrierID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Ship Via 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// DAC Field Name: VStatus 
		/// DAC: PX.Objects.AP.VendorR 
		/// Display Name: Vendor Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The vendor's tax calculation mode.
		/// DAC Field Name: VTaxCalcMode 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Tax Calculation Mode 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue? TaxCalculationMode { get; set; }

		/// <summary>
		/// The registration ID of the company in the state tax authority.
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Tax Registration ID 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// The vendor's tax zone.
		/// DAC Field Name: VTaxZoneID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.AP.Vendor 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// The threshold receipt amount for the vendor location in percentages.
		/// DAC Field Name: VRcptQtyThreshold 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Threshold Receipt (%) 
		/// </summary>
		[DataMember(Name="ThresholdReceipt", EmitDefaultValue=false)]
		public DecimalValue? ThresholdReceipt { get; set; }

		/// <summary>
		/// DAC Field Name: VendorClassID 
		/// DAC: PX.Objects.AP.VendorR 
		/// Display Name: Vendor Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="VendorClass", EmitDefaultValue=false)]
		public StringValue? VendorClass { get; set; }

		/// <summary>
		/// DAC Field Name: AcctCD 
		/// DAC: PX.Objects.AP.VendorR 
		/// Display Name: Vendor ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// DAC Field Name: IsLaborUnion 
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: Vendor Is Labor Union 
		/// </summary>
		[DataMember(Name="VendorIsLaborUnion", EmitDefaultValue=false)]
		public BooleanValue? VendorIsLaborUnion { get; set; }

		/// <summary>
		/// DAC Field Name: TaxAgency 
		/// DAC: PX.Objects.AP.Vendor 
		/// Display Name: Vendor Is Tax Agency 
		/// </summary>
		[DataMember(Name="VendorIsTaxAgency", EmitDefaultValue=false)]
		public BooleanValue? VendorIsTaxAgency { get; set; }

		/// <summary>
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.AP.VendorMaint+SuppliedByVendor 
		/// </summary>
		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// The warehouse identifier of the vendor location.
		/// DAC Field Name: VSiteID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}