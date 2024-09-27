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
	/// Corresponds to the screen FS300200 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Appointment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Actual Duration 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="ActualDuration", EmitDefaultValue=false)]
		public StringValue? ActualDuration { get; set; }

		/// <summary>
		/// DAC Field Name: ActualDateTimeEnd_Date 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="ActualEndDate", EmitDefaultValue=false)]
		public DateTimeValue? ActualEndDate { get; set; }

		/// <summary>
		/// DAC Field Name: ActualDateTimeEnd_Time 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="ActualEndTime", EmitDefaultValue=false)]
		public DateTimeValue? ActualEndTime { get; set; }

		/// <summary>
		/// DAC Field Name: HandleManuallyActualTime 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Handle Manually 
		/// </summary>
		[DataMember(Name="ActualHandleManually", EmitDefaultValue=false)]
		public BooleanValue? ActualHandleManually { get; set; }

		/// <summary>
		/// DAC Field Name: ActualDurationTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Actual Duration 
		/// </summary>
		[DataMember(Name="ActualServiceDuration", EmitDefaultValue=false)]
		public StringValue? ActualServiceDuration { get; set; }

		/// <summary>
		/// DAC Field Name: ExecutionDate 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Actual Start Date 
		/// </summary>
		[DataMember(Name="ActualStartDate", EmitDefaultValue=false)]
		public DateTimeValue? ActualStartDate { get; set; }

		/// <summary>
		/// DAC Field Name: ActualDateTimeBegin_Time 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="ActualStartTime", EmitDefaultValue=false)]
		public DateTimeValue? ActualStartTime { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Appointment Nbr. 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDocTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Invoice Total 
		/// </summary>
		[DataMember(Name="AppointmentTotal", EmitDefaultValue=false)]
		public DecimalValue? AppointmentTotal { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AppAttributes>? Attributes { get; set; }

		/// <summary>
		/// DAC Field Name: BranchLocationID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Branch Location 
		/// </summary>
		[DataMember(Name="BranchLocation", EmitDefaultValue=false)]
		public StringValue? BranchLocation { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue? Confirmed { get; set; }

		/// <summary>
		/// DAC Field Name: CuryCostTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Cost Total 
		/// </summary>
		[DataMember(Name="CostTotal", EmitDefaultValue=false)]
		public DecimalValue? CostTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// DAC Field Name: DfltProjectTaskID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Default Project Task 
		/// </summary>
		[DataMember(Name="DefaultProjectTask", EmitDefaultValue=false)]
		public StringValue? DefaultProjectTask { get; set; }

		/// <summary>
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<AppDetails>? Details { get; set; }

		/// <summary>
		/// DAC Field Name: EstimatedDurationTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Estimated Duration 
		/// </summary>
		[DataMember(Name="EstimatedServiceDuration", EmitDefaultValue=false)]
		public StringValue? EstimatedServiceDuration { get; set; }

		[DataMember(Name="FinancialSettings", EmitDefaultValue=false)]
		public AppFinancialSettings? FinancialSettings { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="Finished", EmitDefaultValue=false)]
		public BooleanValue? Finished { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="Logs", EmitDefaultValue=false)]
		public List<AppLogs>? Logs { get; set; }

		/// <summary>
		/// DAC Field Name: ROOptimizationStatus 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Optimization Result 
		/// SQL Type: char(2) 
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
		/// DAC Field Name: ProfitPercent 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Profit Markup (%) 
		/// </summary>
		[DataMember(Name="Profit", EmitDefaultValue=false)]
		public DecimalValue? Profit { get; set; }

		[DataMember(Name="Profitability", EmitDefaultValue=false)]
		public List<AppProfitability>? Profitability { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		[DataMember(Name="ResourceEquipment", EmitDefaultValue=false)]
		public List<AppResourceEquipment>? ResourceEquipment { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Scheduled Duration 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="ScheduledDuration", EmitDefaultValue=false)]
		public StringValue? ScheduledDuration { get; set; }

		/// <summary>
		/// DAC Field Name: ScheduledDateTimeEnd_Date 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="ScheduledEndDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledEndDate { get; set; }

		/// <summary>
		/// DAC Field Name: ScheduledDateTimeEnd_Time 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="ScheduledEndTime", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledEndTime { get; set; }

		/// <summary>
		/// DAC Field Name: HandleManuallyScheduleTime 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Handle Manually 
		/// </summary>
		[DataMember(Name="ScheduledHandleManually", EmitDefaultValue=false)]
		public BooleanValue? ScheduledHandleManually { get; set; }

		/// <summary>
		/// DAC Field Name: ScheduledDateTimeBegin_Date 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="ScheduledStartDate", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledStartDate { get; set; }

		/// <summary>
		/// DAC Field Name: ScheduledDateTimeBegin_Time 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// </summary>
		[DataMember(Name="ScheduledStartTime", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledStartTime { get; set; }

		/// <summary>
		/// DAC Field Name: SORefNbr 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Service Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SrvOrdType 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Service Order Type 
		/// SQL Type: char(4) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		[DataMember(Name="Staff", EmitDefaultValue=false)]
		public List<AppStaff>? Staff { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<AppTaxDetails>? TaxDetails { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Actual Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public AppTotals? Totals { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Unreached Customer 
		/// </summary>
		[DataMember(Name="UnreachedCustomer", EmitDefaultValue=false)]
		public BooleanValue? UnreachedCustomer { get; set; }

		/// <summary>
		/// DAC Field Name: ValidatedByDispatcher 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Validated by Dispatcher 
		/// </summary>
		[DataMember(Name="ValidatedbyDispatcher", EmitDefaultValue=false)]
		public BooleanValue? ValidatedbyDispatcher { get; set; }

		/// <summary>
		/// DAC Field Name: WaitingForParts 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Waiting for Purchased Items 
		/// </summary>
		[DataMember(Name="WaitingforPurchasedItems", EmitDefaultValue=false)]
		public BooleanValue? WaitingforPurchasedItems { get; set; }

		/// <summary>
		/// DAC Field Name: WFStageID 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Workflow Stage 
		/// </summary>
		[DataMember(Name="WorkflowStage", EmitDefaultValue=false)]
		public StringValue? WorkflowStage { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}