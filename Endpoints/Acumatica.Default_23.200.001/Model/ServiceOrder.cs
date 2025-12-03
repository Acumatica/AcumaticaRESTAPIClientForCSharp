using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>FS300100</c> in the Acumatica ERP
	/// <para>Key Fields: ServiceOrderNbr, ServiceOrderType</para>
	/// </summary>
	[DataContract]
	public class ServiceOrder : Entity, ITopLevelEntity
	{

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public SrvOrdAddress? Address { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ApptDurationTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Appointment Duration</para>
		/// </summary>
		[DataMember(Name="AppointmentDuration", EmitDefaultValue=false)]
		public StringValue? AppointmentDuration { get; set; }

		[DataMember(Name="Appointments", EmitDefaultValue=false)]
		public List<SrvOrdAppointments>? Appointments { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Appointments Needed</para>
		/// </summary>
		[DataMember(Name="AppointmentsNeeded", EmitDefaultValue=false)]
		public BooleanValue? AppointmentsNeeded { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<SrvOrdAttributes>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryEffectiveBillableDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		[DataMember(Name="BillableTotal", EmitDefaultValue=false)]
		public DecimalValue? BillableTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchLocationID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Branch Location</para>
		/// </summary>
		[DataMember(Name="BranchLocation", EmitDefaultValue=false)]
		public StringValue? BranchLocation { get; set; }

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public SrvOrdContact? Contact { get; set; }

		[DataMember(Name="ContractInfo", EmitDefaultValue=false)]
		public SrvOrdContractInfo? ContractInfo { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustPORefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Customer Order</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderDate</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltProjectTaskID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Default Project Task</para>
		/// </summary>
		[DataMember(Name="DefaultProjectTask", EmitDefaultValue=false)]
		public StringValue? DefaultProjectTask { get; set; }

		[DataMember(Name="DefaultStaff", EmitDefaultValue=false)]
		public List<SrvOrdDefaultStaff>? DefaultStaff { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<SrvOrdDetails>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EstimatedDurationTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Estimated Duration</para>
		/// </summary>
		[DataMember(Name="EstimatedDuration", EmitDefaultValue=false)]
		public StringValue? EstimatedDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustWorkOrderRefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: External Reference</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		[DataMember(Name="ExternalReference", EmitDefaultValue=false)]
		public StringValue? ExternalReference { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public SrvOrdFinancialDetails? FinancialDetails { get; set; }

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

		[DataMember(Name="OtherInformation", EmitDefaultValue=false)]
		public SrvOrdOtherInformation? OtherInformation { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		[DataMember(Name="Prepayments", EmitDefaultValue=false)]
		public List<SrvOrdPrepayments>? Prepayments { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringValue? Priority { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProblemID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		[DataMember(Name="Problem", EmitDefaultValue=false)]
		public StringValue? Problem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Estimated Total</para>
		/// </summary>
		[DataMember(Name="ServiceOrderTotal", EmitDefaultValue=false)]
		public DecimalValue? ServiceOrderTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringValue? Severity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SLAETA_Date</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		[DataMember(Name="SLA", EmitDefaultValue=false)]
		public DateTimeValue? SLA { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SLAETA_Time</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		[DataMember(Name="SLATime", EmitDefaultValue=false)]
		public DateTimeValue? SLATime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AssignedEmpID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		[DataMember(Name="Supervisor", EmitDefaultValue=false)]
		public StringValue? Supervisor { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<SrvOrdTaxDetails>? TaxDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Estimated Tax Total</para>
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public SrvOrdTotals? Totals { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WaitingForParts</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Waiting for Purchased Items</para>
		/// </summary>
		[DataMember(Name="WaitingforPurchasedItems", EmitDefaultValue=false)]
		public BooleanValue? WaitingforPurchasedItems { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WFStageID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Workflow Stage</para>
		/// </summary>
		[DataMember(Name="WorkflowStage", EmitDefaultValue=false)]
		public StringValue? WorkflowStage { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Address = "Address";
			public const string Appointments = "Appointments";
			public const string Appointments_Files = "Appointments/Files";
			public const string Attributes = "Attributes";
			public const string Contact = "Contact";
			public const string ContractInfo = "ContractInfo";
			public const string DefaultStaff = "DefaultStaff";
			public const string DefaultStaff_Files = "DefaultStaff/Files";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string FinancialDetails = "FinancialDetails";
			public const string OtherInformation = "OtherInformation";
			public const string Prepayments = "Prepayments";
			public const string Prepayments_Files = "Prepayments/Files";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";
			public const string Totals = "Totals";

			//Intentionally excluded
			//public const string All = "Files,Address,Appointments,Appointments/Files,Attributes,Contact,ContractInfo,DefaultStaff,DefaultStaff/Files,Details,Details/Files,FinancialDetails,OtherInformation,Prepayments,Prepayments/Files,TaxDetails,TaxDetails/Files,Totals";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}