using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class FinancialPeriodDetail : Entity_v4
	{

		[DataMember(Name="AdjustmentPeriod", EmitDefaultValue=false)]
		public BooleanValue AdjustmentPeriod { get; set; }

		[DataMember(Name="ClosedInAP", EmitDefaultValue=false)]
		public BooleanValue ClosedInAP { get; set; }

		[DataMember(Name="ClosedInAR", EmitDefaultValue=false)]
		public BooleanValue ClosedInAR { get; set; }

		[DataMember(Name="ClosedInCA", EmitDefaultValue=false)]
		public BooleanValue ClosedInCA { get; set; }

		[DataMember(Name="ClosedInFA", EmitDefaultValue=false)]
		public BooleanValue ClosedInFA { get; set; }

		[DataMember(Name="ClosedInIN", EmitDefaultValue=false)]
		public BooleanValue ClosedInIN { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="FinancialPeriodID", EmitDefaultValue=false)]
		public StringValue FinancialPeriodID { get; set; }

		[DataMember(Name="LengthInDays", EmitDefaultValue=false)]
		public IntValue LengthInDays { get; set; }

		[DataMember(Name="PeriodNbr", EmitDefaultValue=false)]
		public StringValue PeriodNbr { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

	}
}