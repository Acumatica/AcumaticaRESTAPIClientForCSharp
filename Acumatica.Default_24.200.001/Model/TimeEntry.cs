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
	/// Corresponds to the screen PM209100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TimeEntry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Approval Status 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="ApprovalStatus", EmitDefaultValue=false)]
		public StringValue? ApprovalStatus { get; set; }

		/// <summary>
		/// DAC Field Name: ApproverID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue? Approver { get; set; }

		/// <summary>
		/// DAC Field Name: IsBillable 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// DAC Field Name: OvertimeBillable 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Billable Overtime 
		/// </summary>
		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public StringValue? BillableOvertime { get; set; }

		/// <summary>
		/// DAC Field Name: TimeBillable 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Billable Time 
		/// </summary>
		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue? BillableTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Certified Job 
		/// </summary>
		[DataMember(Name="CertifiedJob", EmitDefaultValue=false)]
		public BooleanValue? CertifiedJob { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// Stores Employee's Hourly rate at the time the activity was released to PM
		/// DAC Field Name: EmployeeRate 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Cost Rate 
		/// </summary>
		[DataMember(Name="CostRate", EmitDefaultValue=false)]
		public DecimalValue? CostRate { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// DAC Field Name: EarningTypeID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Earning Type 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Owner 
		/// </summary>
		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// DAC Field Name: LabourItemID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Labor Item 
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: OvertimeSpent 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		[DataMember(Name="Overtime", EmitDefaultValue=false)]
		public StringValue? Overtime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Project 
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		[DataMember(Name="Time", EmitDefaultValue=false)]
		public DateTimeValue? Time { get; set; }

		/// <summary>
		/// The global identifier of the record. This identifier is used for implementation of multiple system features, such as the search functionality and attachments of notes and files.
		/// DAC Field Name: NoteID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Key Field
		/// </summary>
		[DataMember(Name="TimeEntryID", EmitDefaultValue=false)]
		public GuidValue? TimeEntryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Time Spent 
		/// </summary>
		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue? TimeSpent { get; set; }

		/// <summary>
		/// DAC Field Name: UnionID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: Union Local 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="UnionLocal", EmitDefaultValue=false)]
		public StringValue? UnionLocal { get; set; }

		/// <summary>
		/// DAC Field Name: WorkCodeID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// Display Name: WCC Code 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public StringValue? WCCCode { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}