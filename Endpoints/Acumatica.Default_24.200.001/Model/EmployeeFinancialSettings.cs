using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class EmployeeFinancialSettings : Entity
	{

		/// <summary>
		/// The identifier of the AP account of the vendor location.
		/// <para>DAC Field Name: VAPAccountID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: AP Account</para>
		/// </summary>
		[DataMember(Name="APAccount", EmitDefaultValue=false)]
		public StringValue? APAccount { get; set; }

		/// <summary>
		/// The identifier of the AP subaccount of the vendor location.
		/// <para>DAC Field Name: VAPSubID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: AP Sub.</para>
		/// </summary>
		[DataMember(Name="APSubaccount", EmitDefaultValue=false)]
		public StringValue? APSubaccount { get; set; }

		/// <summary>
		/// The cash account indentifier of the vendor location.
		/// <para>DAC Field Name: VCashAccountID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// Identifier of the account that will be used to record compensation amounts paid to the employee.
		/// <para>DAC Field Name: ExpenseAcctID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Expense Account</para>
		/// </summary>
		[DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccount { get; set; }

		/// <summary>
		/// The identifier of the corresponding subaccount that will be used to record compensation amounts paid to the employee.
		/// <para>DAC Field Name: ExpenseSubID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Expense Sub.</para>
		/// </summary>
		[DataMember(Name="ExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? ExpenseSubaccount { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail>? PaymentInstructions { get; set; }

		/// <summary>
		/// The payment method indentifier of the vendor location.
		/// <para>DAC Field Name: VPaymentMethodID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// Identifier of the AP account to be used to record prepayments paid to the employee.
		/// <para>DAC Field Name: PrepaymentAcctID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Prepayment Account</para>
		/// </summary>
		[DataMember(Name="PrepaymentAccount", EmitDefaultValue=false)]
		public StringValue? PrepaymentAccount { get; set; }

		/// <summary>
		/// The identifier of the corresponding subaccount to be used to record prepayments paid to the employee.
		/// <para>DAC Field Name: PrepaymentSubID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Prepayment Sub.</para>
		/// </summary>
		[DataMember(Name="PrepaymentSubaccount", EmitDefaultValue=false)]
		public StringValue? PrepaymentSubaccount { get; set; }

		/// <summary>
		/// Identifier of the account to be used to record sales made by the employee, if applicable.
		/// <para>DAC Field Name: SalesAcctID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Sales Account</para>
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// The identifier of the corresponding subaccount to be used to record sales made by the employee.
		/// <para>DAC Field Name: SalesSubID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Sales Sub.</para>
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// The vendor's tax zone.
		/// <para>DAC Field Name: VTaxZoneID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TermsID</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

	}
}