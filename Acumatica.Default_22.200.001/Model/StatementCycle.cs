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
	/// Corresponds to the screen AR202800 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class StatementCycle : Entity, ITopLevelEntity
	{

		/// <summary>
		/// An integer value indicating the upper inclusive bound, in days, of the first aging period. For example, if AgeDays00 is equal to 7, then the first aging period will correspond to documents that are 1-7 days past due.
		/// DAC Field Name: AgeDays00 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Age Days 1 
		/// </summary>
		[DataMember(Name="AgingPeriod1EndDay", EmitDefaultValue=false)]
		public ShortValue? AgingPeriod1EndDay { get; set; }

		/// <summary>
		/// The description of the first aging period, which incorporates documentsthat are from 1 to AgeDays00 days past due.
		/// DAC Field Name: AgeMsg00 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Age Message 1 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="AgingPeriod1Message", EmitDefaultValue=false)]
		public StringValue? AgingPeriod1Message { get; set; }

		/// <summary>
		/// An integer value indicating the upper inclusive bound, in days, of the secondaging period. For example, if AgeDays00 is equal to 7, and AgeDays01 is equal to 14, then the second aging period willcorrespond to documents that are 8-14 days past due.
		/// DAC Field Name: AgeDays01 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Age Days 2 
		/// </summary>
		[DataMember(Name="AgingPeriod2EndDay", EmitDefaultValue=false)]
		public ShortValue? AgingPeriod2EndDay { get; set; }

		/// <summary>
		/// The description of the second aging period, which incorporates documentsthat are from AgeDays00 + 1 to AgeDays01 days past due.
		/// DAC Field Name: AgeMsg01 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Age Message 2 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="AgingPeriod2Message", EmitDefaultValue=false)]
		public StringValue? AgingPeriod2Message { get; set; }

		/// <summary>
		/// An integer value indicating the upper inclusive bound, in days, of the thirdnon-current aging period. For example, if AgeDays01 is equal to 14,and AgeDays02 is equal to 21, then the third aging period willcorrespond to documents that are 15-21 days past due.
		/// DAC Field Name: AgeDays02 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Age Days 3 
		/// </summary>
		[DataMember(Name="AgingPeriod3EndDay", EmitDefaultValue=false)]
		public ShortValue? AgingPeriod3EndDay { get; set; }

		/// <summary>
		/// The description of the third aging period that incorporates documentsthat are from AgeDays01 + 1 to AgeDays02days past due.
		/// DAC Field Name: AgeMsg02 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Age Message 3 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="AgingPeriod3Message", EmitDefaultValue=false)]
		public StringValue? AgingPeriod3Message { get; set; }

		/// <summary>
		/// The description of the last aging period that incorporates documentsthat are over AgeDays02 days past due.
		/// DAC Field Name: AgeMsg03 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Age Message 4 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="AgingPeriod4Message", EmitDefaultValue=false)]
		public StringValue? AgingPeriod4Message { get; set; }

		/// <summary>
		/// A boolean value indicating whether financial charges should be appliedto customers belonging to the current statement cycle.
		/// DAC Field Name: FinChargeApply 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Apply Overdue Charges 
		/// </summary>
		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue? ApplyOverdueCharges { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// Key field. A human-readable unique string identifier of the statement cycle.
		/// DAC Field Name: StatementCycleId 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Cycle ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="CycleID", EmitDefaultValue=false)]
		public StringValue? CycleID { get; set; }

		/// <summary>
		/// For TwiceAMonth andFixedDayOfMonth schedule types,indicates the first (or the only, correspondingly) day of month, onwhich customer statements are generated.
		/// DAC Field Name: Day00 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Day of Month 1 
		/// </summary>
		[DataMember(Name="DayOfMonth", EmitDefaultValue=false)]
		public ShortValue? DayOfMonth { get; set; }

		/// <summary>
		/// For TwiceAMonth schedule type,indicates the second day of month, on which bi-monthly customer statements are generated.
		/// DAC Field Name: Day01 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Day of Month 2 
		/// </summary>
		[DataMember(Name="DayOfMonth1", EmitDefaultValue=false)]
		public ShortValue? DayOfMonth1 { get; set; }

		/// <summary>
		/// The statement cycle description.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name:  Description 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Indicates the date on which customer statements were last generated forthe current statement cycle.
		/// DAC Field Name: LastStmtDate 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Last Statement Date 
		/// </summary>
		[DataMember(Name="LastStatementDate", EmitDefaultValue=false)]
		public DateTimeValue? LastStatementDate { get; set; }

		/// <summary>
		/// The reference to the overdue charge that should be calculated for customers belonging to the current statement cycle.
		/// DAC Field Name: FinChargeID 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Overdue Charge ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="OverdueChargeID", EmitDefaultValue=false)]
		public StringValue? OverdueChargeID { get; set; }

		/// <summary>
		/// Indicates the type of schedule, according to which customer statementsare generated within the current statement cycle. See ARStatementScheduleType.
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Schedule Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="PrepareOn", EmitDefaultValue=false)]
		public StringValue? PrepareOn { get; set; }

		/// <summary>
		/// A boolean value indicating whether the system should requirethe overdue charges calculation before generating customer statements.
		/// DAC Field Name: RequireFinChargeProcessing 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Require Overdue Charges Calculation Before Statement 
		/// </summary>
		[DataMember(Name="RequireOverdueChargesCalculationBeforeStatement", EmitDefaultValue=false)]
		public BooleanValue? RequireOverdueChargesCalculationBeforeStatement { get; set; }

		/// <summary>
		/// A boolean value indicating whether the system should requireall open customer payments to be applied in full before generatingcustomer statements.
		/// DAC Field Name: RequirePaymentApplication 
		/// DAC: PX.Objects.AR.ARStatementCycle 
		/// Display Name: Require Payment Application Before Statement 
		/// </summary>
		[DataMember(Name="RequirePaymentApplicationBeforeStatementProcessing", EmitDefaultValue=false)]
		public BooleanValue? RequirePaymentApplicationBeforeStatementProcessing { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}