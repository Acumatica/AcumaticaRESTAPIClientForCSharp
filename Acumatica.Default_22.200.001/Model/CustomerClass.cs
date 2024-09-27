using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR201000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CustomerClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: FinChargeApply 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Apply Overdue Charges 
		/// </summary>
		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue? ApplyOverdueCharges { get; set; }

		/// <summary>
		/// DAC Field Name: ARAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: AR Account 
		/// </summary>
		[DataMember(Name="ARAccount", EmitDefaultValue=false)]
		public StringValue? ARAccount { get; set; }

		/// <summary>
		/// DAC Field Name: ARSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: AR Sub. 
		/// </summary>
		[DataMember(Name="ARSubaccount", EmitDefaultValue=false)]
		public StringValue? ARSubaccount { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<BusinessAccountClassAttributeDetail>? Attributes { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Auto-Apply Payments 
		/// </summary>
		[DataMember(Name="AutoApplyPayments", EmitDefaultValue=false)]
		public BooleanValue? AutoApplyPayments { get; set; }

		/// <summary>
		/// DAC Field Name: DiscTakenAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Cash Discount Account 
		/// </summary>
		[DataMember(Name="CashDiscountAccount", EmitDefaultValue=false)]
		public StringValue? CashDiscountAccount { get; set; }

		/// <summary>
		/// DAC Field Name: DiscTakenSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Cash Discount Sub. 
		/// </summary>
		[DataMember(Name="CashDiscountSubaccount", EmitDefaultValue=false)]
		public StringValue? CashDiscountSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: CustomerClassID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Class ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// DAC Field Name: COGSAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: COGS Account 
		/// </summary>
		[DataMember(Name="COGSAccount", EmitDefaultValue=false)]
		public StringValue? COGSAccount { get; set; }

		/// <summary>
		/// DAC Field Name: COGSSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: COGS Sub. 
		/// </summary>
		[DataMember(Name="COGSSubaccount", EmitDefaultValue=false)]
		public StringValue? COGSSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: CountryID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// SQL Type: nvarchar(2) 
		/// </summary>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Credit Days Past Due 
		/// </summary>
		[DataMember(Name="CreditDaysPastDue", EmitDefaultValue=false)]
		public ShortValue? CreditDaysPastDue { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Credit Limit 
		/// </summary>
		[DataMember(Name="CreditLimit", EmitDefaultValue=false)]
		public DecimalValue? CreditLimit { get; set; }

		/// <summary>
		/// DAC Field Name: CreditRule 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Credit Verification 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="CreditVerification", EmitDefaultValue=false)]
		public StringValue? CreditVerification { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Currency Rate Type 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue? CurrencyRateType { get; set; }

		/// <summary>
		/// DAC Field Name: DefaultLocationCDFromBranch 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Default Location ID from Branch 
		/// </summary>
		[DataMember(Name="DefaultLocationIDfromBranch", EmitDefaultValue=false)]
		public BooleanValue? DefaultLocationIDfromBranch { get; set; }

		/// <summary>
		/// The mask that is used by the row-level security functionality to restrict user access to various entities. Each byte of the mask converted to binary format (for example, 0x0800 is converted to 0000 1000 0000 0000 ) is related to one group and indicates if the item is available in the group.
		/// DAC Field Name: GroupMask 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Default Restriction Group 
		/// </summary>
		[DataMember(Name="DefaultRestrictionGroup", EmitDefaultValue=false)]
		public StringValue? DefaultRestrictionGroup { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Discount Account 
		/// </summary>
		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue? DiscountAccount { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Discount Sub. 
		/// </summary>
		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue? DiscountSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: AllowOverrideCury 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Enable Currency Override 
		/// </summary>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// DAC Field Name: AllowOverrideRate 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Enable Rate Override 
		/// </summary>
		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// DAC Field Name: SmallBalanceAllow 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Enable Write-Offs 
		/// </summary>
		[DataMember(Name="EnableWriteOffs", EmitDefaultValue=false)]
		public BooleanValue? EnableWriteOffs { get; set; }

		/// <summary>
		/// DAC Field Name: AvalaraCustomerUsageType 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Tax Exemption Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// DAC Field Name: FreightAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Freight Account 
		/// </summary>
		[DataMember(Name="FreightAccount", EmitDefaultValue=false)]
		public StringValue? FreightAccount { get; set; }

		/// <summary>
		/// DAC Field Name: FreightSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Freight Sub. 
		/// </summary>
		[DataMember(Name="FreightSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: DiscountLimit 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Group/Document Discount Limit (%) 
		/// </summary>
		[DataMember(Name="GroupDocumentDiscountLimit", EmitDefaultValue=false)]
		public DecimalValue? GroupDocumentDiscountLimit { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: MiscAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Misc. Account 
		/// </summary>
		[DataMember(Name="MiscAccount", EmitDefaultValue=false)]
		public StringValue? MiscAccount { get; set; }

		/// <summary>
		/// DAC Field Name: MiscSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Misc. Sub. 
		/// </summary>
		[DataMember(Name="MiscSubaccount", EmitDefaultValue=false)]
		public StringValue? MiscSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: PrintCuryStatements 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Multi-Currency Statements 
		/// </summary>
		[DataMember(Name="MultiCurrencyStatements", EmitDefaultValue=false)]
		public BooleanValue? MultiCurrencyStatements { get; set; }

		/// <summary>
		/// DAC Field Name: FinChargeID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Overdue Charge ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="OverdueChargeID", EmitDefaultValue=false)]
		public StringValue? OverdueChargeID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Over-Limit Amount 
		/// </summary>
		[DataMember(Name="OverLimitAmount", EmitDefaultValue=false)]
		public DecimalValue? OverLimitAmount { get; set; }

		/// <summary>
		/// DAC Field Name: DefPaymentMethodID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Payment Method 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// DAC Field Name: PrepaymentAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Prepayment Account 
		/// </summary>
		[DataMember(Name="PrepaymentAccount", EmitDefaultValue=false)]
		public StringValue? PrepaymentAccount { get; set; }

		/// <summary>
		/// DAC Field Name: PrepaymentSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Prepayment Sub. 
		/// </summary>
		[DataMember(Name="PrepaymentSubaccount", EmitDefaultValue=false)]
		public StringValue? PrepaymentSubaccount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Print Dunning Letters 
		/// </summary>
		[DataMember(Name="PrintDunningLetters", EmitDefaultValue=false)]
		public BooleanValue? PrintDunningLetters { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Print Invoices 
		/// </summary>
		[DataMember(Name="PrintInvoices", EmitDefaultValue=false)]
		public BooleanValue? PrintInvoices { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Print Statements 
		/// </summary>
		[DataMember(Name="PrintStatements", EmitDefaultValue=false)]
		public BooleanValue? PrintStatements { get; set; }

		/// <summary>
		/// DAC Field Name: RequireAvalaraCustomerUsageType 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Require Tax Exemption Type 
		/// </summary>
		[DataMember(Name="RequireEntityUsageType", EmitDefaultValue=false)]
		public BooleanValue? RequireEntityUsageType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Require Tax Zone 
		/// </summary>
		[DataMember(Name="RequireTaxZone", EmitDefaultValue=false)]
		public BooleanValue? RequireTaxZone { get; set; }

		/// <summary>
		/// DAC Field Name: SalesAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Sales Account 
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// DAC Field Name: SalesPersonID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Salesperson ID 
		/// </summary>
		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue? SalespersonID { get; set; }

		/// <summary>
		/// DAC Field Name: SalesSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Sales Sub. 
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: MailDunningLetters 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Send Dunning Letters by Email 
		/// </summary>
		[DataMember(Name="SendDunningLettersbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendDunningLettersbyEmail { get; set; }

		/// <summary>
		/// DAC Field Name: MailInvoices 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Send Invoices by Email 
		/// </summary>
		[DataMember(Name="SendInvoicesbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendInvoicesbyEmail { get; set; }

		/// <summary>
		/// DAC Field Name: SendStatementByEmail 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Send Statements by Email 
		/// </summary>
		[DataMember(Name="SendStatementsByEmail", EmitDefaultValue=false)]
		public BooleanValue? SendStatementsByEmail { get; set; }

		/// <summary>
		/// DAC Field Name: ShipComplete 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Shipping Rule 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// DAC Field Name: ShipTermsID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Shipping Terms 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Ship Via 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// DAC Field Name: StatementCycleId 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Statement Cycle ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="StatementCycleID", EmitDefaultValue=false)]
		public StringValue? StatementCycleID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Statement Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="StatementType", EmitDefaultValue=false)]
		public StringValue? StatementType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Tax Zone ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZoneID", EmitDefaultValue=false)]
		public StringValue? TaxZoneID { get; set; }

		/// <summary>
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// DAC Field Name: UnrealizedGainAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Unrealized Gain Account 
		/// </summary>
		[DataMember(Name="UnrealizedGainAccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedGainAccount { get; set; }

		/// <summary>
		/// DAC Field Name: UnrealizedGainSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Unrealized Gain Sub. 
		/// </summary>
		[DataMember(Name="UnrealizedGainSubaccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedGainSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: UnrealizedLossAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Unrealized Loss Account 
		/// </summary>
		[DataMember(Name="UnrealizedLossAccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedLossAccount { get; set; }

		/// <summary>
		/// DAC Field Name: UnrealizedLossSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Unrealized Loss Sub. 
		/// </summary>
		[DataMember(Name="UnrealizedLossSubaccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedLossSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: SmallBalanceLimit 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// Display Name: Write-Off Limit 
		/// </summary>
		[DataMember(Name="WriteOffLimit", EmitDefaultValue=false)]
		public DecimalValue? WriteOffLimit { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}