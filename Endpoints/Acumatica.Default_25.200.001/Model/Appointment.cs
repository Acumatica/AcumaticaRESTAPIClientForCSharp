using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
	[DataContract]
	public class Appointment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Duration</para>
		/// </summary>
		[DataMember(Name="ActualDuration", EmitDefaultValue=false)]
		public StringValue? ActualDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualDateTimeEnd_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="ActualEndDate", EmitDefaultValue=false)]
		public DateTimeValue? ActualEndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualDateTimeEnd_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="ActualEndTime", EmitDefaultValue=false)]
		public DateTimeValue? ActualEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HandleManuallyActualTime</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Handle Manually</para>
		/// </summary>
		[DataMember(Name="ActualHandleManually", EmitDefaultValue=false)]
		public BooleanValue? ActualHandleManually { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualDurationTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Duration</para>
		/// </summary>
		[DataMember(Name="ActualServiceDuration", EmitDefaultValue=false)]
		public StringValue? ActualServiceDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExecutionDate</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Start Date</para>
		/// </summary>
		[DataMember(Name="ActualStartDate", EmitDefaultValue=false)]
		public DateTimeValue? ActualStartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualDateTimeBegin_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="ActualStartTime", EmitDefaultValue=false)]
		public DateTimeValue? ActualStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Appointment Nbr.</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		[DataMember(Name="AppointmentTotal", EmitDefaultValue=false)]
		public DecimalValue? AppointmentTotal { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AppAttributes>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchLocationID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Branch Location</para>
		/// </summary>
		[DataMember(Name="BranchLocation", EmitDefaultValue=false)]
		public StringValue? BranchLocation { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryCostTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Cost Total</para>
		/// </summary>
		[DataMember(Name="CostTotal", EmitDefaultValue=false)]
		public DecimalValue? CostTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltProjectTaskID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Default Project Task</para>
		/// </summary>
		[DataMember(Name="DefaultProjectTask", EmitDefaultValue=false)]
		public StringValue? DefaultProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<AppDetails>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EstimatedDurationTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Estimated Duration</para>
		/// </summary>
		[DataMember(Name="EstimatedServiceDuration", EmitDefaultValue=false)]
		public StringValue? EstimatedServiceDuration { get; set; }

		[DataMember(Name="FinancialSettings", EmitDefaultValue=false)]
		public AppFinancialSettings? FinancialSettings { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="Finished", EmitDefaultValue=false)]
		public BooleanValue? Finished { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="Logs", EmitDefaultValue=false)]
		public List<AppLogs>? Logs { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ROOptimizationStatus</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Optimization Result</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="OptimizationResult", EmitDefaultValue=false)]
		public StringValue? OptimizationResult { get; set; }

		[DataMember(Name="OtherInformation", EmitDefaultValue=false)]
		public AppOtherInformation? OtherInformation { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		[DataMember(Name="Prepayments", EmitDefaultValue=false)]
		public List<AppPrepayments>? Prepayments { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProfitPercent</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Profit Markup (%)</para>
		/// </summary>
		[DataMember(Name="Profit", EmitDefaultValue=false)]
		public DecimalValue? Profit { get; set; }

		[DataMember(Name="Profitability", EmitDefaultValue=false)]
		public List<AppProfitability>? Profitability { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="ResourceEquipment", EmitDefaultValue=false)]
		public List<AppResourceEquipment>? ResourceEquipment { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Scheduled Duration</para>
		/// </summary>
		[DataMember(Name="ScheduledDuration", EmitDefaultValue=false)]
		public StringValue? ScheduledDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeEnd_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="ScheduledEndDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledEndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeEnd_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="ScheduledEndTime", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledEndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HandleManuallyScheduleTime</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Handle Manually</para>
		/// </summary>
		[DataMember(Name="ScheduledHandleManually", EmitDefaultValue=false)]
		public BooleanValue? ScheduledHandleManually { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeBegin_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="ScheduledStartDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledStartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScheduledDateTimeBegin_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// </summary>
		[DataMember(Name="ScheduledStartTime", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledStartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SORefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Service Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Service Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		[DataMember(Name="Staff", EmitDefaultValue=false)]
		public List<AppStaff>? Staff { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<AppTaxDetails>? TaxDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Actual Tax Total</para>
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public AppTotals? Totals { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Unreached Customer</para>
		/// </summary>
		[DataMember(Name="UnreachedCustomer", EmitDefaultValue=false)]
		public BooleanValue? UnreachedCustomer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ValidatedByDispatcher</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Validated by Dispatcher</para>
		/// </summary>
		[DataMember(Name="ValidatedbyDispatcher", EmitDefaultValue=false)]
		public BooleanValue? ValidatedbyDispatcher { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WaitingForParts</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Waiting for Purchased Items</para>
		/// </summary>
		[DataMember(Name="WaitingforPurchasedItems", EmitDefaultValue=false)]
		public BooleanValue? WaitingforPurchasedItems { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WFStageID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Workflow Stage</para>
		/// </summary>
		[DataMember(Name="WorkflowStage", EmitDefaultValue=false)]
		public StringValue? WorkflowStage { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
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
			//public const string All = "Files,Attributes,Details,Details/Files,FinancialSettings,Logs,Logs/Files,OtherInformation,Prepayments,Prepayments/Files,Profitability,Profitability/Files,ResourceEquipment,ResourceEquipment/Files,Staff,Staff/Files,TaxDetails,TaxDetails/Files,Totals";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}