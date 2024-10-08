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
	/// Corresponds to the screen FS300100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ServiceOrder : Entity, ITopLevelEntity
	{

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public SrvOrdAddress? Address { get; set; }

		/// <summary>
		/// DAC Field Name: ApptDurationTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Appointment Duration 
		/// </summary>
		[DataMember(Name="AppointmentDuration", EmitDefaultValue=false)]
		public StringValue? AppointmentDuration { get; set; }

		[DataMember(Name="Appointments", EmitDefaultValue=false)]
		public List<SrvOrdAppointments>? Appointments { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Appointments Needed 
		/// </summary>
		[DataMember(Name="AppointmentsNeeded", EmitDefaultValue=false)]
		public BooleanValue? AppointmentsNeeded { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<SrvOrdAttributes>? Attributes { get; set; }

		/// <summary>
		/// DAC Field Name: CuryEffectiveBillableDocTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Invoice Total 
		/// </summary>
		[DataMember(Name="BillableTotal", EmitDefaultValue=false)]
		public DecimalValue? BillableTotal { get; set; }

		/// <summary>
		/// DAC Field Name: BranchLocationID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Branch Location 
		/// </summary>
		[DataMember(Name="BranchLocation", EmitDefaultValue=false)]
		public StringValue? BranchLocation { get; set; }

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public SrvOrdContact? Contact { get; set; }

		[DataMember(Name="ContractInfo", EmitDefaultValue=false)]
		public SrvOrdContractInfo? ContractInfo { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// DAC Field Name: CustPORefNbr 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Customer Order 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// DAC Field Name: OrderDate 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// DAC Field Name: DfltProjectTaskID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Default Project Task 
		/// </summary>
		[DataMember(Name="DefaultProjectTask", EmitDefaultValue=false)]
		public StringValue? DefaultProjectTask { get; set; }

		[DataMember(Name="DefaultStaff", EmitDefaultValue=false)]
		public List<SrvOrdDefaultStaff>? DefaultStaff { get; set; }

		/// <summary>
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SrvOrdDetails>? Details { get; set; }

		/// <summary>
		/// DAC Field Name: EstimatedDurationTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Estimated Duration 
		/// </summary>
		[DataMember(Name="EstimatedDuration", EmitDefaultValue=false)]
		public StringValue? EstimatedDuration { get; set; }

		/// <summary>
		/// DAC Field Name: CustWorkOrderRefNbr 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: External Reference 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="ExternalReference", EmitDefaultValue=false)]
		public StringValue? ExternalReference { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public SrvOrdFinancialDetails? FinancialDetails { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="OtherInformation", EmitDefaultValue=false)]
		public SrvOrdOtherInformation? OtherInformation { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		[DataMember(Name="Prepayments", EmitDefaultValue=false)]
		public List<SrvOrdPrepayments>? Prepayments { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringValue? Priority { get; set; }

		/// <summary>
		/// DAC Field Name: ProblemID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="Problem", EmitDefaultValue=false)]
		public StringValue? Problem { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDocTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Estimated Total 
		/// </summary>
		[DataMember(Name="ServiceOrderTotal", EmitDefaultValue=false)]
		public DecimalValue? ServiceOrderTotal { get; set; }

		/// <summary>
		/// DAC Field Name: SrvOrdType 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Order Type 
		/// SQL Type: char(4) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringValue? Severity { get; set; }

		/// <summary>
		/// DAC Field Name: SLAETA_Date 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="SLA", EmitDefaultValue=false)]
		public DateTimeValue? SLA { get; set; }

		/// <summary>
		/// DAC Field Name: SLAETA_Time 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="SLATime", EmitDefaultValue=false)]
		public DateTimeValue? SLATime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: AssignedEmpID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		[DataMember(Name="Supervisor", EmitDefaultValue=false)]
		public StringValue? Supervisor { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<SrvOrdTaxDetails>? TaxDetails { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Estimated Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public SrvOrdTotals? Totals { get; set; }

		/// <summary>
		/// DAC Field Name: WaitingForParts 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Waiting for Purchased Items 
		/// </summary>
		[DataMember(Name="WaitingforPurchasedItems", EmitDefaultValue=false)]
		public BooleanValue? WaitingforPurchasedItems { get; set; }

		/// <summary>
		/// DAC Field Name: WFStageID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Workflow Stage 
		/// </summary>
		[DataMember(Name="WorkflowStage", EmitDefaultValue=false)]
		public StringValue? WorkflowStage { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}