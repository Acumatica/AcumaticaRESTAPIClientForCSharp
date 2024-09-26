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
	/// Corresponds to the screen PM209100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TimeEntry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ApprovalStatus 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ApprovalStatus", EmitDefaultValue=false)]
		public StringValue? ApprovalStatus { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ApproverID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue? Approver { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsBillable 
		/// DAC: PX.Objects.CR.PMTimeActivity 
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
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public StringValue? BillableOvertime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TimeBillable 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue? BillableTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CertifiedJob 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CertifiedJob", EmitDefaultValue=false)]
		public BooleanValue? CertifiedJob { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EmployeeRate 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostRate", EmitDefaultValue=false)]
		public DecimalValue? CostRate { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EarningTypeID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LabourItemID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OvertimeSpent 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Overtime", EmitDefaultValue=false)]
		public StringValue? Overtime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectTaskID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Summary 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		[DataMember(Name="Time", EmitDefaultValue=false)]
		public DateTimeValue? Time { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NoteID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TimeEntryID", EmitDefaultValue=false)]
		public GuidValue? TimeEntryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TimeSpent 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue? TimeSpent { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnionID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UnionLocal", EmitDefaultValue=false)]
		public StringValue? UnionLocal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkCodeID 
		/// DAC: PX.Objects.CR.PMTimeActivity 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public StringValue? WCCCode { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}