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
	/// Corresponds to the screen AR201000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CustomerClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinChargeApply 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue? ApplyOverdueCharges { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ARAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ARAccount", EmitDefaultValue=false)]
		public StringValue? ARAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ARSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ARSubaccount", EmitDefaultValue=false)]
		public StringValue? ARSubaccount { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<BusinessAccountClassAttributeDetail>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AutoApplyPayments 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AutoApplyPayments", EmitDefaultValue=false)]
		public BooleanValue? AutoApplyPayments { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DiscTakenAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CashDiscountAccount", EmitDefaultValue=false)]
		public StringValue? CashDiscountAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DiscTakenSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CashDiscountSubaccount", EmitDefaultValue=false)]
		public StringValue? CashDiscountSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerClassID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COGSAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="COGSAccount", EmitDefaultValue=false)]
		public StringValue? COGSAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COGSSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="COGSSubaccount", EmitDefaultValue=false)]
		public StringValue? COGSSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CountryID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreditDaysPastDue 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CreditDaysPastDue", EmitDefaultValue=false)]
		public ShortValue? CreditDaysPastDue { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreditLimit 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CreditLimit", EmitDefaultValue=false)]
		public DecimalValue? CreditLimit { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreditRule 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CreditVerification", EmitDefaultValue=false)]
		public StringValue? CreditVerification { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AR.CustomerClass 
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
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue? CurrencyRateType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultLocationCDFromBranch 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultLocationIDfromBranch", EmitDefaultValue=false)]
		public BooleanValue? DefaultLocationIDfromBranch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: GroupMask 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultRestrictionGroup", EmitDefaultValue=false)]
		public StringValue? DefaultRestrictionGroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DiscountAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue? DiscountAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DiscountSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue? DiscountSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowOverrideCury 
		/// DAC: PX.Objects.AR.CustomerClass 
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
		/// DAC: PX.Objects.AR.CustomerClass 
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
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EnableWriteOffs", EmitDefaultValue=false)]
		public BooleanValue? EnableWriteOffs { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AvalaraCustomerUsageType 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FreightAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FreightAccount", EmitDefaultValue=false)]
		public StringValue? FreightAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FreightSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FreightSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DiscountLimit 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="GroupDocumentDiscountLimit", EmitDefaultValue=false)]
		public DecimalValue? GroupDocumentDiscountLimit { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MiscAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MiscAccount", EmitDefaultValue=false)]
		public StringValue? MiscAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MiscSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MiscSubaccount", EmitDefaultValue=false)]
		public StringValue? MiscSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrintCuryStatements 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MultiCurrencyStatements", EmitDefaultValue=false)]
		public BooleanValue? MultiCurrencyStatements { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinChargeID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverdueChargeID", EmitDefaultValue=false)]
		public StringValue? OverdueChargeID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverLimitAmount 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverLimitAmount", EmitDefaultValue=false)]
		public DecimalValue? OverLimitAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefPaymentMethodID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrepaymentAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrepaymentAccount", EmitDefaultValue=false)]
		public StringValue? PrepaymentAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrepaymentSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrepaymentSubaccount", EmitDefaultValue=false)]
		public StringValue? PrepaymentSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PrintDunningLetters 
		/// DAC: PX.Objects.AR.CustomerClass 
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
		/// DAC: PX.Objects.AR.CustomerClass 
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
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PrintStatements", EmitDefaultValue=false)]
		public BooleanValue? PrintStatements { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RequireAvalaraCustomerUsageType 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequireEntityUsageType", EmitDefaultValue=false)]
		public BooleanValue? RequireEntityUsageType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RequireTaxZone 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequireTaxZone", EmitDefaultValue=false)]
		public BooleanValue? RequireTaxZone { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesPersonID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue? SalespersonID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MailDunningLetters 
		/// DAC: PX.Objects.AR.CustomerClass 
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
		/// DAC: PX.Objects.AR.CustomerClass 
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
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SendStatementsByEmail", EmitDefaultValue=false)]
		public BooleanValue? SendStatementsByEmail { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipComplete 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipTermsID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipVia 
		/// DAC: PX.Objects.AR.CustomerClass 
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
		/// DAC: PX.Objects.AR.CustomerClass 
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
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StatementType", EmitDefaultValue=false)]
		public StringValue? StatementType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxZoneID", EmitDefaultValue=false)]
		public StringValue? TaxZoneID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnrealizedGainAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnrealizedGainAccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedGainAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnrealizedGainSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnrealizedGainSubaccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedGainSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnrealizedLossAcctID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnrealizedLossAccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedLossAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnrealizedLossSubID 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnrealizedLossSubaccount", EmitDefaultValue=false)]
		public StringValue? UnrealizedLossSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SmallBalanceLimit 
		/// DAC: PX.Objects.AR.CustomerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WriteOffLimit", EmitDefaultValue=false)]
		public DecimalValue? WriteOffLimit { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}