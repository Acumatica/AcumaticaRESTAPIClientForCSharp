using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Vendor : Entity_v4
	{

		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue AccountRef { get; set; }

		[DataMember(Name="APAccount", EmitDefaultValue=false)]
		public StringValue APAccount { get; set; }

		[DataMember(Name="APSubaccount", EmitDefaultValue=false)]
		public StringValue APSubaccount { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue CashAccount { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<CustomerContact> Contacts { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue CurrencyRateType { get; set; }

		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue EnableCurrencyOverride { get; set; }

		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue EnableRateOverride { get; set; }

		[DataMember(Name="F1099Box", EmitDefaultValue=false)]
		public StringValue F1099Box { get; set; }

		[DataMember(Name="F1099Vendor", EmitDefaultValue=false)]
		public BooleanValue F1099Vendor { get; set; }

		[DataMember(Name="FATCA", EmitDefaultValue=false)]
		public BooleanValue FATCA { get; set; }

		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue FOBPoint { get; set; }

		[DataMember(Name="ForeignEntity", EmitDefaultValue=false)]
		public BooleanValue ForeignEntity { get; set; }

		[DataMember(Name="LandedCostVendor", EmitDefaultValue=false)]
		public BooleanValue LandedCostVendor { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LeadTimedays", EmitDefaultValue=false)]
		public ShortValue LeadTimedays { get; set; }

		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue LocationName { get; set; }

		[DataMember(Name="MainContact", EmitDefaultValue=false)]
		public Contact MainContact { get; set; }

		[DataMember(Name="MaxReceipt", EmitDefaultValue=false)]
		public DecimalValue MaxReceipt { get; set; }

		[DataMember(Name="MinReceipt", EmitDefaultValue=false)]
		public DecimalValue MinReceipt { get; set; }

		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue ParentAccount { get; set; }

		[DataMember(Name="PaymentBy", EmitDefaultValue=false)]
		public StringValue PaymentBy { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail> PaymentInstructions { get; set; }

		[DataMember(Name="PaymentLeadTimedays", EmitDefaultValue=false)]
		public ShortValue PaymentLeadTimedays { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue PaymentMethod { get; set; }

		[DataMember(Name="PaySeparately", EmitDefaultValue=false)]
		public BooleanValue PaySeparately { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact PrimaryContact { get; set; }

		[DataMember(Name="PrintOrders", EmitDefaultValue=false)]
		public BooleanValue PrintOrders { get; set; }

		[DataMember(Name="ReceiptAction", EmitDefaultValue=false)]
		public StringValue ReceiptAction { get; set; }

		[DataMember(Name="ReceivingBranch", EmitDefaultValue=false)]
		public StringValue ReceivingBranch { get; set; }

		[DataMember(Name="RemittanceAddressOverride", EmitDefaultValue=false)]
		public BooleanValue RemittanceAddressOverride { get; set; }

		[DataMember(Name="RemittanceContact", EmitDefaultValue=false)]
		public Contact RemittanceContact { get; set; }

		[DataMember(Name="RemittanceContactOverride", EmitDefaultValue=false)]
		public BooleanValue RemittanceContactOverride { get; set; }

		[DataMember(Name="SendOrdersbyEmail", EmitDefaultValue=false)]
		public BooleanValue SendOrdersbyEmail { get; set; }

		[DataMember(Name="ShippingContactOverride", EmitDefaultValue=false)]
		public BooleanValue ShippingContactOverride { get; set; }

		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue ShippingAddressOverride { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public Contact ShippingContact { get; set; }

		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue ShippingTerms { get; set; }

		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue ShipVia { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue TaxCalculationMode { get; set; }

		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue TaxRegistrationID { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue TaxZone { get; set; }

		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue Terms { get; set; }

		[DataMember(Name="ThresholdReceipt", EmitDefaultValue=false)]
		public DecimalValue ThresholdReceipt { get; set; }

		[DataMember(Name="VendorClass", EmitDefaultValue=false)]
		public StringValue VendorClass { get; set; }

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue VendorID { get; set; }

		[DataMember(Name="VendorIsLaborUnion", EmitDefaultValue=false)]
		public BooleanValue VendorIsLaborUnion { get; set; }

		[DataMember(Name="VendorIsTaxAgency", EmitDefaultValue=false)]
		public BooleanValue VendorIsTaxAgency { get; set; }

		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue VendorName { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}