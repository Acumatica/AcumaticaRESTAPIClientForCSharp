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
	/// Corresponds to the screen CR306000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Case : Entity, ITopLevelEntity
	{

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail>? Activities { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsBillable 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OvertimeBillable 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public IntValue? BillableOvertime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TimeBillable 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public IntValue? BillableTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue? BusinessAccountName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CaseCD 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CaseClassID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ResolutionDate 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ClosingDate", EmitDefaultValue=false)]
		public DateTimeValue? ClosingDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ContactID_description 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
		public StringValue? ContactDisplayName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ContactID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ContractID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Contract", EmitDefaultValue=false)]
		public StringValue? Contract { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReportedOnDateTime 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DateReported", EmitDefaultValue=false)]
		public DateTimeValue? DateReported { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InitResponse 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InitialResponse", EmitDefaultValue=false)]
		public StringValue? InitialResponse { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastActivity 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastActivityDate", EmitDefaultValue=false)]
		public DateTimeValue? LastActivityDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastIncomingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastOutgoingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastOutgoingActivity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ManualBillableTimes 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ManualOverride", EmitDefaultValue=false)]
		public BooleanValue? ManualOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OvertimeSpent 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OvertimeSpent", EmitDefaultValue=false)]
		public StringValue? OvertimeSpent { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID_description 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Priority 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringValue? Priority { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Resolution 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }

		[DataMember(Name="RelatedCases", EmitDefaultValue=false)]
		public List<CaseRelatedCase>? RelatedCases { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TimeResolution 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ResolutionTime", EmitDefaultValue=false)]
		public StringValue? ResolutionTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Severity 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringValue? Severity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ResolutionDueDateTime 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SLA", EmitDefaultValue=false)]
		public DateTimeValue? SLA { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Subject 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TimeSpent 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue? TimeSpent { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkgroupID_description 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}