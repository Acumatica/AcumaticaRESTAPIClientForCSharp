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
	/// Corresponds to the screen FS300200 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Appointment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActualDuration 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActualDuration", EmitDefaultValue=false)]
		public StringValue? ActualDuration { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActualDateTimeEnd_Date 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActualEndDate", EmitDefaultValue=false)]
		public DateTimeValue? ActualEndDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActualDateTimeEnd_Time 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActualEndTime", EmitDefaultValue=false)]
		public DateTimeValue? ActualEndTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: HandleManuallyActualTime 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActualHandleManually", EmitDefaultValue=false)]
		public BooleanValue? ActualHandleManually { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActualDurationTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActualServiceDuration", EmitDefaultValue=false)]
		public StringValue? ActualServiceDuration { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExecutionDate 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActualStartDate", EmitDefaultValue=false)]
		public DateTimeValue? ActualStartDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ActualDateTimeBegin_Time 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ActualStartTime", EmitDefaultValue=false)]
		public DateTimeValue? ActualStartTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryDocTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AppointmentTotal", EmitDefaultValue=false)]
		public DecimalValue? AppointmentTotal { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AppAttributes>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchLocationID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BranchLocation", EmitDefaultValue=false)]
		public StringValue? BranchLocation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Confirmed 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryCostTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostTotal", EmitDefaultValue=false)]
		public DecimalValue? CostTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DfltProjectTaskID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultProjectTask", EmitDefaultValue=false)]
		public StringValue? DefaultProjectTask { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<AppDetails>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EstimatedDurationTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EstimatedServiceDuration", EmitDefaultValue=false)]
		public StringValue? EstimatedServiceDuration { get; set; }

		[DataMember(Name="FinancialSettings", EmitDefaultValue=false)]
		public AppFinancialSettings? FinancialSettings { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Finished 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Finished", EmitDefaultValue=false)]
		public BooleanValue? Finished { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="Logs", EmitDefaultValue=false)]
		public List<AppLogs>? Logs { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ROOptimizationStatus 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OptimizationResult", EmitDefaultValue=false)]
		public StringValue? OptimizationResult { get; set; }

		[DataMember(Name="OtherInformation", EmitDefaultValue=false)]
		public AppOtherInformation? OtherInformation { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		[DataMember(Name="Prepayments", EmitDefaultValue=false)]
		public List<AppPrepayments>? Prepayments { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProfitPercent 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Profit", EmitDefaultValue=false)]
		public DecimalValue? Profit { get; set; }

		[DataMember(Name="Profitability", EmitDefaultValue=false)]
		public List<AppProfitability>? Profitability { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="ResourceEquipment", EmitDefaultValue=false)]
		public List<AppResourceEquipment>? ResourceEquipment { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScheduledDuration 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScheduledDuration", EmitDefaultValue=false)]
		public StringValue? ScheduledDuration { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScheduledDateTimeEnd_Date 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScheduledEndDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledEndDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScheduledDateTimeEnd_Time 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScheduledEndTime", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledEndTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: HandleManuallyScheduleTime 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScheduledHandleManually", EmitDefaultValue=false)]
		public BooleanValue? ScheduledHandleManually { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScheduledDateTimeBegin_Date 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScheduledStartDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledStartDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScheduledDateTimeBegin_Time 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScheduledStartTime", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledStartTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SORefNbr 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SrvOrdType 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		[DataMember(Name="Staff", EmitDefaultValue=false)]
		public List<AppStaff>? Staff { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<AppTaxDetails>? TaxDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public AppTotals? Totals { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnreachedCustomer 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnreachedCustomer", EmitDefaultValue=false)]
		public BooleanValue? UnreachedCustomer { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ValidatedByDispatcher 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ValidatedbyDispatcher", EmitDefaultValue=false)]
		public BooleanValue? ValidatedbyDispatcher { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WaitingForParts 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WaitingforPurchasedItems", EmitDefaultValue=false)]
		public BooleanValue? WaitingforPurchasedItems { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WFStageID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkflowStage", EmitDefaultValue=false)]
		public StringValue? WorkflowStage { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}