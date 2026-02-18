using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>GL101000</c> in the Acumatica ERP
	/// </summary>
	public class FinancialYear : Entity, ITopLevelEntity
	{

		public BooleanValue? AdjustToPeriodStart { get; set; }

		/// <summary>
		/// When set to true, indicates that the system must set the financial year to the one,following the year of the selected start date of the year.
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: Belongs to Next Year</para>
		/// </summary>
		public BooleanValue? BelongsToNextYear { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The day of the week of the last day of the financial year.Relevant ony for the period types based on weeks andif the EndYearCalcMethod is not "CA" - Last day of the financial year.
		/// <para>DAC Field Name: YearLastDayOfWeek</para>
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: Day of Week</para>
		/// </summary>
		public StringValue? DayOfWeek { get; set; }

		public List<FinancialYearPeriodDetail>? Details { get; set; }

		/// <summary>
		/// The start date of the financial year.
		/// <para>DAC Field Name: BegFinYear</para>
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: Financial Year Starts On</para>
		/// </summary>
		public DateTimeValue? FinancialYearStartsOn { get; set; }

		/// <summary>
		/// First financial year, for which data is stored in the system.
		/// <para>DAC Field Name: FirstFinYear</para>
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: First Financial Year</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		public StringValue? FirstFinancialYear { get; set; }

		/// <summary>
		/// The start date of the first period of the year.
		/// <para>DAC Field Name: PeriodsStartDate</para>
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: First Period Start Date</para>
		/// </summary>
		public DateTimeValue? FirstPeriodStartDate { get; set; }

		/// <summary>
		/// When set to true, indicates that the system generates an additional period for posting adjustments.The adjustment period has the same start and end date and is the last period of the year.No date in the year corresponds to the adjustment period, so it can be selected for a particular document or batch only manually.See also the IsAdjustment field.
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: Has Adjustment Period</para>
		/// </summary>
		public BooleanValue? HasAdjustmentPeriod { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Obsolete field.The length of periods of the year in days.
		/// <para>DAC Field Name: PeriodLength</para>
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: Length of Financial Period (days)</para>
		/// </summary>
		public ShortValue? LengthOfFinancialPeriodInDays { get; set; }

		/// <summary>
		/// The number of financial periods in the year.
		/// <para>DAC Field Name: FinPeriods</para>
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: Number of Financial Periods </para>
		/// </summary>
		public ShortValue? NbrOfFinancialPeriods { get; set; }

		/// <summary>
		/// The day of the week when period starts.Relevant only for the period types based on weeks.
		/// <para>DAC Field Name: EndYearDayOfWeek</para>
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: Periods Start Day of Week</para>
		/// </summary>
		public StringValue? PeriodsStartDayOfWeek { get; set; }

		/// <summary>
		/// The type of financial periods that make up the year.
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: Period Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? PeriodType { get; set; }

		/// <summary>
		/// The read-only field indicating whether the periods of the year can be modified by user.
		/// <para>DAC Field Name: UserDefined</para>
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: User-Defined Periods</para>
		/// </summary>
		public BooleanValue? UserDefinedPeriods { get; set; }

		/// <summary>
		/// The method used to determine the end date of a year with week-long periods.
		/// <para>DAC Field Name: EndYearCalcMethod</para>
		/// <para>DAC: PX.Objects.GL.FinYearSetup</para>
		/// <para>Display Name: Year End Calculation Method</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? YearEndCalculationMethod { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details,Details/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}