using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ServiceOrder : Entity_v4
	{

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public SrvOrdAddress Address { get; set; }

		[DataMember(Name="AppointmentDuration", EmitDefaultValue=false)]
		public StringValue AppointmentDuration { get; set; }

		[DataMember(Name="Appointments", EmitDefaultValue=false)]
		public List<SrvOrdAppointments> Appointments { get; set; }

		[DataMember(Name="AppointmentsNeeded", EmitDefaultValue=false)]
		public BooleanValue AppointmentsNeeded { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<SrvOrdAttributes> Attributes { get; set; }

		[DataMember(Name="BillableTotal", EmitDefaultValue=false)]
		public DecimalValue BillableTotal { get; set; }

		[DataMember(Name="BranchLocation", EmitDefaultValue=false)]
		public StringValue BranchLocation { get; set; }

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public SrvOrdContact Contact { get; set; }

		[DataMember(Name="ContractInfo", EmitDefaultValue=false)]
		public SrvOrdContractInfo ContractInfo { get; set; }

		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue Currency { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue CustomerOrder { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="DefaultProjectTask", EmitDefaultValue=false)]
		public StringValue DefaultProjectTask { get; set; }

		[DataMember(Name="DefaultStaff", EmitDefaultValue=false)]
		public List<SrvOrdDefaultStaff> DefaultStaff { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SrvOrdDetails> Details { get; set; }

		[DataMember(Name="EstimatedDuration", EmitDefaultValue=false)]
		public StringValue EstimatedDuration { get; set; }

		[DataMember(Name="ExternalReference", EmitDefaultValue=false)]
		public StringValue ExternalReference { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public SrvOrdFinancialDetails FinancialDetails { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="OtherInformation", EmitDefaultValue=false)]
		public SrvOrdOtherInformation OtherInformation { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue Override { get; set; }

		[DataMember(Name="Prepayments", EmitDefaultValue=false)]
		public List<SrvOrdPrepayments> Prepayments { get; set; }

		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringValue Priority { get; set; }

		[DataMember(Name="Problem", EmitDefaultValue=false)]
		public StringValue Problem { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue ServiceOrderNbr { get; set; }

		[DataMember(Name="ServiceOrderTotal", EmitDefaultValue=false)]
		public DecimalValue ServiceOrderTotal { get; set; }

		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue ServiceOrderType { get; set; }

		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringValue Severity { get; set; }

		[DataMember(Name="SLA", EmitDefaultValue=false)]
		public DateTimeValue SLA { get; set; }

		[DataMember(Name="SLATime", EmitDefaultValue=false)]
		public DateTimeValue SLATime { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Supervisor", EmitDefaultValue=false)]
		public StringValue Supervisor { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<SrvOrdTaxDetails> TaxDetails { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue TaxTotal { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public SrvOrdTotals Totals { get; set; }

		[DataMember(Name="WaitingforPurchasedItems", EmitDefaultValue=false)]
		public BooleanValue WaitingforPurchasedItems { get; set; }

		[DataMember(Name="WorkflowStage", EmitDefaultValue=false)]
		public StringValue WorkflowStage { get; set; }

	}
}