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
	public class EmployeePayrollClassDefaults : Entity
	{

		/// <summary>
		/// DAC Field Name: HoursPerYearForCertified 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Certified Project Hours per Year 
		/// </summary>
		[DataMember(Name="CertifiedProjectHoursperYear", EmitDefaultValue=false)]
		public IntValue? CertifiedProjectHoursperYear { get; set; }

		/// <summary>
		/// DAC Field Name: CalendarID 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Default Calendar 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DefaultCalendar", EmitDefaultValue=false)]
		public StringValue? DefaultCalendar { get; set; }

		/// <summary>
		/// DAC Field Name: UnionID 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Default Union 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="DefaultUnion", EmitDefaultValue=false)]
		public StringValue? DefaultUnion { get; set; }

		/// <summary>
		/// DAC Field Name: WorkCodeID 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Default WCC Code 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="DefaultWCCCode", EmitDefaultValue=false)]
		public StringValue? DefaultWCCCode { get; set; }

		/// <summary>
		/// DAC Field Name: EmpType 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Employee Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="EmployeeType", EmitDefaultValue=false)]
		public StringValue? EmployeeType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Exempt from Certified Reporting 
		/// </summary>
		[DataMember(Name="ExemptFromCertifiedReporting", EmitDefaultValue=false)]
		public BooleanValue? ExemptFromCertifiedReporting { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Exempt from Overtime Rules 
		/// </summary>
		[DataMember(Name="ExemptFromOvertimeRules", EmitDefaultValue=false)]
		public BooleanValue? ExemptFromOvertimeRules { get; set; }

		/// <summary>
		/// DAC Field Name: EmpType 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Employee Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="HoursPerYearForCertified", EmitDefaultValue=false)]
		public StringValue? HoursPerYearForCertified { get; set; }

		/// <summary>
		/// DAC Field Name: GrnMaxPctNet 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Maximum Percent of Net Pay for All Garnishments 
		/// </summary>
		[DataMember(Name="MaximumPercentofNetPayforallGarnishments", EmitDefaultValue=false)]
		public DecimalValue? MaximumPercentofNetPayforallGarnishments { get; set; }

		/// <summary>
		/// DAC Field Name: NetPayMin 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Net Pay Minimum 
		/// </summary>
		[DataMember(Name="NetPayMinimum", EmitDefaultValue=false)]
		public DecimalValue? NetPayMinimum { get; set; }

		/// <summary>
		/// DAC Field Name: OverrideHoursPerYearForCertified 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Override Hours per Year for Certified Project 
		/// </summary>
		[DataMember(Name="OverrideHoursPerYearforCertProject", EmitDefaultValue=false)]
		public BooleanValue? OverrideHoursPerYearforCertProject { get; set; }

		/// <summary>
		/// DAC Field Name: PayGroupID 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Pay Group 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		/// <summary>
		/// DAC Field Name: UsePayrollProjectWorkLocation 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Use Payroll Work Location from Project 
		/// </summary>
		[DataMember(Name="UsePayrollWorkLocationfromProject", EmitDefaultValue=false)]
		public BooleanValue? UsePayrollWorkLocationfromProject { get; set; }

		/// <summary>
		/// DAC Field Name: HoursPerWeek 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Working Hours per Week 
		/// </summary>
		[DataMember(Name="WorkingHoursPerWeek", EmitDefaultValue=false)]
		public DecimalValue? WorkingHoursPerWeek { get; set; }

		/// <summary>
		/// DAC Field Name: HoursPerYear 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Working Hours per Year 
		/// </summary>
		[DataMember(Name="WorkingHoursPerYear", EmitDefaultValue=false)]
		public DecimalValue? WorkingHoursPerYear { get; set; }

		/// <summary>
		/// DAC Field Name: StdWeeksPerYear 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Working Weeks per Year 
		/// </summary>
		[DataMember(Name="WorkingWeeksPerYear", EmitDefaultValue=false)]
		public ByteValue? WorkingWeeksPerYear { get; set; }

		[DataMember(Name="WorkLocations", EmitDefaultValue=false)]
		public List<EmployeeClassWorkLocation>? WorkLocations { get; set; }

	}
}