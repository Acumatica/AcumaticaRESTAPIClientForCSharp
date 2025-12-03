using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class BatchEarningDetail : Entity
	{

		/// <summary>
		/// The unique identifier of the earnings account associated with the selected earning type.The field is included in Account.
		/// <para>DAC Field Name: AccountID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		[DataMember(Name="AllowCopy", EmitDefaultValue=false)]
		public BooleanValue? AllowCopy { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The unique identifier of the company branch.The field is included in Branch.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the specified project is certified.
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>Display Name: Certified Job</para>
		/// </summary>
		[DataMember(Name="CertifiedJob", EmitDefaultValue=false)]
		public BooleanValue? CertifiedJob { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the earning type code.The field is included in EarningType.
		/// <para>DAC Field Name: TypeCD</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="Code", EmitDefaultValue=false)]
		public StringValue? Code { get; set; }

		/// <summary>
		/// The unique identifier of the applied cost code, if any.The field is included in CostCode.
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The date of the transaction.
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TypeCD_EPEarningType_Description</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The unique identifier of the employee.The field is included in Employee.
		/// <para>DAC Field Name: EmployeeID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// </summary>
		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeID_Description</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// </summary>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		/// <summary>
		/// The number of earned hours.
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// </summary>
		[DataMember(Name="Hours", EmitDefaultValue=false)]
		public DecimalValue? Hours { get; set; }

		/// <summary>
		/// The unique identifier of the labor item, if any. The labor item may change the rate applied to the earning type.The field is included in LaborItem.
		/// <para>DAC Field Name: LabourItemID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The unique identifier of the work location.The field is included in Location.
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the rate is specified manually.
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>Display Name: Manual Rate</para>
		/// </summary>
		[DataMember(Name="ManualRate", EmitDefaultValue=false)]
		public BooleanValue? ManualRate { get; set; }

		/// <summary>
		/// The unique identifier of the associated project.The field is included in Project.
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// </summary>
		[DataMember(Name="Rate", EmitDefaultValue=false)]
		public DecimalValue? Rate { get; set; }

		/// <summary>
		/// The unique identifier of an earning detail being imported from an Excel document.
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>Display Name: Record ID</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="ExcelRecordID", EmitDefaultValue=false)]
		public StringValue? ExcelRecordID { get; set; }

		/// <summary>
		/// The unique identifier of the work shift during which the activity was performed.The field is included in ShiftCode.
		/// <para>DAC Field Name: ShiftID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>Display Name: Shift Code</para>
		/// </summary>
		[DataMember(Name="ShiftCode", EmitDefaultValue=false)]
		public StringValue? ShiftCode { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount.The field is included in Subaccount.
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// The unique identifier of the project task.The field is included in ProjectTask.
		/// <para>DAC Field Name: ProjectTaskID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		[DataMember(Name="Task", EmitDefaultValue=false)]
		public StringValue? Task { get; set; }

		/// <summary>
		/// The unique global identifier of the associated time activity, if any.
		/// <para>DAC Field Name: SourceNoteID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>Display Name: Time Activity</para>
		/// </summary>
		[DataMember(Name="TimeActivity", EmitDefaultValue=false)]
		public StringValue? TimeActivity { get; set; }

		/// <summary>
		/// The unique identifier of the union local, if any. The union local may change the rate applied to the earning type.The field is included in Union.
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>Display Name: Union Local</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="UnionLocal", EmitDefaultValue=false)]
		public StringValue? UnionLocal { get; set; }

		/// <summary>
		/// The quantity of units (pieces) worked.
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// </summary>
		[DataMember(Name="Units", EmitDefaultValue=false)]
		public DecimalValue? Units { get; set; }

		/// <summary>
		/// The unit of measure for the time entry.
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>Display Name: Unit Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="UnitType", EmitDefaultValue=false)]
		public StringValue? UnitType { get; set; }

		/// <summary>
		/// The unique identifier of the WCC code applied, if any.The field is included in WorkCode.
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.PR.PREarningDetail</para>
		/// <para>Display Name: WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public StringValue? WCCCode { get; set; }

	}
}