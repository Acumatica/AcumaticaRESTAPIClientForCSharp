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
	/// Corresponds to the screen <c>AR303000</c> in the Acumatica ERP
	/// <para>Key Fields: CustomerID</para>
	/// </summary>
	[DataContract]
	public class Customer : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The external reference number of the business account.
		/// <para>DAC Field Name: AcctReferenceNbr</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Ext. Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		/// <remarks>
		/// It can be an additional number of the business account used in external integration.            
		/// </remarks>
		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue? AccountRef { get; set; }

		/// <summary>
		/// If set to true, indicates that financial chargescan be calculated for the customer.
		/// <para>DAC Field Name: FinChargeApply</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Apply Overdue Charges</para>
		/// </summary>
		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue? ApplyOverdueCharges { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// If set to true, indicates that the payments of the customershould be automatically applied to the open invoices upon release.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Auto-Apply Payments</para>
		/// </summary>
		[DataMember(Name="AutoApplyPayments", EmitDefaultValue=false)]
		public BooleanValue? AutoApplyPayments { get; set; }

		/// <summary>
		/// The identifier of the related business account.Along with ContactID, this field is used as an additional reference,but unlike RefNoteID and DocumentNoteID it is used for specific entities.
		/// <para>DAC: PX.Objects.CR.CRPMTimeActivity</para>
		/// <para>Display Name: Related Account</para>
		/// </summary>
		[DataMember(Name="BAccountID", EmitDefaultValue=false)]
		public IntValue? BAccountID { get; set; }

		/// <summary>
		/// A calculated field. If set to false, indicates thatthe customer's billing address is the same as the customer'sdefault address.The field is populated by a formula, working only in the scope of the Customers (AR303000) form. See CustomerBillSharedAddressOverrideGraphExt"
		/// <para>DAC Field Name: OverrideBillAddress</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="BillingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? BillingAddressOverride { get; set; }

		[DataMember(Name="BillingContact", EmitDefaultValue=false)]
		public Contact? BillingContact { get; set; }

		/// <summary>
		/// A calculated field. If set to false, indicates that the customer's billing contact is the same as the customer'sdefault contact.The field is populated by a formula, working only in the scope of the Customers (AR303000) form. See CustomerBillSharedContactOverrideGraphExt"
		/// <para>DAC Field Name: OverrideBillContact</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="BillingContactOverride", EmitDefaultValue=false)]
		public BooleanValue? BillingContactOverride { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<CustomerContact>? Contacts { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Created On</para>
		/// </summary>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="CreditVerificationRules", EmitDefaultValue=false)]
		public CreditVerificationRules? CreditVerificationRules { get; set; }

		/// <summary>
		/// The identifier of the Currency,which is applied to the documents of the customer.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The identifier of the currency rate type,which is applied to the documents of the customer.
		/// <para>DAC Field Name: CuryRateTypeID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Curr. Rate Type</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue? CurrencyRateType { get; set; }

		/// <summary>
		/// Identifier of the customer class to which the customer belongs.
		/// <para>DAC Field Name: CustomerClassID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Customer Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="CustomerClass", EmitDefaultValue=false)]
		public StringValue? CustomerClass { get; set; }

		/// <summary>
		/// The human-readable identifier of the customer account, which isspecified by the user or defined by the auto-numbering sequence duringcreation of the customer. This field is a natural key, as opposedto the surrogate key BAccountID.
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Customer ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The customer kind, indicating whether the customer is an individual (I) or an organization (O).
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Customer Category</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="CustomerCategory", EmitDefaultValue=false)]
		public StringValue? CustomerCategory { get; set; }

		/// <summary>
		/// The full business account name (as opposed to the short identifier provided by AcctCD).
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Customer Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.NotificationRecipient</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// If set to true, indicates that the currency of customer documents (which is specified by CuryID)can be overridden by a user during document entry.
		/// <para>DAC Field Name: AllowOverrideCury</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Enable Currency Override</para>
		/// </summary>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// If set to true, indicates that the currency ratefor customer documents (which is calculated by the system from the currency rate history) can be overridden by a user during document entry.
		/// <para>DAC Field Name: AllowOverrideRate</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Enable Rate Override</para>
		/// </summary>
		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// If set to true, indicates that small balancewrite-offs are allowed for the customer.
		/// <para>DAC Field Name: SmallBalanceAllow</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Enable Write-Offs</para>
		/// </summary>
		[DataMember(Name="EnableWriteOffs", EmitDefaultValue=false)]
		public BooleanValue? EnableWriteOffs { get; set; }

		/// <summary>
		/// The customer's FOB (free on board) shipping point.
		/// <para>DAC Field Name: CFOBPointID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: FOB Point</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Last Modified On</para>
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The amount of lead days (the time in days from the moment when the production was finished to the moment when the customer's order was delivered).
		/// <para>DAC Field Name: CLeadTime</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Lead Time (Days)</para>
		/// </summary>
		[DataMember(Name="LeadTimedays", EmitDefaultValue=false)]
		public ShortValue? LeadTimedays { get; set; }

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
		/// If set to true, indicates that customerstatements should be generated for the customer in multi-currency format.
		/// <para>DAC Field Name: PrintCuryStatements</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Multi-Currency Statements</para>
		/// </summary>
		[DataMember(Name="MultiCurrencyStatements", EmitDefaultValue=false)]
		public BooleanValue? MultiCurrencyStatements { get; set; }

		/// <summary>
		/// The order priority of the customer's location.
		/// <para>DAC Field Name: COrderPriority</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Order Priority</para>
		/// </summary>
		[DataMember(Name="OrderPriority", EmitDefaultValue=false)]
		public ShortValue? OrderPriority { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// <para>DAC Field Name: ParentBAccountID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Parent Account</para>
		/// </summary>
		[DataMember(Name="ParentRecord", EmitDefaultValue=false)]
		public StringValue? ParentRecord { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail>? PaymentInstructions { get; set; }

		/// <summary>
		/// The price class of the customer.
		/// <para>DAC Field Name: CPriceClassID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Price Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="PriceClassID", EmitDefaultValue=false)]
		public StringValue? PriceClassID { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact? PrimaryContact { get; set; }

		/// <summary>
		/// The identifier of the Contact object linked with the business account and marked as primary.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Primary Contact</para>
		/// </summary>
		/// <remarks>
		/// Also, the Contact.BAccountID value must equal tothe BAccount.BAccountID value of the current business account.
		/// </remarks>
		[DataMember(Name="PrimaryContactID", EmitDefaultValue=false)]
		public IntValue? PrimaryContactID { get; set; }

		/// <summary>
		/// If set to true, indicates that dunning letters should be printed for the customer.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Print Dunning Letters</para>
		/// </summary>
		[DataMember(Name="PrintDunningLetters", EmitDefaultValue=false)]
		public BooleanValue? PrintDunningLetters { get; set; }

		/// <summary>
		/// If set to true, indicates that invoicesshould be printed for the customer.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Print Invoices</para>
		/// </summary>
		[DataMember(Name="PrintInvoices", EmitDefaultValue=false)]
		public BooleanValue? PrintInvoices { get; set; }

		/// <summary>
		/// If set to true, indicates that customerstatements should be printed for the customer.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Print Statements</para>
		/// </summary>
		[DataMember(Name="PrintStatements", EmitDefaultValue=false)]
		public BooleanValue? PrintStatements { get; set; }

		/// <summary>
		/// This field indicates whether the residential delivery is available in this location.
		/// <para>DAC Field Name: CResedential</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Residential Delivery</para>
		/// </summary>
		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		[DataMember(Name="Salespersons", EmitDefaultValue=false)]
		public List<CustomerSalesPerson>? Salespersons { get; set; }

		/// <summary>
		/// This field indicates whether the Saturday delivery is available in this location.
		/// <para>DAC Field Name: CSaturdayDelivery</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Saturday Delivery</para>
		/// </summary>
		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// If set to true, indicates that dunning letters should be sent to the customer by email.
		/// <para>DAC Field Name: MailDunningLetters</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Send Dunning Letters by Email</para>
		/// </summary>
		[DataMember(Name="SendDunningLettersbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendDunningLettersbyEmail { get; set; }

		/// <summary>
		/// If set to true, indicates that invoicesshould be sent to the customer by email.
		/// <para>DAC Field Name: MailInvoices</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Send Invoices by Email</para>
		/// </summary>
		[DataMember(Name="SendInvoicesbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendInvoicesbyEmail { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SendStatementByEmail</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Send Statements by Email</para>
		/// </summary>
		[DataMember(Name="SendStatementsbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendStatementsbyEmail { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressOverride { get; set; }

		/// <summary>
		/// The identifier of the default branch of the customer location.
		/// <para>DAC Field Name: CBranchID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Shipping Branch</para>
		/// </summary>
		[DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
		public StringValue? ShippingBranch { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public Contact? ShippingContact { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Contact record, which isreferenced by DefContactID.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="ShippingContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingContactOverride { get; set; }

		/// <summary>
		/// The shipping rule of the customer location.
		/// <para>DAC Field Name: CShipComplete</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Shipping Rule</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// The customer's shipping terms.
		/// <para>DAC Field Name: CShipTermsID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Shipping Terms</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// The customer's shipping zone.
		/// <para>DAC Field Name: CShipZoneID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Shipping Zone</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ShippingZoneID", EmitDefaultValue=false)]
		public StringValue? ShippingZoneID { get; set; }

		/// <summary>
		/// The shipping carrier for the vendor location.
		/// <para>DAC Field Name: CCarrierID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Ship Via</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// The identifier of the statement cycleto which the customer is assigned.
		/// <para>DAC Field Name: StatementCycleId</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Statement Cycle ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="StatementCycleID", EmitDefaultValue=false)]
		public StringValue? StatementCycleID { get; set; }

		/// <summary>
		/// The type of customer statements generated for the customer.The list of possible values of the field is determined by StatementTypeAttribute.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Statement Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="StatementType", EmitDefaultValue=false)]
		public StringValue? StatementType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Customer Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The registration ID of the company in the state tax authority.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Registration ID</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// The customer's tax zone.
		/// <para>DAC Field Name: CTaxZoneID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// The identifier of the default terms, which are applied to the documents of the customer.
		/// <para>DAC Field Name: TermsID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// The warehouse identifier of the customer location.
		/// <para>DAC Field Name: CSiteID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// If SmallBalanceAllow is set to true, thefield determines the maximum small balance write-off limit for customer documents.
		/// <para>DAC Field Name: SmallBalanceLimit</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Write-Off Limit</para>
		/// </summary>
		[DataMember(Name="WriteOffLimit", EmitDefaultValue=false)]
		public DecimalValue? WriteOffLimit { get; set; }

		/// <summary>
		/// <para>DAC Field Name: COrgBAccountID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Restrict Visibility To</para>
		/// </summary>
		[DataMember(Name="RestrictVisibilityTo", EmitDefaultValue=false)]
		public StringValue? RestrictVisibilityTo { get; set; }

		/// <summary>
		/// If CreditRule enables verification by credit limit,this field determines the maximum amount of credit allowed for the customer.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Credit Limit</para>
		/// </summary>
		[DataMember(Name="CreditLimit", EmitDefaultValue=false)]
		public DecimalValue? CreditLimit { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// The customer's entity type for reporting purposes. This field is used if the system is integrated with External Tax Calculationand the External Tax Calculation Integration feature is enabled.
		/// <para>DAC Field Name: CAvalaraCustomerUsageType</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Exemption Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// The Avalara Exemption number of the customer location.
		/// <para>DAC Field Name: CAvalaraExemptionNumber</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Exemption Number</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="TaxExemptionNumber", EmitDefaultValue=false)]
		public StringValue? TaxExemptionNumber { get; set; }

		[DataMember(Name="IsGuestCustomer", EmitDefaultValue=false)]
		public BooleanValue? IsGuestCustomer { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Attributes = "Attributes";
			public const string BillingContact = "BillingContact";
			public const string BillingContact_Activities = "BillingContact/Activities";
			public const string BillingContact_Activities_Files = "BillingContact/Activities/Files";
			public const string BillingContact_Address = "BillingContact/Address";
			public const string BillingContact_Attributes = "BillingContact/Attributes";
			public const string BillingContact_Campaigns = "BillingContact/Campaigns";
			public const string BillingContact_Campaigns_Files = "BillingContact/Campaigns/Files";
			public const string BillingContact_Cases = "BillingContact/Cases";
			public const string BillingContact_Cases_Files = "BillingContact/Cases/Files";
			public const string BillingContact_Duplicates = "BillingContact/Duplicates";
			public const string BillingContact_Duplicates_Files = "BillingContact/Duplicates/Files";
			public const string BillingContact_MarketingLists = "BillingContact/MarketingLists";
			public const string BillingContact_MarketingLists_Files = "BillingContact/MarketingLists/Files";
			public const string BillingContact_Notifications = "BillingContact/Notifications";
			public const string BillingContact_Notifications_Files = "BillingContact/Notifications/Files";
			public const string BillingContact_Opportunities = "BillingContact/Opportunities";
			public const string BillingContact_Opportunities_Files = "BillingContact/Opportunities/Files";
			public const string BillingContact_Relations = "BillingContact/Relations";
			public const string BillingContact_Relations_Files = "BillingContact/Relations/Files";
			public const string BillingContact_RoleAssignments = "BillingContact/RoleAssignments";
			public const string BillingContact_RoleAssignments_Files = "BillingContact/RoleAssignments/Files";
			public const string BillingContact_UserInfo = "BillingContact/UserInfo";
			public const string BillingContact_UserInfo_Roles = "BillingContact/UserInfo/Roles";
			public const string BillingContact_UserInfo_Roles_Files = "BillingContact/UserInfo/Roles/Files";
			public const string Contacts = "Contacts";
			public const string Contacts_Files = "Contacts/Files";
			public const string Contacts_Contact = "Contacts/Contact";
			public const string Contacts_Contact_Activities = "Contacts/Contact/Activities";
			public const string Contacts_Contact_Activities_Files = "Contacts/Contact/Activities/Files";
			public const string Contacts_Contact_Address = "Contacts/Contact/Address";
			public const string Contacts_Contact_Attributes = "Contacts/Contact/Attributes";
			public const string Contacts_Contact_Campaigns = "Contacts/Contact/Campaigns";
			public const string Contacts_Contact_Campaigns_Files = "Contacts/Contact/Campaigns/Files";
			public const string Contacts_Contact_Cases = "Contacts/Contact/Cases";
			public const string Contacts_Contact_Cases_Files = "Contacts/Contact/Cases/Files";
			public const string Contacts_Contact_Duplicates = "Contacts/Contact/Duplicates";
			public const string Contacts_Contact_Duplicates_Files = "Contacts/Contact/Duplicates/Files";
			public const string Contacts_Contact_MarketingLists = "Contacts/Contact/MarketingLists";
			public const string Contacts_Contact_MarketingLists_Files = "Contacts/Contact/MarketingLists/Files";
			public const string Contacts_Contact_Notifications = "Contacts/Contact/Notifications";
			public const string Contacts_Contact_Notifications_Files = "Contacts/Contact/Notifications/Files";
			public const string Contacts_Contact_Opportunities = "Contacts/Contact/Opportunities";
			public const string Contacts_Contact_Opportunities_Files = "Contacts/Contact/Opportunities/Files";
			public const string Contacts_Contact_Relations = "Contacts/Contact/Relations";
			public const string Contacts_Contact_Relations_Files = "Contacts/Contact/Relations/Files";
			public const string Contacts_Contact_RoleAssignments = "Contacts/Contact/RoleAssignments";
			public const string Contacts_Contact_RoleAssignments_Files = "Contacts/Contact/RoleAssignments/Files";
			public const string Contacts_Contact_UserInfo = "Contacts/Contact/UserInfo";
			public const string Contacts_Contact_UserInfo_Roles = "Contacts/Contact/UserInfo/Roles";
			public const string Contacts_Contact_UserInfo_Roles_Files = "Contacts/Contact/UserInfo/Roles/Files";
			public const string CreditVerificationRules = "CreditVerificationRules";
			public const string MainContact = "MainContact";
			public const string MainContact_Activities = "MainContact/Activities";
			public const string MainContact_Activities_Files = "MainContact/Activities/Files";
			public const string MainContact_Address = "MainContact/Address";
			public const string MainContact_Attributes = "MainContact/Attributes";
			public const string MainContact_Campaigns = "MainContact/Campaigns";
			public const string MainContact_Campaigns_Files = "MainContact/Campaigns/Files";
			public const string MainContact_Cases = "MainContact/Cases";
			public const string MainContact_Cases_Files = "MainContact/Cases/Files";
			public const string MainContact_Duplicates = "MainContact/Duplicates";
			public const string MainContact_Duplicates_Files = "MainContact/Duplicates/Files";
			public const string MainContact_MarketingLists = "MainContact/MarketingLists";
			public const string MainContact_MarketingLists_Files = "MainContact/MarketingLists/Files";
			public const string MainContact_Notifications = "MainContact/Notifications";
			public const string MainContact_Notifications_Files = "MainContact/Notifications/Files";
			public const string MainContact_Opportunities = "MainContact/Opportunities";
			public const string MainContact_Opportunities_Files = "MainContact/Opportunities/Files";
			public const string MainContact_Relations = "MainContact/Relations";
			public const string MainContact_Relations_Files = "MainContact/Relations/Files";
			public const string MainContact_RoleAssignments = "MainContact/RoleAssignments";
			public const string MainContact_RoleAssignments_Files = "MainContact/RoleAssignments/Files";
			public const string MainContact_UserInfo = "MainContact/UserInfo";
			public const string MainContact_UserInfo_Roles = "MainContact/UserInfo/Roles";
			public const string MainContact_UserInfo_Roles_Files = "MainContact/UserInfo/Roles/Files";
			public const string PaymentInstructions = "PaymentInstructions";
			public const string PaymentInstructions_Files = "PaymentInstructions/Files";
			public const string PrimaryContact = "PrimaryContact";
			public const string PrimaryContact_Activities = "PrimaryContact/Activities";
			public const string PrimaryContact_Activities_Files = "PrimaryContact/Activities/Files";
			public const string PrimaryContact_Address = "PrimaryContact/Address";
			public const string PrimaryContact_Attributes = "PrimaryContact/Attributes";
			public const string PrimaryContact_Campaigns = "PrimaryContact/Campaigns";
			public const string PrimaryContact_Campaigns_Files = "PrimaryContact/Campaigns/Files";
			public const string PrimaryContact_Cases = "PrimaryContact/Cases";
			public const string PrimaryContact_Cases_Files = "PrimaryContact/Cases/Files";
			public const string PrimaryContact_Duplicates = "PrimaryContact/Duplicates";
			public const string PrimaryContact_Duplicates_Files = "PrimaryContact/Duplicates/Files";
			public const string PrimaryContact_MarketingLists = "PrimaryContact/MarketingLists";
			public const string PrimaryContact_MarketingLists_Files = "PrimaryContact/MarketingLists/Files";
			public const string PrimaryContact_Notifications = "PrimaryContact/Notifications";
			public const string PrimaryContact_Notifications_Files = "PrimaryContact/Notifications/Files";
			public const string PrimaryContact_Opportunities = "PrimaryContact/Opportunities";
			public const string PrimaryContact_Opportunities_Files = "PrimaryContact/Opportunities/Files";
			public const string PrimaryContact_Relations = "PrimaryContact/Relations";
			public const string PrimaryContact_Relations_Files = "PrimaryContact/Relations/Files";
			public const string PrimaryContact_RoleAssignments = "PrimaryContact/RoleAssignments";
			public const string PrimaryContact_RoleAssignments_Files = "PrimaryContact/RoleAssignments/Files";
			public const string PrimaryContact_UserInfo = "PrimaryContact/UserInfo";
			public const string PrimaryContact_UserInfo_Roles = "PrimaryContact/UserInfo/Roles";
			public const string PrimaryContact_UserInfo_Roles_Files = "PrimaryContact/UserInfo/Roles/Files";
			public const string Salespersons = "Salespersons";
			public const string Salespersons_Files = "Salespersons/Files";
			public const string ShippingContact = "ShippingContact";
			public const string ShippingContact_Activities = "ShippingContact/Activities";
			public const string ShippingContact_Activities_Files = "ShippingContact/Activities/Files";
			public const string ShippingContact_Address = "ShippingContact/Address";
			public const string ShippingContact_Attributes = "ShippingContact/Attributes";
			public const string ShippingContact_Campaigns = "ShippingContact/Campaigns";
			public const string ShippingContact_Campaigns_Files = "ShippingContact/Campaigns/Files";
			public const string ShippingContact_Cases = "ShippingContact/Cases";
			public const string ShippingContact_Cases_Files = "ShippingContact/Cases/Files";
			public const string ShippingContact_Duplicates = "ShippingContact/Duplicates";
			public const string ShippingContact_Duplicates_Files = "ShippingContact/Duplicates/Files";
			public const string ShippingContact_MarketingLists = "ShippingContact/MarketingLists";
			public const string ShippingContact_MarketingLists_Files = "ShippingContact/MarketingLists/Files";
			public const string ShippingContact_Notifications = "ShippingContact/Notifications";
			public const string ShippingContact_Notifications_Files = "ShippingContact/Notifications/Files";
			public const string ShippingContact_Opportunities = "ShippingContact/Opportunities";
			public const string ShippingContact_Opportunities_Files = "ShippingContact/Opportunities/Files";
			public const string ShippingContact_Relations = "ShippingContact/Relations";
			public const string ShippingContact_Relations_Files = "ShippingContact/Relations/Files";
			public const string ShippingContact_RoleAssignments = "ShippingContact/RoleAssignments";
			public const string ShippingContact_RoleAssignments_Files = "ShippingContact/RoleAssignments/Files";
			public const string ShippingContact_UserInfo = "ShippingContact/UserInfo";
			public const string ShippingContact_UserInfo_Roles = "ShippingContact/UserInfo/Roles";
			public const string ShippingContact_UserInfo_Roles_Files = "ShippingContact/UserInfo/Roles/Files";

			//Intentionally excluded
			//public const string All = "Files,Attributes,BillingContact,BillingContact/Activities,BillingContact/Activities/Files,BillingContact/Address,BillingContact/Attributes,BillingContact/Campaigns,BillingContact/Campaigns/Files,BillingContact/Cases,BillingContact/Cases/Files,BillingContact/Duplicates,BillingContact/Duplicates/Files,BillingContact/MarketingLists,BillingContact/MarketingLists/Files,BillingContact/Notifications,BillingContact/Notifications/Files,BillingContact/Opportunities,BillingContact/Opportunities/Files,BillingContact/Relations,BillingContact/Relations/Files,BillingContact/RoleAssignments,BillingContact/RoleAssignments/Files,BillingContact/UserInfo,BillingContact/UserInfo/Roles,BillingContact/UserInfo/Roles/Files,Contacts,Contacts/Files,Contacts/Contact,Contacts/Contact/Activities,Contacts/Contact/Activities/Files,Contacts/Contact/Address,Contacts/Contact/Attributes,Contacts/Contact/Campaigns,Contacts/Contact/Campaigns/Files,Contacts/Contact/Cases,Contacts/Contact/Cases/Files,Contacts/Contact/Duplicates,Contacts/Contact/Duplicates/Files,Contacts/Contact/MarketingLists,Contacts/Contact/MarketingLists/Files,Contacts/Contact/Notifications,Contacts/Contact/Notifications/Files,Contacts/Contact/Opportunities,Contacts/Contact/Opportunities/Files,Contacts/Contact/Relations,Contacts/Contact/Relations/Files,Contacts/Contact/RoleAssignments,Contacts/Contact/RoleAssignments/Files,Contacts/Contact/UserInfo,Contacts/Contact/UserInfo/Roles,Contacts/Contact/UserInfo/Roles/Files,CreditVerificationRules,MainContact,MainContact/Activities,MainContact/Activities/Files,MainContact/Address,MainContact/Attributes,MainContact/Campaigns,MainContact/Campaigns/Files,MainContact/Cases,MainContact/Cases/Files,MainContact/Duplicates,MainContact/Duplicates/Files,MainContact/MarketingLists,MainContact/MarketingLists/Files,MainContact/Notifications,MainContact/Notifications/Files,MainContact/Opportunities,MainContact/Opportunities/Files,MainContact/Relations,MainContact/Relations/Files,MainContact/RoleAssignments,MainContact/RoleAssignments/Files,MainContact/UserInfo,MainContact/UserInfo/Roles,MainContact/UserInfo/Roles/Files,PaymentInstructions,PaymentInstructions/Files,PrimaryContact,PrimaryContact/Activities,PrimaryContact/Activities/Files,PrimaryContact/Address,PrimaryContact/Attributes,PrimaryContact/Campaigns,PrimaryContact/Campaigns/Files,PrimaryContact/Cases,PrimaryContact/Cases/Files,PrimaryContact/Duplicates,PrimaryContact/Duplicates/Files,PrimaryContact/MarketingLists,PrimaryContact/MarketingLists/Files,PrimaryContact/Notifications,PrimaryContact/Notifications/Files,PrimaryContact/Opportunities,PrimaryContact/Opportunities/Files,PrimaryContact/Relations,PrimaryContact/Relations/Files,PrimaryContact/RoleAssignments,PrimaryContact/RoleAssignments/Files,PrimaryContact/UserInfo,PrimaryContact/UserInfo/Roles,PrimaryContact/UserInfo/Roles/Files,Salespersons,Salespersons/Files,ShippingContact,ShippingContact/Activities,ShippingContact/Activities/Files,ShippingContact/Address,ShippingContact/Attributes,ShippingContact/Campaigns,ShippingContact/Campaigns/Files,ShippingContact/Cases,ShippingContact/Cases/Files,ShippingContact/Duplicates,ShippingContact/Duplicates/Files,ShippingContact/MarketingLists,ShippingContact/MarketingLists/Files,ShippingContact/Notifications,ShippingContact/Notifications/Files,ShippingContact/Opportunities,ShippingContact/Opportunities/Files,ShippingContact/Relations,ShippingContact/Relations/Files,ShippingContact/RoleAssignments,ShippingContact/RoleAssignments/Files,ShippingContact/UserInfo,ShippingContact/UserInfo/Roles,ShippingContact/UserInfo/Roles/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}