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
	public class CreditVerificationRules : Entity
	{

		/// <summary>
		/// If CreditRule enables verification by days past due,this field determines the maximum number of credit days past due allowed for the customer. The actual number of days past due is calculated from the due date of the earliest open customer invoice (which is specified by OldInvoiceDate).
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Credit Days Past Due 
		/// </summary>
		[DataMember(Name="CreditDaysPastDue", EmitDefaultValue=false)]
		public ShortValue? CreditDaysPastDue { get; set; }

		/// <summary>
		/// If CreditRule enables verification by credit limit,this field determines the maximum amount of credit allowed for the customer.
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Credit Limit 
		/// </summary>
		[DataMember(Name="CreditLimit", EmitDefaultValue=false)]
		public DecimalValue? CreditLimit { get; set; }

		/// <summary>
		/// The type of credit verification for the customer.The list of possible values of the field is determinedby CreditRuleAttribute.
		/// DAC Field Name: CreditRule 
		/// DAC: PX.Objects.AR.Customer 
		/// Display Name: Credit Verification 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="CreditVerification", EmitDefaultValue=false)]
		public StringValue? CreditVerification { get; set; }

		/// <summary>
		/// DAC Field Name: OldInvoiceDate 
		/// DAC: PX.Objects.AR.CustomerMaint+CustomerBalanceSummary 
		/// </summary>
		[DataMember(Name="FirstDueDate", EmitDefaultValue=false)]
		public DateTimeValue? FirstDueDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerMaint+CustomerBalanceSummary 
		/// </summary>
		[DataMember(Name="OpenOrdersBalance", EmitDefaultValue=false)]
		public DecimalValue? OpenOrdersBalance { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerMaint+CustomerBalanceSummary 
		/// </summary>
		[DataMember(Name="RemainingCreditLimit", EmitDefaultValue=false)]
		public DecimalValue? RemainingCreditLimit { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.CustomerMaint+CustomerBalanceSummary 
		/// </summary>
		[DataMember(Name="UnreleasedBalance", EmitDefaultValue=false)]
		public DecimalValue? UnreleasedBalance { get; set; }

	}
}