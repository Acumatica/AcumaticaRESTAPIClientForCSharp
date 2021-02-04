using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Customer : Entity_v4
	{

		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue AccountRef { get; set; }

		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue ApplyOverdueCharges { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="AutoApplyPayments", EmitDefaultValue=false)]
		public BooleanValue AutoApplyPayments { get; set; }

		[DataMember(Name="BillingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue BillingAddressOverride { get; set; }

		[DataMember(Name="BillingContact", EmitDefaultValue=false)]
		public Contact BillingContact { get; set; }

		[DataMember(Name="BillingContactOverride", EmitDefaultValue=false)]
		public BooleanValue BillingContactOverride { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<CustomerContact> Contacts { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="CreditVerificationRules", EmitDefaultValue=false)]
		public CreditVerificationRules CreditVerificationRules { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue CurrencyRateType { get; set; }

		[DataMember(Name="CustomerClass", EmitDefaultValue=false)]
		public StringValue CustomerClass { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue CustomerID { get; set; }

		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue CustomerName { get; set; }

		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue EnableCurrencyOverride { get; set; }

		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue EnableRateOverride { get; set; }

		[DataMember(Name="EnableWriteOffs", EmitDefaultValue=false)]
		public BooleanValue EnableWriteOffs { get; set; }

		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue FOBPoint { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LeadTimedays", EmitDefaultValue=false)]
		public ShortValue LeadTimedays { get; set; }

		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue LocationName { get; set; }

		[DataMember(Name="MainContact", EmitDefaultValue=false)]
		public Contact MainContact { get; set; }

		[DataMember(Name="MultiCurrencyStatements", EmitDefaultValue=false)]
		public BooleanValue MultiCurrencyStatements { get; set; }

		[DataMember(Name="OrderPriority", EmitDefaultValue=false)]
		public ShortValue OrderPriority { get; set; }

		[DataMember(Name="ParentRecord", EmitDefaultValue=false)]
		public StringValue ParentRecord { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail> PaymentInstructions { get; set; }

		[DataMember(Name="PriceClassID", EmitDefaultValue=false)]
		public StringValue PriceClassID { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact PrimaryContact { get; set; }

		[DataMember(Name="PrintDunningLetters", EmitDefaultValue=false)]
		public BooleanValue PrintDunningLetters { get; set; }

		[DataMember(Name="PrintInvoices", EmitDefaultValue=false)]
		public BooleanValue PrintInvoices { get; set; }

		[DataMember(Name="PrintStatements", EmitDefaultValue=false)]
		public BooleanValue PrintStatements { get; set; }

		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue ResidentialDelivery { get; set; }

		[DataMember(Name="Salespersons", EmitDefaultValue=false)]
		public List<CustomerSalesPerson> Salespersons { get; set; }

		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue SaturdayDelivery { get; set; }

		[DataMember(Name="SendDunningLettersbyEmail", EmitDefaultValue=false)]
		public BooleanValue SendDunningLettersbyEmail { get; set; }

		[DataMember(Name="SendInvoicesbyEmail", EmitDefaultValue=false)]
		public BooleanValue SendInvoicesbyEmail { get; set; }

		[DataMember(Name="SendStatementsbyEmail", EmitDefaultValue=false)]
		public BooleanValue SendStatementsbyEmail { get; set; }

		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue ShippingAddressOverride { get; set; }

		[DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
		public StringValue ShippingBranch { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public Contact ShippingContact { get; set; }

		[DataMember(Name="ShippingContactOverride", EmitDefaultValue=false)]
		public BooleanValue ShippingContactOverride { get; set; }

		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue ShippingRule { get; set; }

		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue ShippingTerms { get; set; }

		[DataMember(Name="ShippingZoneID", EmitDefaultValue=false)]
		public StringValue ShippingZoneID { get; set; }

		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue ShipVia { get; set; }

		[DataMember(Name="StatementCycleID", EmitDefaultValue=false)]
		public StringValue StatementCycleID { get; set; }

		[DataMember(Name="StatementType", EmitDefaultValue=false)]
		public StringValue StatementType { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue TaxRegistrationID { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue TaxZone { get; set; }

		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue Terms { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

		[DataMember(Name="WriteOffLimit", EmitDefaultValue=false)]
		public DecimalValue WriteOffLimit { get; set; }

	}
}