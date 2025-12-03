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
	/// Corresponds to the screen <c>AR201000</c> in the Acumatica ERP
	/// <para>Key Fields: ClassID</para>
	/// </summary>
	[DataContract]
	public class CustomerClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: FinChargeApply</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Apply Overdue Charges</para>
		/// </summary>
		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue? ApplyOverdueCharges { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARAcctID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: AR Account</para>
		/// </summary>
		[DataMember(Name="ARAccount", EmitDefaultValue=false)]
		public StringValue? ARAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARSubID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: AR Sub.</para>
		/// </summary>
		[DataMember(Name="ARSubaccount", EmitDefaultValue=false)]
		public StringValue? ARSubaccount { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<BusinessAccountClassAttributeDetail>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Auto-Apply Payments</para>
		/// </summary>
		[DataMember(Name="AutoApplyPayments", EmitDefaultValue=false)]
		public BooleanValue? AutoApplyPayments { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscTakenAcctID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Cash Discount Account</para>
		/// </summary>
		[DataMember(Name="CashDiscountAccount", EmitDefaultValue=false)]
		public StringValue? CashDiscountAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscTakenSubID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Cash Discount Sub.</para>
		/// </summary>
		[DataMember(Name="CashDiscountSubaccount", EmitDefaultValue=false)]
		public StringValue? CashDiscountSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerClassID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: COGSAcctID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: COGS Account</para>
		/// </summary>
		[DataMember(Name="COGSAccount", EmitDefaultValue=false)]
		public StringValue? COGSAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: COGSSubID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: COGS Sub.</para>
		/// </summary>
		[DataMember(Name="COGSSubaccount", EmitDefaultValue=false)]
		public StringValue? COGSSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CountryID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>SQL Type: nvarchar(2)</para>
		/// </summary>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Credit Days Past Due</para>
		/// </summary>
		[DataMember(Name="CreditDaysPastDue", EmitDefaultValue=false)]
		public ShortValue? CreditDaysPastDue { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Credit Limit</para>
		/// </summary>
		[DataMember(Name="CreditLimit", EmitDefaultValue=false)]
		public DecimalValue? CreditLimit { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CreditRule</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Credit Verification</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="CreditVerification", EmitDefaultValue=false)]
		public StringValue? CreditVerification { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryRateTypeID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Currency Rate Type</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue? CurrencyRateType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultLocationCDFromBranch</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Default Location ID from Branch</para>
		/// </summary>
		[DataMember(Name="DefaultLocationIDfromBranch", EmitDefaultValue=false)]
		public BooleanValue? DefaultLocationIDfromBranch { get; set; }

		/// <summary>
		/// The mask that is used by the row-level security functionality to restrict user access to various entities. Each byte of the mask converted to binary format (for example, 0x0800 is converted to 0000 1000 0000 0000 ) is related to one group and indicates if the item is available in the group.
		/// <para>DAC Field Name: GroupMask</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Default Restriction Group</para>
		/// </summary>
		[DataMember(Name="DefaultRestrictionGroup", EmitDefaultValue=false)]
		public StringValue? DefaultRestrictionGroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountAcctID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Discount Account</para>
		/// </summary>
		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue? DiscountAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountSubID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Discount Sub.</para>
		/// </summary>
		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue? DiscountSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowOverrideCury</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Enable Currency Override</para>
		/// </summary>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowOverrideRate</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Enable Rate Override</para>
		/// </summary>
		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SmallBalanceAllow</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Enable Write-Offs</para>
		/// </summary>
		[DataMember(Name="EnableWriteOffs", EmitDefaultValue=false)]
		public BooleanValue? EnableWriteOffs { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AvalaraCustomerUsageType</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Tax Exemption Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FreightAcctID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Freight Account</para>
		/// </summary>
		[DataMember(Name="FreightAccount", EmitDefaultValue=false)]
		public StringValue? FreightAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FreightSubID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Freight Sub.</para>
		/// </summary>
		[DataMember(Name="FreightSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountLimit</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Group/Document Discount Limit (%)</para>
		/// </summary>
		[DataMember(Name="GroupDocumentDiscountLimit", EmitDefaultValue=false)]
		public DecimalValue? GroupDocumentDiscountLimit { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MiscAcctID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Misc. Account</para>
		/// </summary>
		[DataMember(Name="MiscAccount", EmitDefaultValue=false)]
		public StringValue? MiscAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MiscSubID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Misc. Sub.</para>
		/// </summary>
		[DataMember(Name="MiscSubaccount", EmitDefaultValue=false)]
		public StringValue? MiscSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PrintCuryStatements</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Multi-Currency Statements</para>
		/// </summary>
		[DataMember(Name="MultiCurrencyStatements", EmitDefaultValue=false)]
		public BooleanValue? MultiCurrencyStatements { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinChargeID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Overdue Charge ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="OverdueChargeID", EmitDefaultValue=false)]
		public StringValue? OverdueChargeID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Over-Limit Amount</para>
		/// </summary>
		[DataMember(Name="OverLimitAmount", EmitDefaultValue=false)]
		public DecimalValue? OverLimitAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefPaymentMethodID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PrepaymentAcctID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Prepayment Account</para>
		/// </summary>
		[DataMember(Name="PrepaymentAccount", EmitDefaultValue=false)]
		public StringValue? PrepaymentAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PrepaymentSubID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Prepayment Sub.</para>
		/// </summary>
		[DataMember(Name="PrepaymentSubaccount", EmitDefaultValue=false)]
		public StringValue? PrepaymentSubaccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Print Dunning Letters</para>
		/// </summary>
		[DataMember(Name="PrintDunningLetters", EmitDefaultValue=false)]
		public BooleanValue? PrintDunningLetters { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Print Invoices</para>
		/// </summary>
		[DataMember(Name="PrintInvoices", EmitDefaultValue=false)]
		public BooleanValue? PrintInvoices { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Print Statements</para>
		/// </summary>
		[DataMember(Name="PrintStatements", EmitDefaultValue=false)]
		public BooleanValue? PrintStatements { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RequireAvalaraCustomerUsageType</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Require Tax Exemption Type</para>
		/// </summary>
		[DataMember(Name="RequireEntityUsageType", EmitDefaultValue=false)]
		public BooleanValue? RequireEntityUsageType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Require Tax Zone</para>
		/// </summary>
		[DataMember(Name="RequireTaxZone", EmitDefaultValue=false)]
		public BooleanValue? RequireTaxZone { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesAcctID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Sales Account</para>
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesPersonID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Salesperson ID</para>
		/// </summary>
		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue? SalespersonID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesSubID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Sales Sub.</para>
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MailDunningLetters</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Send Dunning Letters by Email</para>
		/// </summary>
		[DataMember(Name="SendDunningLettersbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendDunningLettersbyEmail { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MailInvoices</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Send Invoices by Email</para>
		/// </summary>
		[DataMember(Name="SendInvoicesbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendInvoicesbyEmail { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SendStatementByEmail</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Send Statements by Email</para>
		/// </summary>
		[DataMember(Name="SendStatementsByEmail", EmitDefaultValue=false)]
		public BooleanValue? SendStatementsByEmail { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipComplete</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Shipping Rule</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipTermsID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Shipping Terms</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Ship Via</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StatementCycleId</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Statement Cycle ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="StatementCycleID", EmitDefaultValue=false)]
		public StringValue? StatementCycleID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Statement Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="StatementType", EmitDefaultValue=false)]
		public StringValue? StatementType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Tax Zone ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="TaxZoneID", EmitDefaultValue=false)]
		public StringValue? TaxZoneID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TermsID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnrealizedGainAcctID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Unrealized Gain Account</para>
		/// </summary>
		[DataMember(Name="UnrealizedGainAccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedGainAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnrealizedGainSubID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Unrealized Gain Sub.</para>
		/// </summary>
		[DataMember(Name="UnrealizedGainSubaccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedGainSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnrealizedLossAcctID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Unrealized Loss Account</para>
		/// </summary>
		[DataMember(Name="UnrealizedLossAccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedLossAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnrealizedLossSubID</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Unrealized Loss Sub.</para>
		/// </summary>
		[DataMember(Name="UnrealizedLossSubaccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedLossSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SmallBalanceLimit</para>
		/// <para>DAC: PX.Objects.AR.CustomerClass</para>
		/// <para>Display Name: Write-Off Limit</para>
		/// </summary>
		[DataMember(Name="WriteOffLimit", EmitDefaultValue=false)]
		public DecimalValue? WriteOffLimit { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Attributes = "Attributes";

			//Intentionally excluded
			//public const string All = "Files,Attributes";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}