using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class FinancialYear : Entity_v4
	{

		[DataMember(Name="AdjustToPeriodStart", EmitDefaultValue=false)]
		public BooleanValue AdjustToPeriodStart { get; set; }

		[DataMember(Name="BelongsToNextYear", EmitDefaultValue=false)]
		public BooleanValue BelongsToNextYear { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
		public StringValue DayOfWeek { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<FinancialYearPeriodDetail> Details { get; set; }

		[DataMember(Name="FinancialYearStartsOn", EmitDefaultValue=false)]
		public DateTimeValue FinancialYearStartsOn { get; set; }

		[DataMember(Name="FirstFinancialYear", EmitDefaultValue=false)]
		public StringValue FirstFinancialYear { get; set; }

		[DataMember(Name="FirstPeriodStartDate", EmitDefaultValue=false)]
		public DateTimeValue FirstPeriodStartDate { get; set; }

		[DataMember(Name="HasAdjustmentPeriod", EmitDefaultValue=false)]
		public BooleanValue HasAdjustmentPeriod { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LengthOfFinancialPeriodInDays", EmitDefaultValue=false)]
		public ShortValue LengthOfFinancialPeriodInDays { get; set; }

		[DataMember(Name="NbrOfFinancialPeriods", EmitDefaultValue=false)]
		public ShortValue NbrOfFinancialPeriods { get; set; }

		[DataMember(Name="PeriodsStartDayOfWeek", EmitDefaultValue=false)]
		public StringValue PeriodsStartDayOfWeek { get; set; }

		[DataMember(Name="PeriodType", EmitDefaultValue=false)]
		public StringValue PeriodType { get; set; }

		[DataMember(Name="UserDefinedPeriods", EmitDefaultValue=false)]
		public BooleanValue UserDefinedPeriods { get; set; }

		[DataMember(Name="YearEndCalculationMethod", EmitDefaultValue=false)]
		public StringValue YearEndCalculationMethod { get; set; }

	}
}