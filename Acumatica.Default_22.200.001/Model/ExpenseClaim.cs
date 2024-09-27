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
	/// Corresponds to the screen EP301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ExpenseClaim : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The date when the claim was approved.
		/// DAC Field Name: ApproveDate 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Approval Date 
		/// </summary>
		[DataMember(Name="ApprovalDate", EmitDefaultValue=false)]
		public DateTimeValue? ApprovalDate { get; set; }

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval>? ApprovalDetails { get; set; }

		/// <summary>
		/// Identifier of the base Currency.
		/// DAC Field Name: BaseCuryID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Base Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// The identifier of the employee who claims the expenses.When the claim is released, an Accounts Payable bill will be generated for this employee.
		/// DAC Field Name: EmployeeID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Claimed By 
		/// </summary>
		[DataMember(Name="ClaimedBy", EmitDefaultValue=false)]
		public StringValue? ClaimedBy { get; set; }

		/// <summary>
		/// The total amount of the claim in the currency of the document.The amount is calculated as the sum of the amounts in the Claim Amount column of the Expense Claim Details table located on the Expense Claim (EP301000) form for all lines specified for the claim with taxes applied.
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Claim Total 
		/// </summary>
		[DataMember(Name="ClaimTotal", EmitDefaultValue=false)]
		public DecimalValue? ClaimTotal { get; set; }

		/// <summary>
		/// The code of the currency of the document.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The exchange rate used for calculations and determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// DAC Field Name: SampleCuryRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Curr. Rate 
		/// </summary>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// The identifier of the Customer associated with the expense claim.
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Customer 
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The date when the claim was entered.
		/// DAC Field Name: DocDate 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The department associated with the expense claim.
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Department ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DepartmentID", EmitDefaultValue=false)]
		public StringValue? DepartmentID { get; set; }

		/// <summary>
		/// A description of the claim.
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ExpenseClaimDetails>? Details { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public ExpenseClaimFinancialDetail? FinancialDetails { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the customer location associated with the document.
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// The inverse of the SampleCuryRate. This value is also determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// DAC Field Name: SampleRecipRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Reciprocal Rate 
		/// </summary>
		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// The unique reference number of the expense claim document, which the system assigns based on the numbering sequence specified for claims on the Time and Expenses Preferences (EP101000) form (which corresponds to the EPSetupMaint graph).This field is the key field.
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		/// <summary>
		/// The status of the expense claim.
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<ExpenseClaimTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The total amount of taxes associated with the document in the currency of the document.(Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// The document total (in the currency of the document) that is exempt from VAT.This total is calculated as the taxable amount for the tax with the Include in VAT Exempt Total check box selected on the Taxes (TX205000) form. This box is available only if the VAT Reporting feature is enabled on the Enable/Disable Features (CS100000) form (which corresponds to the FeaturesMaint graph).(Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryVatExemptTotal 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: VAT Exempt Total 
		/// </summary>
		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue? VATExemptTotal { get; set; }

		/// <summary>
		/// The document total (in the currency of the document) that is subject to VAT.This box is available only if the VAT Reporting feature is enabled on the Enable/Disable Features (CS100000) form (which corresponds to the FeaturesMaint graph). The VAT taxable amount is displayed in this box only if the Include in VAT Taxable Total check box is selected for the applicable tax on the Taxes (TX205000) form (which corresponds to the SalesTaxMaint graph). If the check box is cleared, this box will be empty.(Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryVatTaxableTotal 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: VAT Taxable Total 
		/// </summary>
		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue? VATTaxableTotal { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}