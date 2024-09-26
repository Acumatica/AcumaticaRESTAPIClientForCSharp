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
		/// 
		/// Display Name:
		/// DAC Field Name: AcctReferenceNbr 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue? AccountRef { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinChargeApply 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue? ApplyOverdueCharges { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AutoApplyPayments 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AutoApplyPayments", EmitDefaultValue=false)]
		public BooleanValue? AutoApplyPayments { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.CR.CRPMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BAccountID", EmitDefaultValue=false)]
		public IntValue? BAccountID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideBillAddress 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? BillingAddressOverride { get; set; }

		[DataMember(Name="BillingContact", EmitDefaultValue=false)]
		public Contact? BillingContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideBillContact 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillingContactOverride", EmitDefaultValue=false)]
		public BooleanValue? BillingContactOverride { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<CustomerContact>? Contacts { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="CreditVerificationRules", EmitDefaultValue=false)]
		public CreditVerificationRules? CreditVerificationRules { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue? CurrencyRateType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerClassID 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerClass", EmitDefaultValue=false)]
		public StringValue? CustomerClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctCD 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerCategory 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerCategory", EmitDefaultValue=false)]
		public StringValue? CustomerCategory { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Email 
		/// DAC: PX.Objects.CS.NotificationRecipient 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowOverrideCury 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowOverrideRate 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SmallBalanceAllow 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnableWriteOffs", EmitDefaultValue=false)]
		public BooleanValue? EnableWriteOffs { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CFOBPointID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastModifiedDateTime 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CLeadTime 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LeadTimedays", EmitDefaultValue=false)]
		public ShortValue? LeadTimedays { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		[DataMember(Name="MainContact", EmitDefaultValue=false)]
		public Contact? MainContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrintCuryStatements 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MultiCurrencyStatements", EmitDefaultValue=false)]
		public BooleanValue? MultiCurrencyStatements { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COrderPriority 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderPriority", EmitDefaultValue=false)]
		public ShortValue? OrderPriority { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentBAccountID 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ParentRecord", EmitDefaultValue=false)]
		public StringValue? ParentRecord { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail>? PaymentInstructions { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CPriceClassID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceClassID", EmitDefaultValue=false)]
		public StringValue? PriceClassID { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact? PrimaryContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrimaryContactID 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrimaryContactID", EmitDefaultValue=false)]
		public IntValue? PrimaryContactID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrintDunningLetters 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrintDunningLetters", EmitDefaultValue=false)]
		public BooleanValue? PrintDunningLetters { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrintInvoices 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrintInvoices", EmitDefaultValue=false)]
		public BooleanValue? PrintInvoices { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrintStatements 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrintStatements", EmitDefaultValue=false)]
		public BooleanValue? PrintStatements { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CResedential 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		[DataMember(Name="Salespersons", EmitDefaultValue=false)]
		public List<CustomerSalesPerson>? Salespersons { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CSaturdayDelivery 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MailDunningLetters 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SendDunningLettersbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendDunningLettersbyEmail { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MailInvoices 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SendInvoicesbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendInvoicesbyEmail { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SendStatementByEmail 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SendStatementsbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendStatementsbyEmail { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CBranchID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
		public StringValue? ShippingBranch { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public Contact? ShippingContact { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingContactOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CShipComplete 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CShipTermsID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CShipZoneID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingZoneID", EmitDefaultValue=false)]
		public StringValue? ShippingZoneID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CCarrierID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StatementCycleId 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StatementCycleID", EmitDefaultValue=false)]
		public StringValue? StatementCycleID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StatementType 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StatementType", EmitDefaultValue=false)]
		public StringValue? StatementType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxRegistrationID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CTaxZoneID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CSiteID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SmallBalanceLimit 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WriteOffLimit", EmitDefaultValue=false)]
		public DecimalValue? WriteOffLimit { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COrgBAccountID 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RestrictVisibilityTo", EmitDefaultValue=false)]
		public StringValue? RestrictVisibilityTo { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreditLimit 
		/// DAC: PX.Objects.AR.Customer 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CreditLimit", EmitDefaultValue=false)]
		public DecimalValue? CreditLimit { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CAvalaraCustomerUsageType 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CAvalaraExemptionNumber 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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