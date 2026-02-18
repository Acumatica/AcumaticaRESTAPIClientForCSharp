using System;
using System.Collections.Generic;

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
	public class ServiceOrder : Entity, ITopLevelEntity
	{

		public SrvOrdAddress? Address { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ApptDurationTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Appointment Duration</para>
		/// </summary>
		public StringValue? AppointmentDuration { get; set; }

		public List<SrvOrdAppointments>? Appointments { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Appointments Needed</para>
		/// </summary>
		public BooleanValue? AppointmentsNeeded { get; set; }

		public List<SrvOrdAttributes>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryEffectiveBillableDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Invoice Total</para>
		/// </summary>
		public DecimalValue? BillableTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchLocationID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Branch Location</para>
		/// </summary>
		public StringValue? BranchLocation { get; set; }

		public SrvOrdContact? Contact { get; set; }

		public SrvOrdContractInfo? ContractInfo { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? Currency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustPORefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Customer Order</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderDate</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltProjectTaskID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Default Project Task</para>
		/// </summary>
		public StringValue? DefaultProjectTask { get; set; }

		public List<SrvOrdDefaultStaff>? DefaultStaff { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<SrvOrdDetails>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EstimatedDurationTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Estimated Duration</para>
		/// </summary>
		public StringValue? EstimatedDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustWorkOrderRefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: External Reference</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? ExternalReference { get; set; }

		public SrvOrdFinancialDetails? FinancialDetails { get; set; }

		public BooleanValue? Hold { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public StringValue? Location { get; set; }

		public SrvOrdOtherInformation? OtherInformation { get; set; }

		public BooleanValue? Override { get; set; }

		public List<SrvOrdPrepayments>? Prepayments { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Priority { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProblemID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public StringValue? Problem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDocTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Estimated Total</para>
		/// </summary>
		public DecimalValue? ServiceOrderTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Severity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SLAETA_Date</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public DateTimeValue? SLA { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SLAETA_Time</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public DateTimeValue? SLATime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AssignedEmpID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// </summary>
		public StringValue? Supervisor { get; set; }

		public List<SrvOrdTaxDetails>? TaxDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Estimated Tax Total</para>
		/// </summary>
		public DecimalValue? TaxTotal { get; set; }

		public SrvOrdTotals? Totals { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WaitingForParts</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Waiting for Purchased Items</para>
		/// </summary>
		public BooleanValue? WaitingforPurchasedItems { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WFStageID</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Workflow Stage</para>
		/// </summary>
		public StringValue? WorkflowStage { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
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
			//public const string All = "Files,Translations,Address,Appointments,Appointments/Files,Attributes,Contact,ContractInfo,DefaultStaff,DefaultStaff/Files,Details,Details/Files,FinancialDetails,OtherInformation,Prepayments,Prepayments/Files,TaxDetails,TaxDetails/Files,Totals";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}