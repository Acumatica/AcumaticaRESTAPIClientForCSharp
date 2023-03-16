using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class PaymentPeriod : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="FinYear", EmitDefaultValue=false)]
		public StringValue FinYear { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="PayPeriodID", EmitDefaultValue=false)]
		public StringValue PayPeriodID { get; set; }

		[DataMember(Name="PeriodNbr", EmitDefaultValue=false)]
		public StringValue PeriodNbr { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue TransactionDate { get; set; }

	}
}