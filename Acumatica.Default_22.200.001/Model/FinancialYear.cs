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
	/// Corresponds to the screen GL101000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class FinancialYear : Entity, ITopLevelEntity
	{

		[DataMember(Name="AdjustToPeriodStart", EmitDefaultValue=false)]
		public BooleanValue? AdjustToPeriodStart { get; set; }

		/// <summary>
		/// When set to true, indicates that the system must set the financial year to the one,following the year of the selected start date of the year.
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: Belongs to Next Year 
		/// </summary>
		[DataMember(Name="BelongsToNextYear", EmitDefaultValue=false)]
		public BooleanValue? BelongsToNextYear { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The day of the week of the last day of the financial year.Relevant ony for the period types based on weeks andif the EndYearCalcMethod is not "CA" - Last day of the financial year.
		/// DAC Field Name: YearLastDayOfWeek 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: Day of Week 
		/// </summary>
		[DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
		public StringValue? DayOfWeek { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<FinancialYearPeriodDetail>? Details { get; set; }

		/// <summary>
		/// The start date of the financial year.
		/// DAC Field Name: BegFinYear 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: Financial Year Starts On 
		/// </summary>
		[DataMember(Name="FinancialYearStartsOn", EmitDefaultValue=false)]
		public DateTimeValue? FinancialYearStartsOn { get; set; }

		/// <summary>
		/// First financial year, for which data is stored in the system.
		/// DAC Field Name: FirstFinYear 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: First Financial Year 
		/// SQL Type: char(4) 
		/// </summary>
		[DataMember(Name="FirstFinancialYear", EmitDefaultValue=false)]
		public StringValue? FirstFinancialYear { get; set; }

		/// <summary>
		/// The start date of the first period of the year.
		/// DAC Field Name: PeriodsStartDate 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: First Period Start Date 
		/// </summary>
		[DataMember(Name="FirstPeriodStartDate", EmitDefaultValue=false)]
		public DateTimeValue? FirstPeriodStartDate { get; set; }

		/// <summary>
		/// When set to true, indicates that the system generates an additional period for posting adjustments.The adjustment period has the same start and end date and is the last period of the year.No date in the year corresponds to the adjustment period, so it can be selected for a particular document or batch only manually.See also the IsAdjustment field.
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: Has Adjustment Period 
		/// </summary>
		[DataMember(Name="HasAdjustmentPeriod", EmitDefaultValue=false)]
		public BooleanValue? HasAdjustmentPeriod { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Obsolete field.The length of periods of the year in days.
		/// DAC Field Name: PeriodLength 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: Length of Financial Period (days) 
		/// </summary>
		[DataMember(Name="LengthOfFinancialPeriodInDays", EmitDefaultValue=false)]
		public ShortValue? LengthOfFinancialPeriodInDays { get; set; }

		/// <summary>
		/// The number of financial periods in the year.
		/// DAC Field Name: FinPeriods 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: Number of Financial Periods  
		/// </summary>
		[DataMember(Name="NbrOfFinancialPeriods", EmitDefaultValue=false)]
		public ShortValue? NbrOfFinancialPeriods { get; set; }

		/// <summary>
		/// The day of the week when period starts.Relevant only for the period types based on weeks.
		/// DAC Field Name: EndYearDayOfWeek 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: Periods Start Day of Week 
		/// </summary>
		[DataMember(Name="PeriodsStartDayOfWeek", EmitDefaultValue=false)]
		public StringValue? PeriodsStartDayOfWeek { get; set; }

		/// <summary>
		/// The type of financial periods that make up the year.
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: Period Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="PeriodType", EmitDefaultValue=false)]
		public StringValue? PeriodType { get; set; }

		/// <summary>
		/// The read-only field indicating whether the periods of the year can be modified by user.
		/// DAC Field Name: UserDefined 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: User-Defined Periods 
		/// </summary>
		[DataMember(Name="UserDefinedPeriods", EmitDefaultValue=false)]
		public BooleanValue? UserDefinedPeriods { get; set; }

		/// <summary>
		/// The method used to determine the end date of a year with week-long periods.
		/// DAC Field Name: EndYearCalcMethod 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// Display Name: Year End Calculation Method 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="YearEndCalculationMethod", EmitDefaultValue=false)]
		public StringValue? YearEndCalculationMethod { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}