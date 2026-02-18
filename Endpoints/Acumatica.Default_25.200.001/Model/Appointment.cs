using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>FS300200</c> in the Acumatica ERP
	/// <para>Key Fields: AppointmentNbr, ServiceOrderType</para>
	/// </summary>
	public class Appointment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Duration</para>
		/// </summary>
		public StringValue? ActualDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualDateTimeEnd_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public DateTimeValue? ActualEndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualDateTimeEnd_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public DateTimeValue? ActualEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HandleManuallyActualTime</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Handle Manually</para>
		/// </summary>
		public BooleanValue? ActualHandleManually { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualDurationTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Duration</para>
		/// </summary>
		public StringValue? ActualServiceDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExecutionDate</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Start Date</para>
		/// </summary>
		public DateTimeValue? ActualStartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualDateTimeBegin_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public DateTimeValue? ActualStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Appointment Nbr.</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		public DecimalValue? AppointmentTotal { get; set; }

		public List<AppAttributes>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchLocationID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Branch Location</para>
		/// </summary>
		public StringValue? BranchLocation { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryCostTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Cost Total</para>
		/// </summary>
		public DecimalValue? CostTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltProjectTaskID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Default Project Task</para>
		/// </summary>
		public StringValue? DefaultProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<AppDetails>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EstimatedDurationTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Estimated Duration</para>
		/// </summary>
		public StringValue? EstimatedServiceDuration { get; set; }

		public AppFinancialSettings? FinancialSettings { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public BooleanValue? Finished { get; set; }

		public BooleanValue? Hold { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public StringValue? Location { get; set; }

		public List<AppLogs>? Logs { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ROOptimizationStatus</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Optimization Result</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OptimizationResult { get; set; }

		public AppOtherInformation? OtherInformation { get; set; }

		public BooleanValue? Override { get; set; }

		public List<AppPrepayments>? Prepayments { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProfitPercent</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Profit Markup (%)</para>
		/// </summary>
		public DecimalValue? Profit { get; set; }

		public List<AppProfitability>? Profitability { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public StringValue? Project { get; set; }

		public List<AppResourceEquipment>? ResourceEquipment { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Scheduled Duration</para>
		/// </summary>
		public StringValue? ScheduledDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeEnd_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public DateTimeValue? ScheduledEndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeEnd_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public DateTimeValue? ScheduledEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HandleManuallyScheduleTime</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Handle Manually</para>
		/// </summary>
		public BooleanValue? ScheduledHandleManually { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeBegin_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public DateTimeValue? ScheduledStartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeBegin_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		public DateTimeValue? ScheduledStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SORefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Service Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Service Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderType { get; set; }

		public List<AppStaff>? Staff { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public List<AppTaxDetails>? TaxDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Tax Total</para>
		/// </summary>
		public DecimalValue? TaxTotal { get; set; }

		public AppTotals? Totals { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Unreached Customer</para>
		/// </summary>
		public BooleanValue? UnreachedCustomer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ValidatedByDispatcher</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Validated by Dispatcher</para>
		/// </summary>
		public BooleanValue? ValidatedbyDispatcher { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WaitingForParts</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Waiting for Purchased Items</para>
		/// </summary>
		public BooleanValue? WaitingforPurchasedItems { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WFStageID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Workflow Stage</para>
		/// </summary>
		public StringValue? WorkflowStage { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string FinancialSettings = "FinancialSettings";
			public const string Logs = "Logs";
			public const string Logs_Files = "Logs/Files";
			public const string OtherInformation = "OtherInformation";
			public const string Prepayments = "Prepayments";
			public const string Prepayments_Files = "Prepayments/Files";
			public const string Profitability = "Profitability";
			public const string Profitability_Files = "Profitability/Files";
			public const string ResourceEquipment = "ResourceEquipment";
			public const string ResourceEquipment_Files = "ResourceEquipment/Files";
			public const string Staff = "Staff";
			public const string Staff_Files = "Staff/Files";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";
			public const string Totals = "Totals";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,Details,Details/Files,FinancialSettings,Logs,Logs/Files,OtherInformation,Prepayments,Prepayments/Files,Profitability,Profitability/Files,ResourceEquipment,ResourceEquipment/Files,Staff,Staff/Files,TaxDetails,TaxDetails/Files,Totals";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}