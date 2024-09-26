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
	/// Corresponds to the screen FS300100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ServiceOrder : Entity, ITopLevelEntity
	{

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public SrvOrdAddress? Address { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ApptDurationTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AppointmentDuration", EmitDefaultValue=false)]
		public StringValue? AppointmentDuration { get; set; }

		[DataMember(Name="Appointments", EmitDefaultValue=false)]
		public List<SrvOrdAppointments>? Appointments { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AppointmentsNeeded 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AppointmentsNeeded", EmitDefaultValue=false)]
		public BooleanValue? AppointmentsNeeded { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<SrvOrdAttributes>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryEffectiveBillableDocTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillableTotal", EmitDefaultValue=false)]
		public DecimalValue? BillableTotal { get; set; }

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

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public SrvOrdContact? Contact { get; set; }

		[DataMember(Name="ContractInfo", EmitDefaultValue=false)]
		public SrvOrdContractInfo? ContractInfo { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustPORefNbr 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderDate 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DfltProjectTaskID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultProjectTask", EmitDefaultValue=false)]
		public StringValue? DefaultProjectTask { get; set; }

		[DataMember(Name="DefaultStaff", EmitDefaultValue=false)]
		public List<SrvOrdDefaultStaff>? DefaultStaff { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SrvOrdDetails>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EstimatedDurationTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EstimatedDuration", EmitDefaultValue=false)]
		public StringValue? EstimatedDuration { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustWorkOrderRefNbr 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExternalReference", EmitDefaultValue=false)]
		public StringValue? ExternalReference { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public SrvOrdFinancialDetails? FinancialDetails { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

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

		[DataMember(Name="OtherInformation", EmitDefaultValue=false)]
		public SrvOrdOtherInformation? OtherInformation { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		[DataMember(Name="Prepayments", EmitDefaultValue=false)]
		public List<SrvOrdPrepayments>? Prepayments { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Priority 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringValue? Priority { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProblemID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Problem", EmitDefaultValue=false)]
		public StringValue? Problem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryDocTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ServiceOrderTotal", EmitDefaultValue=false)]
		public DecimalValue? ServiceOrderTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SrvOrdType 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Severity 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringValue? Severity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SLAETA_Date 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SLA", EmitDefaultValue=false)]
		public DateTimeValue? SLA { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SLAETA_Time 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SLATime", EmitDefaultValue=false)]
		public DateTimeValue? SLATime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AssignedEmpID 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Supervisor", EmitDefaultValue=false)]
		public StringValue? Supervisor { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<SrvOrdTaxDetails>? TaxDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public SrvOrdTotals? Totals { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WaitingForParts 
		/// DAC: PX.Objects.FS.FSServiceOrder 
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
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkflowStage", EmitDefaultValue=false)]
		public StringValue? WorkflowStage { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}