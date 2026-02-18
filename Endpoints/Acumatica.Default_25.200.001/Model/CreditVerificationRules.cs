using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class CreditVerificationRules : Entity
	{

		/// <summary>
		/// If CreditRule enables verification by days past due,this field determines the maximum number of credit days past due allowed for the customer. The actual number of days past due is calculated from the due date of the earliest open customer invoice (which is specified by OldInvoiceDate).
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Credit Days Past Due</para>
		/// </summary>
		public ShortValue? CreditDaysPastDue { get; set; }

		/// <summary>
		/// If CreditRule enables verification by credit limit,this field determines the maximum amount of credit allowed for the customer.
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Credit Limit</para>
		/// </summary>
		public DecimalValue? CreditLimit { get; set; }

		/// <summary>
		/// The type of credit verification for the customer.The list of possible values of the field is determinedby CreditRuleAttribute.
		/// <para>DAC Field Name: CreditRule</para>
		/// <para>DAC: PX.Objects.AR.Customer</para>
		/// <para>Display Name: Credit Verification</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? CreditVerification { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OldInvoiceDate</para>
		/// <para>DAC: PX.Objects.AR.CustomerMaint+CustomerBalanceSummary</para>
		/// </summary>
		public DateTimeValue? FirstDueDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerMaint+CustomerBalanceSummary</para>
		/// </summary>
		public DecimalValue? OpenOrdersBalance { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerMaint+CustomerBalanceSummary</para>
		/// </summary>
		public DecimalValue? RemainingCreditLimit { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.CustomerMaint+CustomerBalanceSummary</para>
		/// </summary>
		public DecimalValue? UnreleasedBalance { get; set; }

	}
}