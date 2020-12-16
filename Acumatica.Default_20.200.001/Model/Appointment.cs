using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Appointment : Entity_v4
	{

		[DataMember(Name="ActualDuration", EmitDefaultValue=false)]
		public StringValue ActualDuration { get; set; }

		[DataMember(Name="ActualEndDate", EmitDefaultValue=false)]
		public DateTimeValue ActualEndDate { get; set; }

		[DataMember(Name="ActualEndTime", EmitDefaultValue=false)]
		public DateTimeValue ActualEndTime { get; set; }

		[DataMember(Name="ActualHandleManually", EmitDefaultValue=false)]
		public BooleanValue ActualHandleManually { get; set; }

		[DataMember(Name="ActualServiceDuration", EmitDefaultValue=false)]
		public StringValue ActualServiceDuration { get; set; }

		[DataMember(Name="ActualStartDate", EmitDefaultValue=false)]
		public DateTimeValue ActualStartDate { get; set; }

		[DataMember(Name="ActualStartTime", EmitDefaultValue=false)]
		public DateTimeValue ActualStartTime { get; set; }

		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue AppointmentNbr { get; set; }

		[DataMember(Name="AppointmentTotal", EmitDefaultValue=false)]
		public DecimalValue AppointmentTotal { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AppAttributes> Attributes { get; set; }

		[DataMember(Name="BranchLocation", EmitDefaultValue=false)]
		public StringValue BranchLocation { get; set; }

		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue Confirmed { get; set; }

		[DataMember(Name="CostTotal", EmitDefaultValue=false)]
		public DecimalValue CostTotal { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="DefaultProjectTask", EmitDefaultValue=false)]
		public StringValue DefaultProjectTask { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<AppDetails> Details { get; set; }

		[DataMember(Name="EstimatedServiceDuration", EmitDefaultValue=false)]
		public StringValue EstimatedServiceDuration { get; set; }

		[DataMember(Name="FinancialSettings", EmitDefaultValue=false)]
		public AppFinancialSettings FinancialSettings { get; set; }

		[DataMember(Name="Finished", EmitDefaultValue=false)]
		public BooleanValue Finished { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="Logs", EmitDefaultValue=false)]
		public List<AppLogs> Logs { get; set; }

		[DataMember(Name="OptimizationResult", EmitDefaultValue=false)]
		public StringValue OptimizationResult { get; set; }

		[DataMember(Name="OtherInformation", EmitDefaultValue=false)]
		public AppOtherInformation OtherInformation { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue Override { get; set; }

		[DataMember(Name="Prepayments", EmitDefaultValue=false)]
		public List<AppPrepayments> Prepayments { get; set; }

		[DataMember(Name="Profit", EmitDefaultValue=false)]
		public DecimalValue Profit { get; set; }

		[DataMember(Name="Profitability", EmitDefaultValue=false)]
		public List<AppProfitability> Profitability { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ResourceEquipment", EmitDefaultValue=false)]
		public List<AppResourceEquipment> ResourceEquipment { get; set; }

		[DataMember(Name="ScheduledDuration", EmitDefaultValue=false)]
		public StringValue ScheduledDuration { get; set; }

		[DataMember(Name="ScheduledEndDate", EmitDefaultValue=false)]
		public DateTimeValue ScheduledEndDate { get; set; }

		[DataMember(Name="ScheduledEndTime", EmitDefaultValue=false)]
		public DateTimeValue ScheduledEndTime { get; set; }

		[DataMember(Name="ScheduledHandleManually", EmitDefaultValue=false)]
		public BooleanValue ScheduledHandleManually { get; set; }

		[DataMember(Name="ScheduledStartDate", EmitDefaultValue=false)]
		public DateTimeValue ScheduledStartDate { get; set; }

		[DataMember(Name="ScheduledStartTime", EmitDefaultValue=false)]
		public DateTimeValue ScheduledStartTime { get; set; }

		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue ServiceOrderNbr { get; set; }

		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue ServiceOrderType { get; set; }

		[DataMember(Name="Staff", EmitDefaultValue=false)]
		public List<AppStaff> Staff { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<AppTaxDetails> TaxDetails { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue TaxTotal { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public AppTotals Totals { get; set; }

		[DataMember(Name="UnreachedCustomer", EmitDefaultValue=false)]
		public BooleanValue UnreachedCustomer { get; set; }

		[DataMember(Name="ValidatedbyDispatcher", EmitDefaultValue=false)]
		public BooleanValue ValidatedbyDispatcher { get; set; }

		[DataMember(Name="WaitingforPurchasedItems", EmitDefaultValue=false)]
		public BooleanValue WaitingforPurchasedItems { get; set; }

		[DataMember(Name="WorkflowStage", EmitDefaultValue=false)]
		public StringValue WorkflowStage { get; set; }

	}
}