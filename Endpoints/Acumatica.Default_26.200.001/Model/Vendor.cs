using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AP303000</c> in the Acumatica ERP
	/// <para>Key Fields: VendorID</para>
	/// </summary>
	[DataContract]
	public class Vendor : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The external reference number of the business account.
		/// <para>DAC Field Name: AcctReferenceNbr</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Ext. Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		/// <remarks>
		/// It can be an additional number of the business account used in external integration.            
		/// </remarks>
		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue? AccountRef { get; set; }

		/// <summary>
		/// The identifier of the AP account of the vendor location.
		/// <para>DAC Field Name: VAPAccountID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: AP Account</para>
		/// </summary>
		[DataMember(Name="APAccount", EmitDefaultValue=false)]
		public StringValue? APAccount { get; set; }

		/// <summary>
		/// The identifier of the AP subaccount of the vendor location.
		/// <para>DAC Field Name: VAPSubID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: AP Sub.</para>
		/// </summary>
		[DataMember(Name="APSubaccount", EmitDefaultValue=false)]
		public StringValue? APSubaccount { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The cash account indentifier of the vendor location.
		/// <para>DAC Field Name: VCashAccountID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<CustomerContact>? Contacts { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Created On</para>
		/// </summary>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryRateTypeID</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Curr. Rate Type</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue? CurrencyRateType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowOverrideCury</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Enable Currency Override</para>
		/// </summary>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowOverrideRate</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Enable Rate Override</para>
		/// </summary>
		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Box1099</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: 1099 Box</para>
		/// </summary>
		[DataMember(Name="F1099Box", EmitDefaultValue=false)]
		public StringValue? F1099Box { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Vendor1099</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: 1099 Vendor</para>
		/// </summary>
		[DataMember(Name="F1099Vendor", EmitDefaultValue=false)]
		public BooleanValue? F1099Vendor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// </summary>
		[DataMember(Name="FATCA", EmitDefaultValue=false)]
		public BooleanValue? FATCA { get; set; }

		/// <summary>
		/// The vendor's FOB (free on board) shipping point.
		/// <para>DAC Field Name: VFOBPointID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: FOB Point</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Foreign Entity</para>
		/// </summary>
		[DataMember(Name="ForeignEntity", EmitDefaultValue=false)]
		public BooleanValue? ForeignEntity { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Landed Cost Vendor</para>
		/// </summary>
		[DataMember(Name="LandedCostVendor", EmitDefaultValue=false)]
		public BooleanValue? LandedCostVendor { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Last Modified On</para>
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The amount of lead days (the time in days from the moment when the production was finished to the moment when the vendor's order was delivered).
		/// <para>DAC Field Name: VLeadTime</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Lead Time (Days)</para>
		/// </summary>
		[DataMember(Name="LeadTimedays", EmitDefaultValue=false)]
		public ShortValue? LeadTimedays { get; set; }

		/// <summary>
		/// The legal name of the company that is used by the1099 Reporting feature only (see Organization).
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Legal Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="LegalName", EmitDefaultValue=false)]
		public StringValue? LegalName { get; set; }

		/// <summary>
		/// The name of the location.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Location Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		[DataMember(Name="MainContact", EmitDefaultValue=false)]
		public Contact? MainContact { get; set; }

		/// <summary>
		/// The maximum receipt amount for the vendor location in percentages.
		/// <para>DAC Field Name: VRcptQtyMax</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Max. Receipt (%)</para>
		/// </summary>
		[DataMember(Name="MaxReceipt", EmitDefaultValue=false)]
		public DecimalValue? MaxReceipt { get; set; }

		/// <summary>
		/// The minimal receipt amount for the vendor location in percentages.
		/// <para>DAC Field Name: VRcptQtyMin</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Min. Receipt (%)</para>
		/// </summary>
		[DataMember(Name="MinReceipt", EmitDefaultValue=false)]
		public DecimalValue? MinReceipt { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// <para>DAC Field Name: ParentBAccountID</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Parent Account</para>
		/// </summary>
		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		/// <summary>
		/// An option that defines when a vendor should be paid at this location.
		/// <para>DAC Field Name: VPaymentByType</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Payment By</para>
		/// </summary>
		[DataMember(Name="PaymentBy", EmitDefaultValue=false)]
		public StringValue? PaymentBy { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail>? PaymentInstructions { get; set; }

		/// <summary>
		/// The amount of the payment lead days for the vendor location.
		/// <para>DAC Field Name: VPaymentLeadTime</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Payment Lead Time (Days)</para>
		/// </summary>
		[DataMember(Name="PaymentLeadTimedays", EmitDefaultValue=false)]
		public ShortValue? PaymentLeadTimedays { get; set; }

		/// <summary>
		/// The payment method indentifier of the vendor location.
		/// <para>DAC Field Name: VPaymentMethodID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// This field indicates whether a vendor should pay separately in this location.
		/// <para>DAC Field Name: VSeparateCheck</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Pay Separately</para>
		/// </summary>
		[DataMember(Name="PaySeparately", EmitDefaultValue=false)]
		public BooleanValue? PaySeparately { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact? PrimaryContact { get; set; }

		/// <summary>
		/// This field indicates whether the order an order should be printed in the vendor location.
		/// <para>DAC Field Name: VPrintOrder</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Print Order</para>
		/// </summary>
		[DataMember(Name="PrintOrders", EmitDefaultValue=false)]
		public BooleanValue? PrintOrders { get; set; }

		/// <summary>
		/// The type of the receipt action for the vendor location.
		/// <para>DAC Field Name: VRcptQtyAction</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Receipt Action</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="ReceiptAction", EmitDefaultValue=false)]
		public StringValue? ReceiptAction { get; set; }

		/// <summary>
		/// The identifier of the default branch of the vendor location.
		/// <para>DAC Field Name: VBranchID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Receiving Branch</para>
		/// </summary>
		[DataMember(Name="ReceivingBranch", EmitDefaultValue=false)]
		public StringValue? ReceivingBranch { get; set; }

		/// <summary>
		/// This field indicates whether the remit address is not the same as the default address for this location.
		/// <para>DAC Field Name: OverrideRemitAddress</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="RemittanceAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? RemittanceAddressOverride { get; set; }

		[DataMember(Name="RemittanceContact", EmitDefaultValue=false)]
		public Contact? RemittanceContact { get; set; }

		/// <summary>
		/// This field indicates whether the remit contact is not the same as the default contact for this location.
		/// <para>DAC Field Name: OverrideRemitContact</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="RemittanceContactOverride", EmitDefaultValue=false)]
		public BooleanValue? RemittanceContactOverride { get; set; }

		/// <summary>
		/// This field indicates whether the order should be sent by email in the vendor location.
		/// <para>DAC Field Name: VEmailOrder</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Email Order</para>
		/// </summary>
		[DataMember(Name="SendOrdersbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendOrdersbyEmail { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that the addressoverrides the default Contact record, which isreferenced by DefContactID.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="ShippingContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingContactOverride { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressOverride { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public Contact? ShippingContact { get; set; }

		/// <summary>
		/// The vendor's shipping terms.
		/// <para>DAC Field Name: VShipTermsID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Shipping Terms</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// The shipping carrier for the customer location.
		/// <para>DAC Field Name: VCarrierID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Ship Via</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VStatus</para>
		/// <para>DAC: PX.Objects.AP.VendorR</para>
		/// <para>Display Name: Vendor Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// The vendor's tax calculation mode.
		/// <para>DAC Field Name: VTaxCalcMode</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Calculation Mode</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue? TaxCalculationMode { get; set; }

		/// <summary>
		/// The registration ID of the company in the state tax authority.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Registration ID</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// The vendor's tax zone.
		/// <para>DAC Field Name: VTaxZoneID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TermsID</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// The threshold receipt amount for the vendor location in percentages.
		/// <para>DAC Field Name: VRcptQtyThreshold</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Threshold Receipt (%)</para>
		/// </summary>
		[DataMember(Name="ThresholdReceipt", EmitDefaultValue=false)]
		public DecimalValue? ThresholdReceipt { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorClassID</para>
		/// <para>DAC: PX.Objects.AP.VendorR</para>
		/// <para>Display Name: Vendor Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="VendorClass", EmitDefaultValue=false)]
		public StringValue? VendorClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.AP.VendorR</para>
		/// <para>Display Name: Vendor ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxAgency</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Vendor Is Tax Agency</para>
		/// </summary>
		[DataMember(Name="VendorIsTaxAgency", EmitDefaultValue=false)]
		public BooleanValue? VendorIsTaxAgency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.AP.VendorMaint+SuppliedByVendor</para>
		/// </summary>
		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// The warehouse identifier of the vendor location.
		/// <para>DAC Field Name: VSiteID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
			public const string Contacts = "Contacts";
			public const string MainContact = "MainContact";
			public const string PaymentInstructions = "PaymentInstructions";
			public const string PrimaryContact = "PrimaryContact";
			public const string RemittanceContact = "RemittanceContact";
			public const string ShippingContact = "ShippingContact";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,Contacts,MainContact,PaymentInstructions,PrimaryContact,RemittanceContact,ShippingContact";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}