using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class BatchEarningDetail : Entity
	{

		/// <summary>
		/// The unique identifier of the earnings account associated with the selected earning type.The field is included in Account.
		/// DAC Field Name: AccountID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		[DataMember(Name="AllowCopy", EmitDefaultValue=false)]
		public BooleanValue? AllowCopy { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRBatchEmployee 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The unique identifier of the company branch.The field is included in Branch.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the specified project is certified.
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// Display Name: Certified Job 
		/// </summary>
		[DataMember(Name="CertifiedJob", EmitDefaultValue=false)]
		public BooleanValue? CertifiedJob { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the earning type code.The field is included in EarningType.
		/// DAC Field Name: TypeCD 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="Code", EmitDefaultValue=false)]
		public StringValue? Code { get; set; }

		/// <summary>
		/// The unique identifier of the applied cost code, if any.The field is included in CostCode.
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The date of the transaction.
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// DAC Field Name: TypeCD_EPEarningType_Description 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The unique identifier of the employee.The field is included in Employee.
		/// DAC Field Name: EmployeeID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// </summary>
		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		/// <summary>
		/// DAC Field Name: EmployeeID_Description 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// </summary>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		/// <summary>
		/// The number of earned hours.
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// </summary>
		[DataMember(Name="Hours", EmitDefaultValue=false)]
		public DecimalValue? Hours { get; set; }

		/// <summary>
		/// The unique identifier of the labor item, if any. The labor item may change the rate applied to the earning type.The field is included in LaborItem.
		/// DAC Field Name: LabourItemID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// Display Name: Labor Item 
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The unique identifier of the work location.The field is included in Location.
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the rate is specified manually.
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// Display Name: Manual Rate 
		/// </summary>
		[DataMember(Name="ManualRate", EmitDefaultValue=false)]
		public BooleanValue? ManualRate { get; set; }

		/// <summary>
		/// The unique identifier of the associated project.The field is included in Project.
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRBatchEmployee 
		/// </summary>
		[DataMember(Name="Rate", EmitDefaultValue=false)]
		public DecimalValue? Rate { get; set; }

		/// <summary>
		/// The unique identifier of an earning detail being imported from an Excel document.
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// Display Name: Record ID 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="ExcelRecordID", EmitDefaultValue=false)]
		public StringValue? ExcelRecordID { get; set; }

		/// <summary>
		/// The unique identifier of the work shift during which the activity was performed.The field is included in ShiftCode.
		/// DAC Field Name: ShiftID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// Display Name: Shift Code 
		/// </summary>
		[DataMember(Name="ShiftCode", EmitDefaultValue=false)]
		public StringValue? ShiftCode { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount.The field is included in Subaccount.
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// The unique identifier of the project task.The field is included in ProjectTask.
		/// DAC Field Name: ProjectTaskID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="Task", EmitDefaultValue=false)]
		public StringValue? Task { get; set; }

		/// <summary>
		/// The unique global identifier of the associated time activity, if any.
		/// DAC Field Name: SourceNoteID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// Display Name: Time Activity 
		/// </summary>
		[DataMember(Name="TimeActivity", EmitDefaultValue=false)]
		public StringValue? TimeActivity { get; set; }

		/// <summary>
		/// The unique identifier of the union local, if any. The union local may change the rate applied to the earning type.The field is included in Union.
		/// DAC Field Name: UnionID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// Display Name: Union Local 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="UnionLocal", EmitDefaultValue=false)]
		public StringValue? UnionLocal { get; set; }

		/// <summary>
		/// The quantity of units (pieces) worked.
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// </summary>
		[DataMember(Name="Units", EmitDefaultValue=false)]
		public DecimalValue? Units { get; set; }

		/// <summary>
		/// The unit of measure for the time entry.
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// Display Name: Unit Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="UnitType", EmitDefaultValue=false)]
		public StringValue? UnitType { get; set; }

		/// <summary>
		/// The unique identifier of the WCC code applied, if any.The field is included in WorkCode.
		/// DAC Field Name: WorkCodeID 
		/// DAC: PX.Objects.PR.PREarningDetail 
		/// Display Name: WCC Code 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public StringValue? WCCCode { get; set; }

	}
}