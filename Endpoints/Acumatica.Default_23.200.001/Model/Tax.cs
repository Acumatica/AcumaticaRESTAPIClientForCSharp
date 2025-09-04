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
	/// Corresponds to the screen TX205000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Tax : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The aggregated rule of tax calculation based on TaxCalcType and TaxCalcLevel.
		/// DAC Field Name: TaxCalcRule 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Calculation Rule 
		/// SQL Type: nchar(2) 
		/// </summary>
		[DataMember(Name="CalculateOn", EmitDefaultValue=false)]
		public StringValue? CalculateOn { get; set; }

		/// <summary>
		/// The method of calculating the tax base amount if a cash discount is applied.
		/// DAC Field Name: TaxApplyTermsDisc 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Cash Discount 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="CashDiscount", EmitDefaultValue=false)]
		public StringValue? CashDiscount { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the tax is a deductible VAT, which means that a company is allowed to deduct some part of the tax paid to a vendor from its own VAT liability to the government.
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Partially Deductible VAT 
		/// </summary>
		[DataMember(Name="DeductibleVAT", EmitDefaultValue=false)]
		public BooleanValue? DeductibleVAT { get; set; }

		/// <summary>
		/// The description of the tax, which can be specified by the user.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.TX.Tax 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the tax can be entered only by the documents from the Tax Bills and Adjustments form (TX303000).
		/// DAC Field Name: DirectTax 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Direct-Entry Tax 
		/// </summary>
		[DataMember(Name="EnterFromTaxBill", EmitDefaultValue=false)]
		public BooleanValue? EnterFromTaxBill { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the system should exclude the first-level/per unit tax amount from the tax basethat is used for calculation of the second-level tax amount in case of first-level taxes or all other taxes in case of per unit taxes.The flag is applicable to only first-level and per unit taxes.
		/// DAC Field Name: TaxCalcLevel2Exclude 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Exclude from Tax-on-Tax Calculation 
		/// </summary>
		[DataMember(Name="ExcludeFromTaxonTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue? ExcludeFromTaxonTaxCalculation { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the calculated amount should be displayed in the VAT Exempt Total box in the documents, such as bills and invoices.
		/// DAC Field Name: ExemptTax 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Include in VAT Exempt Total 
		/// </summary>
		[DataMember(Name="IncludeInVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeInVATExemptTotal { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the VAT taxable amount should be displayed in the VAT Taxable Total box in the documents, such as bills and invoices. 
		/// DAC Field Name: IncludeInTaxable 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Include in VAT Taxable Total 
		/// </summary>
		[DataMember(Name="IncludeInVATTaxableTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeInVATTaxableTotal { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The date after which the tax is not effective.
		/// DAC Field Name: OutDate 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Not Valid After 
		/// </summary>
		[DataMember(Name="NotValidAfter", EmitDefaultValue=false)]
		public DateTimeValue? NotValidAfter { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the tax is a pending VAT. The pending VAT should be calculated in documents, but should not be recorded in the tax report.Later the VAT of the pending type can be converted into the general VAT.
		/// DAC Field Name: PendingTax 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Pending VAT 
		/// </summary>
		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue? PendingVAT { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the tax is a reverse VAT. When the reverse VAT is applied to a company that supplies goods or service to other EU countries,the liability of reporting VAT is reversed and goes to the customer rather than to the vendor.
		/// DAC Field Name: ReverseTax 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Reverse VAT 
		/// </summary>
		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the tax is a statistical VAT. The statistical VAT is calculated for statistical purposes; the VAT is reported but not paid.
		/// DAC Field Name: StatisticalTax 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Statistical VAT 
		/// </summary>
		[DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// The foreign key to Vendor, which specifies the tax agency to which the tax belongs.The key can be NULL.
		/// DAC Field Name: TaxVendorID 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Tax Agency 
		/// </summary>
		[DataMember(Name="TaxAgency", EmitDefaultValue=false)]
		public StringValue? TaxAgency { get; set; }

		/// <summary>
		/// The foreign key to Account, which specifies the account that accumulates the tax amounts to be claimed from the tax agency for the tax reporting period.
		/// DAC Field Name: PurchTaxAcctID 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Tax Claimable Account 
		/// </summary>
		[DataMember(Name="TaxClaimableAccount", EmitDefaultValue=false)]
		public StringValue? TaxClaimableAccount { get; set; }

		/// <summary>
		/// The foreign key to Sub, which specifies the corresponding tax claimable subaccount.
		/// DAC Field Name: PurchTaxSubID 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Tax Claimable Subaccount 
		/// </summary>
		[DataMember(Name="TaxClaimableSubaccount", EmitDefaultValue=false)]
		public StringValue? TaxClaimableSubaccount { get; set; }

		/// <summary>
		/// The foreign key to Account, which specifies the expense account that is used to record eitherthe tax amounts of use taxes or the non-deductible tax amounts of deductible value-added taxes.
		/// DAC Field Name: ExpenseAccountID 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Tax Expense Account 
		/// </summary>
		[DataMember(Name="TaxExpenseAccount", EmitDefaultValue=false)]
		public StringValue? TaxExpenseAccount { get; set; }

		/// <summary>
		/// The foreign key to Sub, which specifies the corresponding expense subaccount.
		/// DAC Field Name: ExpenseSubID 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Tax Expense Subaccount 
		/// </summary>
		[DataMember(Name="TaxExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? TaxExpenseSubaccount { get; set; }

		/// <summary>
		/// The tax ID. This is the key field, which can be specified by the user.
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Tax ID 
		/// SQL Type: nvarchar(60) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// The foreign key to Account, which specifies the liability account that accumulates the tax amounts to be paid to a tax agency for the tax reporting period.
		/// DAC Field Name: SalesTaxAcctID 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Tax Payable Account 
		/// </summary>
		[DataMember(Name="TaxPayableAccount", EmitDefaultValue=false)]
		public StringValue? TaxPayableAccount { get; set; }

		/// <summary>
		/// The foreign key to Sub, which specifies the corresponding tax payable subaccount.
		/// DAC Field Name: SalesTaxSubID 
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Tax Payable Subaccount 
		/// </summary>
		[DataMember(Name="TaxPayableSubaccount", EmitDefaultValue=false)]
		public StringValue? TaxPayableSubaccount { get; set; }

		[DataMember(Name="TaxSchedule", EmitDefaultValue=false)]
		public List<TaxScheduleDetail>? TaxSchedule { get; set; }

		/// <summary>
		/// The type of the tax.
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Tax Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue? TaxType { get; set; }

		[DataMember(Name="Zones", EmitDefaultValue=false)]
		public List<TaxZoneDetail>? Zones { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}