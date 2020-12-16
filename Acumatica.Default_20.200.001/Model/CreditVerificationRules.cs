using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CreditVerificationRules : Entity_v4
	{

		[DataMember(Name="CreditDaysPastDue", EmitDefaultValue=false)]
		public ShortValue CreditDaysPastDue { get; set; }

		[DataMember(Name="CreditLimit", EmitDefaultValue=false)]
		public DecimalValue CreditLimit { get; set; }

		[DataMember(Name="CreditVerification", EmitDefaultValue=false)]
		public StringValue CreditVerification { get; set; }

		[DataMember(Name="FirstDueDate", EmitDefaultValue=false)]
		public DateTimeValue FirstDueDate { get; set; }

		[DataMember(Name="OpenOrdersBalance", EmitDefaultValue=false)]
		public DecimalValue OpenOrdersBalance { get; set; }

		[DataMember(Name="RemainingCreditLimit", EmitDefaultValue=false)]
		public DecimalValue RemainingCreditLimit { get; set; }

		[DataMember(Name="UnreleasedBalance", EmitDefaultValue=false)]
		public DecimalValue UnreleasedBalance { get; set; }

	}
}