using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR303000</c> in the Acumatica ERP
	/// <para>Key Fields: CustomerID</para>
	/// </summary>
	public class Customer : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// The human-readable identifier of the customer account, which isspecified by the user or defined by the auto-numbering sequence duringcreation of the customer. This field is a natural key, as opposedto the surrogate key BAccountID.
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Customer ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Customer Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// Identifier of the customer class to which the customer belongs.
		/// <para>DAC Field Name: CustomerClassID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Customer Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? CustomerClass { get; set; }

		/// <summary>
		/// The customer kind, indicating whether the customer is an individual (I) or an organization (O).
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Customer Category</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? CustomerCategory { get; set; }

		/// <summary>
		/// The full business account name (as opposed to the short identifier provided by AcctCD).
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Customer Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// The identifier of the Contact object linked with the business account and marked as primary.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Primary Contact</para>
		/// </summary>
		/// <remarks>
		/// Also, the Contact.BAccountID value must equal tothe BAccount.BAccountID value of the current business account.
		/// </remarks>
		public IntValue? PrimaryContactID { get; set; }

		/// <summary>
		/// The identifier of the default terms, which are applied to the documents of the customer.
		/// <para>DAC Field Name: TermsID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Terms { get; set; }

		/// <summary>
		/// The identifier of the statement cycleto which the customer is assigned.
		/// <para>DAC Field Name: StatementCycleId</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Statement Cycle ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? StatementCycleID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: COrgBAccountID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Restrict Visibility To</para>
		/// </summary>
		public StringValue? RestrictVisibilityTo { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that the payments of the customershould be automatically applied to the open invoices upon release.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Auto-Apply Payments</para>
		/// </summary>
		public BooleanValue? AutoApplyPayments { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that financial chargescan be calculated for the customer.
		/// <para>DAC Field Name: FinChargeApply</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Apply Overdue Charges</para>
		/// </summary>
		public BooleanValue? ApplyOverdueCharges { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that small balancewrite-offs are allowed for the customer.
		/// <para>DAC Field Name: SmallBalanceAllow</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Enable Write-Offs</para>
		/// </summary>
		public BooleanValue? EnableWriteOffs { get; set; }

		/// <summary>
		/// If SmallBalanceAllow is set to <c>true</c>, thefield determines the maximum small balance write-off limit for customer documents.
		/// <para>DAC Field Name: SmallBalanceLimit</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Write-Off Limit</para>
		/// </summary>
		public DecimalValue? WriteOffLimit { get; set; }

		/// <summary>
		/// The identifier of the Currency,which is applied to the documents of the customer.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// If set to true, indicates that the currency of customer documents (which is specified by CuryID)can be overridden by a user during document entry.
		/// <para>DAC Field Name: AllowOverrideCury</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Enable Currency Override</para>
		/// </summary>
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// The identifier of the currency rate type,which is applied to the documents of the customer.
		/// <para>DAC Field Name: CuryRateTypeID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Curr. Rate Type</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? CurrencyRateType { get; set; }

		/// <summary>
		/// If set to true, indicates that the currency ratefor customer documents (which is calculated by the system from the currency rate history) can be overridden by a user during document entry.
		/// <para>DAC Field Name: AllowOverrideRate</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Enable Rate Override</para>
		/// </summary>
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// If CreditRule enables verification by credit limit,this field determines the maximum amount of credit allowed for the customer.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Credit Limit</para>
		/// </summary>
		public DecimalValue? CreditLimit { get; set; }

		/// <summary>
		/// A calculated field. If set to <c>false</c>, indicates thatthe customer's billing address is the same as the customer'sdefault address.The field is populated by a formula, working only in the scope of the Customers (AR303000) form. See CustomerBillSharedAddressOverrideGraphExt"
		/// <para>DAC Field Name: OverrideBillAddress</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? BillingAddressOverride { get; set; }

		/// <summary>
		/// A calculated field. If set to <c>false</c>, indicates that the customer's billing contact is the same as the customer'sdefault contact.The field is populated by a formula, working only in the scope of the Customers (AR303000) form. See CustomerBillSharedContactOverrideGraphExt"
		/// <para>DAC Field Name: OverrideBillContact</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? BillingContactOverride { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// <para>DAC Field Name: ParentBAccountID</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Parent Account</para>
		/// </summary>
		public StringValue? ParentRecord { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that invoicesshould be sent to the customer by email.
		/// <para>DAC Field Name: MailInvoices</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Send Invoices by Email</para>
		/// </summary>
		public BooleanValue? SendInvoicesbyEmail { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that invoicesshould be printed for the customer.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Print Invoices</para>
		/// </summary>
		public BooleanValue? PrintInvoices { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that dunning letters should be sent to the customer by email.
		/// <para>DAC Field Name: MailDunningLetters</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Send Dunning Letters by Email</para>
		/// </summary>
		public BooleanValue? SendDunningLettersbyEmail { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that dunning letters should be printed for the customer.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Print Dunning Letters</para>
		/// </summary>
		public BooleanValue? PrintDunningLetters { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SendStatementByEmail</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Send Statements by Email</para>
		/// </summary>
		public BooleanValue? SendStatementsbyEmail { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that customerstatements should be printed for the customer.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Print Statements</para>
		/// </summary>
		public BooleanValue? PrintStatements { get; set; }

		/// <summary>
		/// The type of customer statements generated for the customer.The list of possible values of the field is determined by StatementTypeAttribute.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Statement Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? StatementType { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that customerstatements should be generated for the customer in multi-currency format.
		/// <para>DAC Field Name: PrintCuryStatements</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Multi-Currency Statements</para>
		/// </summary>
		public BooleanValue? MultiCurrencyStatements { get; set; }

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
		public StringValue? AccountRef { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? ShippingAddressOverride { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that the addressoverrides the default Contact record, which isreferenced by DefContactID.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? ShippingContactOverride { get; set; }

		/// <summary>
		/// The identifier of the default branch of the customer location.
		/// <para>DAC Field Name: CBranchID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Shipping Branch</para>
		/// </summary>
		public StringValue? ShippingBranch { get; set; }

		/// <summary>
		/// The price class of the customer.
		/// <para>DAC Field Name: CPriceClassID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Price Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PriceClassID { get; set; }

		/// <summary>
		/// The registration ID of the company in the state tax authority.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Registration ID</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// The customer's tax zone.
		/// <para>DAC Field Name: CTaxZoneID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// The Avalara Exemption number of the customer location.
		/// <para>DAC Field Name: CAvalaraExemptionNumber</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Exemption Number</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? TaxExemptionNumber { get; set; }

		/// <summary>
		/// The customer's entity type for reporting purposes. This field is used if the system is integrated with External Tax Calculationand the External Tax Calculation Integration feature is enabled.
		/// <para>DAC Field Name: CAvalaraCustomerUsageType</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Exemption Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// The warehouse identifier of the customer location.
		/// <para>DAC Field Name: CSiteID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// The shipping carrier for the vendor location.
		/// <para>DAC Field Name: CCarrierID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Ship Via</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// The customer's shipping terms.
		/// <para>DAC Field Name: CShipTermsID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Shipping Terms</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// The customer's shipping zone.
		/// <para>DAC Field Name: CShipZoneID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Shipping Zone</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ShippingZoneID { get; set; }

		/// <summary>
		/// The customer's FOB (free on board) shipping point.
		/// <para>DAC Field Name: CFOBPointID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: FOB Point</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// This field indicates whether the residential delivery is available in this location.
		/// <para>DAC Field Name: CResedential</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Residential Delivery</para>
		/// </summary>
		public BooleanValue? ResidentialDelivery { get; set; }

		/// <summary>
		/// This field indicates whether the Saturday delivery is available in this location.
		/// <para>DAC Field Name: CSaturdayDelivery</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Saturday Delivery</para>
		/// </summary>
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// The shipping rule of the customer location.
		/// <para>DAC Field Name: CShipComplete</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Shipping Rule</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// The order priority of the customer's location.
		/// <para>DAC Field Name: COrderPriority</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Order Priority</para>
		/// </summary>
		public ShortValue? OrderPriority { get; set; }

		/// <summary>
		/// The amount of lead days (the time in days from the moment when the production was finished to the moment when the customer's order was delivered).
		/// <para>DAC Field Name: CLeadTime</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Lead Time (Days)</para>
		/// </summary>
		public ShortValue? LeadTimedays { get; set; }

		/// <summary>
		/// The name of the location.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Location Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? LocationName { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Created On</para>
		/// </summary>
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Last Modified On</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.NotificationRecipient</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Email { get; set; }

		/// <summary>
		/// The identifier of the related business account.Along with ContactID, this field is used as an additional reference,but unlike RefNoteID and DocumentNoteID it is used for specific entities.
		/// <para>DAC: PX.Objects.CR.CRPMTimeActivity</para>
		/// <para>Display Name: Related Account</para>
		/// </summary>
		public IntValue? BAccountID { get; set; }

		public GuidValue? NoteID { get; set; }

		public BooleanValue? IsGuestCustomer { get; set; }

		public StringValue? LegalName { get; set; }

		#endregion

		#region LinkedEntities
		public Contact? BillingContact { get; set; }

		public CreditVerificationRules? CreditVerificationRules { get; set; }

		public Contact? MainContact { get; set; }

		public Contact? PrimaryContact { get; set; }

		public Contact? ShippingContact { get; set; }

		#endregion

		#region Details
		public List<AttributeValue>? Attributes { get; set; }

		public List<CustomerContact>? Contacts { get; set; }

		public List<BusinessAccountPaymentInstructionDetail>? PaymentInstructions { get; set; }

		public List<CustomerSalesPerson>? Salespersons { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(Customer)} - \"{CustomerID}\"";
		}

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
			public const string BillingContact = "BillingContact";
			public const string Contacts = "Contacts";
			public const string CreditVerificationRules = "CreditVerificationRules";
			public const string MainContact = "MainContact";
			public const string PaymentInstructions = "PaymentInstructions";
			public const string PrimaryContact = "PrimaryContact";
			public const string Salespersons = "Salespersons";
			public const string ShippingContact = "ShippingContact";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,BillingContact,Contacts,CreditVerificationRules,MainContact,PaymentInstructions,PrimaryContact,Salespersons,ShippingContact";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}