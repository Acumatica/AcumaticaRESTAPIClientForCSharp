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
	/// Corresponds to the screen AR303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Customer : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The external reference number of the business account.
		/// DAC Field Name: AcctReferenceNbr 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Ext Ref Nbr 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		/// <remarks>
		/// It can be an additional number of the business account used in external integration.            
		/// </remarks>
		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue? AccountRef { get; set; }

		/// <summary>
		/// If set to true, indicates that financial chargescan be calculated for the customer.
		/// DAC Field Name: FinChargeApply 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Apply Overdue Charges 
		/// </summary>
		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue? ApplyOverdueCharges { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// If set to true, indicates that the payments of the customershould be automatically applied to the open invoices upon release.
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Auto-Apply Payments 
		/// </summary>
		[DataMember(Name="AutoApplyPayments", EmitDefaultValue=false)]
		public BooleanValue? AutoApplyPayments { get; set; }

		/// <summary>
		/// The identifier of the related business account.Along with ContactID, this field is used as an additional reference,but unlike RefNoteID and DocumentNoteID it is used for specific entities.
		/// DAC: PX.Objects.CR.CRPMTimeActivity 
		/// Display Name: Related Account 
		/// </summary>
		[DataMember(Name="BAccountID", EmitDefaultValue=false)]
		public IntValue? BAccountID { get; set; }

		/// <summary>
		/// A calculated field. If set to false, indicates thatthe customer's billing address is the same as the customer'sdefault address.The field is populated by a formula, working only in the scope of the Customers (AR303000) form. See CustomerBillSharedAddressOverrideGraphExt"
		/// DAC Field Name: OverrideBillAddress 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="BillingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? BillingAddressOverride { get; set; }

		[DataMember(Name="BillingContact", EmitDefaultValue=false)]
		public Contact? BillingContact { get; set; }

		/// <summary>
		/// A calculated field. If set to false, indicates that the customer's billing contact is the same as the customer'sdefault contact.The field is populated by a formula, working only in the scope of the Customers (AR303000) form. See CustomerBillSharedContactOverrideGraphExt"
		/// DAC Field Name: OverrideBillContact 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="BillingContactOverride", EmitDefaultValue=false)]
		public BooleanValue? BillingContactOverride { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<CustomerContact>? Contacts { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="CreditVerificationRules", EmitDefaultValue=false)]
		public CreditVerificationRules? CreditVerificationRules { get; set; }

		/// <summary>
		/// The identifier of the Currency,which is applied to the documents of the customer.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The identifier of the currency rate type,which is applied to the documents of the customer.
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Curr. Rate Type 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue? CurrencyRateType { get; set; }

		/// <summary>
		/// Identifier of the customer class to which the customer belongs.
		/// DAC Field Name: CustomerClassID 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Customer Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="CustomerClass", EmitDefaultValue=false)]
		public StringValue? CustomerClass { get; set; }

		/// <summary>
		/// The human-readable identifier of the customer account, which isspecified by the user or defined by the auto-numbering sequence duringcreation of the customer. This field is a natural key, as opposedto the surrogate key BAccountID.
		/// DAC Field Name: AcctCD 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Customer ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The customer kind, indicating whether the customer is an individual (I) or an organization (O).
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Customer Category 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="CustomerCategory", EmitDefaultValue=false)]
		public StringValue? CustomerCategory { get; set; }

		/// <summary>
		/// The full business account name (as opposed to the short identifier provided by AcctCD).
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Customer Name 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.NotificationRecipient 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// If set to true, indicates that the currency of customer documents (which is specified by CuryID)can be overridden by a user during document entry.
		/// DAC Field Name: AllowOverrideCury 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Enable Currency Override 
		/// </summary>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// If set to true, indicates that the currency ratefor customer documents (which is calculated by the system from the currency rate history) can be overridden by a user during document entry.
		/// DAC Field Name: AllowOverrideRate 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Enable Rate Override 
		/// </summary>
		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// If set to true, indicates that small balancewrite-offs are allowed for the customer.
		/// DAC Field Name: SmallBalanceAllow 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Enable Write-Offs 
		/// </summary>
		[DataMember(Name="EnableWriteOffs", EmitDefaultValue=false)]
		public BooleanValue? EnableWriteOffs { get; set; }

		/// <summary>
		/// The customer's FOB (free on board) shipping point.
		/// DAC Field Name: CFOBPointID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: FOB Point 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The amount of lead days (the time in days from the moment when the production was finished to the moment when the customer's order was delivered).
		/// DAC Field Name: CLeadTime 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Lead Time (Days) 
		/// </summary>
		[DataMember(Name="LeadTimedays", EmitDefaultValue=false)]
		public ShortValue? LeadTimedays { get; set; }

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
		/// If set to true, indicates that customerstatements should be generated for the customer in multi-currency format.
		/// DAC Field Name: PrintCuryStatements 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Multi-Currency Statements 
		/// </summary>
		[DataMember(Name="MultiCurrencyStatements", EmitDefaultValue=false)]
		public BooleanValue? MultiCurrencyStatements { get; set; }

		/// <summary>
		/// The order priority of the customer's location.
		/// DAC Field Name: COrderPriority 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Order Priority 
		/// </summary>
		[DataMember(Name="OrderPriority", EmitDefaultValue=false)]
		public ShortValue? OrderPriority { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// DAC Field Name: ParentBAccountID 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Parent Account 
		/// </summary>
		[DataMember(Name="ParentRecord", EmitDefaultValue=false)]
		public StringValue? ParentRecord { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail>? PaymentInstructions { get; set; }

		/// <summary>
		/// The price class of the customer.
		/// DAC Field Name: CPriceClassID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Price Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PriceClassID", EmitDefaultValue=false)]
		public StringValue? PriceClassID { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact? PrimaryContact { get; set; }

		/// <summary>
		/// The identifier of the Contact object linked with the business account and marked as primary.
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Primary Contact 
		/// </summary>
		/// <remarks>
		/// Also, the Contact.BAccountID value must equal tothe BAccount.BAccountID value of the current business account.
		/// </remarks>
		[DataMember(Name="PrimaryContactID", EmitDefaultValue=false)]
		public IntValue? PrimaryContactID { get; set; }

		/// <summary>
		/// If set to true, indicates that dunning letters should be printed for the customer.
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Print Dunning Letters 
		/// </summary>
		[DataMember(Name="PrintDunningLetters", EmitDefaultValue=false)]
		public BooleanValue? PrintDunningLetters { get; set; }

		/// <summary>
		/// If set to true, indicates that invoicesshould be printed for the customer.
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Print Invoices 
		/// </summary>
		[DataMember(Name="PrintInvoices", EmitDefaultValue=false)]
		public BooleanValue? PrintInvoices { get; set; }

		/// <summary>
		/// If set to true, indicates that customerstatements should be printed for the customer.
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Print Statements 
		/// </summary>
		[DataMember(Name="PrintStatements", EmitDefaultValue=false)]
		public BooleanValue? PrintStatements { get; set; }

		/// <summary>
		/// This field indicates whether the residential delivery is available in this location.
		/// DAC Field Name: CResedential 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Residential Delivery 
		/// </summary>
		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		[DataMember(Name="Salespersons", EmitDefaultValue=false)]
		public List<CustomerSalesPerson>? Salespersons { get; set; }

		/// <summary>
		/// This field indicates whether the Saturday delivery is available in this location.
		/// DAC Field Name: CSaturdayDelivery 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Saturday Delivery 
		/// </summary>
		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// If set to true, indicates that dunning letters should be sent to the customer by email.
		/// DAC Field Name: MailDunningLetters 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Send Dunning Letters by Email 
		/// </summary>
		[DataMember(Name="SendDunningLettersbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendDunningLettersbyEmail { get; set; }

		/// <summary>
		/// If set to true, indicates that invoicesshould be sent to the customer by email.
		/// DAC Field Name: MailInvoices 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Send Invoices by Email 
		/// </summary>
		[DataMember(Name="SendInvoicesbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendInvoicesbyEmail { get; set; }

		/// <summary>
		/// DAC Field Name: SendStatementByEmail 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Send Statements by Email 
		/// </summary>
		[DataMember(Name="SendStatementsbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendStatementsbyEmail { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressOverride { get; set; }

		/// <summary>
		/// The identifier of the default branch of the customer location.
		/// DAC Field Name: CBranchID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Shipping Branch 
		/// </summary>
		[DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
		public StringValue? ShippingBranch { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public Contact? ShippingContact { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Contact record, which isreferenced by DefContactID.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="ShippingContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingContactOverride { get; set; }

		/// <summary>
		/// The shipping rule of the customer location.
		/// DAC Field Name: CShipComplete 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Shipping Rule 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// The customer's shipping terms.
		/// DAC Field Name: CShipTermsID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Shipping Terms 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// The customer's shipping zone.
		/// DAC Field Name: CShipZoneID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Shipping Zone 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShippingZoneID", EmitDefaultValue=false)]
		public StringValue? ShippingZoneID { get; set; }

		/// <summary>
		/// The shipping carrier for the vendor location.
		/// DAC Field Name: CCarrierID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Ship Via 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// The identifier of the statement cycleto which the customer is assigned.
		/// DAC Field Name: StatementCycleId 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Statement Cycle ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="StatementCycleID", EmitDefaultValue=false)]
		public StringValue? StatementCycleID { get; set; }

		/// <summary>
		/// The type of customer statements generated for the customer.The list of possible values of the field is determined by StatementTypeAttribute.
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Statement Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="StatementType", EmitDefaultValue=false)]
		public StringValue? StatementType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Customer Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The registration ID of the company in the state tax authority.
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Tax Registration ID 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// The customer's tax zone.
		/// DAC Field Name: CTaxZoneID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// The identifier of the default terms, which are applied to the documents of the customer.
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.AR.Customer 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// The warehouse identifier of the customer location.
		/// DAC Field Name: CSiteID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Warehouse 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// If SmallBalanceAllow is set to true, thefield determines the maximum small balance write-off limit for customer documents.
		/// DAC Field Name: SmallBalanceLimit 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Write-Off Limit 
		/// </summary>
		[DataMember(Name="WriteOffLimit", EmitDefaultValue=false)]
		public DecimalValue? WriteOffLimit { get; set; }

		/// <summary>
		/// DAC Field Name: COrgBAccountID 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Restrict Visibility To 
		/// </summary>
		[DataMember(Name="RestrictVisibilityTo", EmitDefaultValue=false)]
		public StringValue? RestrictVisibilityTo { get; set; }

		/// <summary>
		/// If CreditRule enables verification by credit limit,this field determines the maximum amount of credit allowed for the customer.
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Credit Limit 
		/// </summary>
		[DataMember(Name="CreditLimit", EmitDefaultValue=false)]
		public DecimalValue? CreditLimit { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// The customer's entity type for reporting purposes. This field is used if the system is integrated with External Tax Calculationand the External Tax Calculation Integration feature is enabled.
		/// DAC Field Name: CAvalaraCustomerUsageType 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Tax Exemption Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// The Avalara Exemption number of the customer location.
		/// DAC Field Name: CAvalaraExemptionNumber 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Tax Exemption Number 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="TaxExemptionNumber", EmitDefaultValue=false)]
		public StringValue? TaxExemptionNumber { get; set; }

		[DataMember(Name="IsGuestCustomer", EmitDefaultValue=false)]
		public BooleanValue? IsGuestCustomer { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}