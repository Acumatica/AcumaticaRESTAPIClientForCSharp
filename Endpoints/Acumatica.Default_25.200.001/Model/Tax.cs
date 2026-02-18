using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>TX205000</c> in the Acumatica ERP
	/// <para>Key Fields: TaxID</para>
	/// </summary>
	public class Tax : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The aggregated rule of tax calculation based on TaxCalcType and TaxCalcLevel.
		/// <para>DAC Field Name: TaxCalcRule</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Calculation Rule</para>
		/// <para>SQL Type: nchar(2)</para>
		/// </summary>
		public StringValue? CalculateOn { get; set; }

		/// <summary>
		/// The method of calculating the tax base amount if a cash discount is applied.
		/// <para>DAC Field Name: TaxApplyTermsDisc</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Cash Discount</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? CashDiscount { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the tax is a deductible VAT, which means that a company is allowed to deduct some part of the tax paid to a vendor from its own VAT liability to the government.
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Partially Deductible VAT</para>
		/// </summary>
		public BooleanValue? DeductibleVAT { get; set; }

		/// <summary>
		/// The description of the tax, which can be specified by the user.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the tax can be entered only by the documents from the Tax Bills and Adjustments form (TX303000).
		/// <para>DAC Field Name: DirectTax</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Direct-Entry Tax</para>
		/// </summary>
		public BooleanValue? EnterFromTaxBill { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the system should exclude the first-level/per unit tax amount from the tax basethat is used for calculation of the second-level tax amount in case of first-level taxes or all other taxes in case of per unit taxes.The flag is applicable to only first-level and per unit taxes.
		/// <para>DAC Field Name: TaxCalcLevel2Exclude</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Exclude from Tax-on-Tax Calculation</para>
		/// </summary>
		public BooleanValue? ExcludeFromTaxonTaxCalculation { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the calculated amount should be displayed in the VAT Exempt Total box in the documents, such as bills and invoices.
		/// <para>DAC Field Name: ExemptTax</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Include in VAT Exempt Total</para>
		/// </summary>
		public BooleanValue? IncludeInVATExemptTotal { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the VAT taxable amount should be displayed in the VAT Taxable Total box in the documents, such as bills and invoices. 
		/// <para>DAC Field Name: IncludeInTaxable</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Include in VAT Taxable Total</para>
		/// </summary>
		public BooleanValue? IncludeInVATTaxableTotal { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The date after which the tax is not effective.
		/// <para>DAC Field Name: OutDate</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Not Valid After</para>
		/// </summary>
		public DateTimeValue? NotValidAfter { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the tax is a pending VAT. The pending VAT should be calculated in documents, but should not be recorded in the tax report.Later the VAT of the pending type can be converted into the general VAT.
		/// <para>DAC Field Name: PendingTax</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Pending VAT</para>
		/// </summary>
		public BooleanValue? PendingVAT { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the tax is a reverse VAT. When the reverse VAT is applied to a company that supplies goods or service to other EU countries,the liability of reporting VAT is reversed and goes to the customer rather than to the vendor.
		/// <para>DAC Field Name: ReverseTax</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Reverse VAT</para>
		/// </summary>
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the tax is a statistical VAT. The statistical VAT is calculated for statistical purposes; the VAT is reported but not paid.
		/// <para>DAC Field Name: StatisticalTax</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Statistical VAT</para>
		/// </summary>
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// The foreign key to Vendor, which specifies the tax agency to which the tax belongs.The key can be NULL.
		/// <para>DAC Field Name: TaxVendorID</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax Agency</para>
		/// </summary>
		public StringValue? TaxAgency { get; set; }

		/// <summary>
		/// The foreign key to Account, which specifies the account that accumulates the tax amounts to be claimed from the tax agency for the tax reporting period.
		/// <para>DAC Field Name: PurchTaxAcctID</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax Claimable Account</para>
		/// </summary>
		public StringValue? TaxClaimableAccount { get; set; }

		/// <summary>
		/// The foreign key to Sub, which specifies the corresponding tax claimable subaccount.
		/// <para>DAC Field Name: PurchTaxSubID</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax Claimable Subaccount</para>
		/// </summary>
		public StringValue? TaxClaimableSubaccount { get; set; }

		/// <summary>
		/// The foreign key to Account, which specifies the expense account that is used to record eitherthe tax amounts of use taxes or the non-deductible tax amounts of deductible value-added taxes.
		/// <para>DAC Field Name: ExpenseAccountID</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax Expense Account</para>
		/// </summary>
		public StringValue? TaxExpenseAccount { get; set; }

		/// <summary>
		/// The foreign key to Sub, which specifies the corresponding expense subaccount.
		/// <para>DAC Field Name: ExpenseSubID</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax Expense Subaccount</para>
		/// </summary>
		public StringValue? TaxExpenseSubaccount { get; set; }

		/// <summary>
		/// The tax ID. This is the key field, which can be specified by the user.
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// The foreign key to Account, which specifies the liability account that accumulates the tax amounts to be paid to a tax agency for the tax reporting period.
		/// <para>DAC Field Name: SalesTaxAcctID</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax Payable Account</para>
		/// </summary>
		public StringValue? TaxPayableAccount { get; set; }

		/// <summary>
		/// The foreign key to Sub, which specifies the corresponding tax payable subaccount.
		/// <para>DAC Field Name: SalesTaxSubID</para>
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax Payable Subaccount</para>
		/// </summary>
		public StringValue? TaxPayableSubaccount { get; set; }

		public List<TaxScheduleDetail>? TaxSchedule { get; set; }

		/// <summary>
		/// The type of the tax.
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? TaxType { get; set; }

		public List<TaxZoneDetail>? Zones { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string TaxSchedule = "TaxSchedule";
			public const string TaxSchedule_Files = "TaxSchedule/Files";
			public const string Zones = "Zones";
			public const string Zones_Files = "Zones/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,TaxSchedule,TaxSchedule/Files,Zones,Zones/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}