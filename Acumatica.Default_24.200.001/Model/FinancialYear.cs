using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
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
		/// 
		/// Display Name:
		/// DAC Field Name: BelongsToNextYear 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BelongsToNextYear", EmitDefaultValue=false)]
		public BooleanValue? BelongsToNextYear { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: YearLastDayOfWeek 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
		public StringValue? DayOfWeek { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<FinancialYearPeriodDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BegFinYear 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FinancialYearStartsOn", EmitDefaultValue=false)]
		public DateTimeValue? FinancialYearStartsOn { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FirstFinYear 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FirstFinancialYear", EmitDefaultValue=false)]
		public StringValue? FirstFinancialYear { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PeriodsStartDate 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FirstPeriodStartDate", EmitDefaultValue=false)]
		public DateTimeValue? FirstPeriodStartDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: HasAdjustmentPeriod 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="HasAdjustmentPeriod", EmitDefaultValue=false)]
		public BooleanValue? HasAdjustmentPeriod { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PeriodLength 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LengthOfFinancialPeriodInDays", EmitDefaultValue=false)]
		public ShortValue? LengthOfFinancialPeriodInDays { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinPeriods 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NbrOfFinancialPeriods", EmitDefaultValue=false)]
		public ShortValue? NbrOfFinancialPeriods { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EndYearDayOfWeek 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PeriodsStartDayOfWeek", EmitDefaultValue=false)]
		public StringValue? PeriodsStartDayOfWeek { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PeriodType 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PeriodType", EmitDefaultValue=false)]
		public StringValue? PeriodType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UserDefined 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UserDefinedPeriods", EmitDefaultValue=false)]
		public BooleanValue? UserDefinedPeriods { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EndYearCalcMethod 
		/// DAC: PX.Objects.GL.FinYearSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="YearEndCalculationMethod", EmitDefaultValue=false)]
		public StringValue? YearEndCalculationMethod { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}