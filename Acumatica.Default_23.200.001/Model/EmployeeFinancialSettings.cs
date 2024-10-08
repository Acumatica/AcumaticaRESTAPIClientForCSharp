using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class EmployeeFinancialSettings : Entity
	{

		/// <summary>
		/// The identifier of the AP account of the vendor location.
		/// DAC Field Name: VAPAccountID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: AP Account 
		/// </summary>
		[DataMember(Name="APAccount", EmitDefaultValue=false)]
		public StringValue? APAccount { get; set; }

		/// <summary>
		/// The identifier of the AP subaccount of the vendor location.
		/// DAC Field Name: VAPSubID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: AP Sub. 
		/// </summary>
		[DataMember(Name="APSubaccount", EmitDefaultValue=false)]
		public StringValue? APSubaccount { get; set; }

		/// <summary>
		/// The cash account indentifier of the vendor location.
		/// DAC Field Name: VCashAccountID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// Identifier of the account that will be used to record compensation amounts paid to the employee.
		/// DAC Field Name: ExpenseAcctID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Expense Account 
		/// </summary>
		[DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccount { get; set; }

		/// <summary>
		/// The identifier of the corresponding subaccount that will be used to record compensation amounts paid to the employee.
		/// DAC Field Name: ExpenseSubID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Expense Sub. 
		/// </summary>
		[DataMember(Name="ExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? ExpenseSubaccount { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail>? PaymentInstructions { get; set; }

		/// <summary>
		/// The payment method indentifier of the vendor location.
		/// DAC Field Name: VPaymentMethodID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Payment Method 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// Identifier of the AP account to be used to record prepayments paid to the employee.
		/// DAC Field Name: PrepaymentAcctID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Prepayment Account 
		/// </summary>
		[DataMember(Name="PrepaymentAccount", EmitDefaultValue=false)]
		public StringValue? PrepaymentAccount { get; set; }

		/// <summary>
		/// The identifier of the corresponding subaccount to be used to record prepayments paid to the employee.
		/// DAC Field Name: PrepaymentSubID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Prepayment Sub. 
		/// </summary>
		[DataMember(Name="PrepaymentSubaccount", EmitDefaultValue=false)]
		public StringValue? PrepaymentSubaccount { get; set; }

		/// <summary>
		/// Identifier of the account to be used to record sales made by the employee, if applicable.
		/// DAC Field Name: SalesAcctID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Sales Account 
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// The identifier of the corresponding subaccount to be used to record sales made by the employee.
		/// DAC Field Name: SalesSubID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Sales Sub. 
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// The vendor's tax zone.
		/// DAC Field Name: VTaxZoneID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// DAC Field Name: TermsID 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

	}
}