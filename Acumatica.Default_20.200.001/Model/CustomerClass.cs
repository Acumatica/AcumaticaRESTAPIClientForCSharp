using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CustomerClass : Entity_v4
	{

		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue ApplyOverdueCharges { get; set; }

		[DataMember(Name="ARAccount", EmitDefaultValue=false)]
		public StringValue ARAccount { get; set; }

		[DataMember(Name="ARSubaccount", EmitDefaultValue=false)]
		public StringValue ARSubaccount { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<BusinessAccountClassAttributeDetail> Attributes { get; set; }

		[DataMember(Name="AutoApplyPayments", EmitDefaultValue=false)]
		public BooleanValue AutoApplyPayments { get; set; }

		[DataMember(Name="CashDiscountAccount", EmitDefaultValue=false)]
		public StringValue CashDiscountAccount { get; set; }

		[DataMember(Name="CashDiscountSubaccount", EmitDefaultValue=false)]
		public StringValue CashDiscountSubaccount { get; set; }

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue ClassID { get; set; }

		[DataMember(Name="COGSAccount", EmitDefaultValue=false)]
		public StringValue COGSAccount { get; set; }

		[DataMember(Name="COGSSubaccount", EmitDefaultValue=false)]
		public StringValue COGSSubaccount { get; set; }

		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue Country { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="CreditDaysPastDue", EmitDefaultValue=false)]
		public ShortValue CreditDaysPastDue { get; set; }

		[DataMember(Name="CreditLimit", EmitDefaultValue=false)]
		public DecimalValue CreditLimit { get; set; }

		[DataMember(Name="CreditVerification", EmitDefaultValue=false)]
		public StringValue CreditVerification { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue CurrencyRateType { get; set; }

		[DataMember(Name="DefaultLocationIDfromBranch", EmitDefaultValue=false)]
		public BooleanValue DefaultLocationIDfromBranch { get; set; }

		[DataMember(Name="DefaultRestrictionGroup", EmitDefaultValue=false)]
		public StringValue DefaultRestrictionGroup { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue DiscountAccount { get; set; }

		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue DiscountSubaccount { get; set; }

		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue EnableCurrencyOverride { get; set; }

		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue EnableRateOverride { get; set; }

		[DataMember(Name="EnableWriteOffs", EmitDefaultValue=false)]
		public BooleanValue EnableWriteOffs { get; set; }

		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue EntityUsageType { get; set; }

		[DataMember(Name="FreightAccount", EmitDefaultValue=false)]
		public StringValue FreightAccount { get; set; }

		[DataMember(Name="FreightSubaccount", EmitDefaultValue=false)]
		public StringValue FreightSubaccount { get; set; }

		[DataMember(Name="GroupDocumentDiscountLimit", EmitDefaultValue=false)]
		public DecimalValue GroupDocumentDiscountLimit { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="MiscAccount", EmitDefaultValue=false)]
		public StringValue MiscAccount { get; set; }

		[DataMember(Name="MiscSubaccount", EmitDefaultValue=false)]
		public StringValue MiscSubaccount { get; set; }

		[DataMember(Name="MultiCurrencyStatements", EmitDefaultValue=false)]
		public BooleanValue MultiCurrencyStatements { get; set; }

		[DataMember(Name="OverdueChargeID", EmitDefaultValue=false)]
		public StringValue OverdueChargeID { get; set; }

		[DataMember(Name="OverLimitAmount", EmitDefaultValue=false)]
		public DecimalValue OverLimitAmount { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue PaymentMethod { get; set; }

		[DataMember(Name="PrepaymentAccount", EmitDefaultValue=false)]
		public StringValue PrepaymentAccount { get; set; }

		[DataMember(Name="PrepaymentSubaccount", EmitDefaultValue=false)]
		public StringValue PrepaymentSubaccount { get; set; }

		[DataMember(Name="PrintDunningLetters", EmitDefaultValue=false)]
		public BooleanValue PrintDunningLetters { get; set; }

		[DataMember(Name="PrintInvoices", EmitDefaultValue=false)]
		public BooleanValue PrintInvoices { get; set; }

		[DataMember(Name="PrintStatements", EmitDefaultValue=false)]
		public BooleanValue PrintStatements { get; set; }

		[DataMember(Name="RequireEntityUsageType", EmitDefaultValue=false)]
		public BooleanValue RequireEntityUsageType { get; set; }

		[DataMember(Name="RequireTaxZone", EmitDefaultValue=false)]
		public BooleanValue RequireTaxZone { get; set; }

		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue SalesAccount { get; set; }

		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue SalespersonID { get; set; }

		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue SalesSubaccount { get; set; }

		[DataMember(Name="SendDunningLettersbyEmail", EmitDefaultValue=false)]
		public BooleanValue SendDunningLettersbyEmail { get; set; }

		[DataMember(Name="SendInvoicesbyEmail", EmitDefaultValue=false)]
		public BooleanValue SendInvoicesbyEmail { get; set; }

		[DataMember(Name="SendStatementsByEmail", EmitDefaultValue=false)]
		public BooleanValue SendStatementsByEmail { get; set; }

		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue ShippingRule { get; set; }

		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue ShippingTerms { get; set; }

		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue ShipVia { get; set; }

		[DataMember(Name="StatementCycleID", EmitDefaultValue=false)]
		public StringValue StatementCycleID { get; set; }

		[DataMember(Name="StatementType", EmitDefaultValue=false)]
		public StringValue StatementType { get; set; }

		[DataMember(Name="TaxZoneID", EmitDefaultValue=false)]
		public StringValue TaxZoneID { get; set; }

		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue Terms { get; set; }

		[DataMember(Name="UnrealizedGainAccount", EmitDefaultValue=false)]
		public StringValue UnrealizedGainAccount { get; set; }

		[DataMember(Name="UnrealizedGainSubaccount", EmitDefaultValue=false)]
		public StringValue UnrealizedGainSubaccount { get; set; }

		[DataMember(Name="UnrealizedLossAccount", EmitDefaultValue=false)]
		public StringValue UnrealizedLossAccount { get; set; }

		[DataMember(Name="UnrealizedLossSubaccount", EmitDefaultValue=false)]
		public StringValue UnrealizedLossSubaccount { get; set; }

		[DataMember(Name="WriteOffLimit", EmitDefaultValue=false)]
		public DecimalValue WriteOffLimit { get; set; }

	}
}