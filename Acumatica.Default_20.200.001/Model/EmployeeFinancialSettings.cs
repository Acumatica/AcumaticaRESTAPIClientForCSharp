using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class EmployeeFinancialSettings : Entity_v4
	{

		[DataMember(Name="APAccount", EmitDefaultValue=false)]
		public StringValue APAccount { get; set; }

		[DataMember(Name="APSubaccount", EmitDefaultValue=false)]
		public StringValue APSubaccount { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue CashAccount { get; set; }

		[DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
		public StringValue ExpenseAccount { get; set; }

		[DataMember(Name="ExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue ExpenseSubaccount { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail> PaymentInstructions { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue PaymentMethod { get; set; }

		[DataMember(Name="PrepaymentAccount", EmitDefaultValue=false)]
		public StringValue PrepaymentAccount { get; set; }

		[DataMember(Name="PrepaymentSubaccount", EmitDefaultValue=false)]
		public StringValue PrepaymentSubaccount { get; set; }

		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue SalesAccount { get; set; }

		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue SalesSubaccount { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue TaxZone { get; set; }

		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue Terms { get; set; }

	}
}