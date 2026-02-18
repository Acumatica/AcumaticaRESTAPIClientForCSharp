using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class EmployeePayrollClassDefaults : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: HoursPerYearForCertified</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Certified Project Hours per Year</para>
		/// </summary>
		public IntValue? CertifiedProjectHoursperYear { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CalendarID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Default Calendar</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? DefaultCalendar { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Default Union</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? DefaultUnion { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Default WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? DefaultWCCCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmpType</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Employee Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? EmployeeType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Exempt from Certified Reporting</para>
		/// </summary>
		public BooleanValue? ExemptFromCertifiedReporting { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Exempt from Overtime Rules</para>
		/// </summary>
		public BooleanValue? ExemptFromOvertimeRules { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmpType</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Employee Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? HoursPerYearForCertified { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GrnMaxPctNet</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Maximum Percent of Net Pay for All Garnishments</para>
		/// </summary>
		public DecimalValue? MaximumPercentofNetPayforallGarnishments { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NetPayMin</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Net Pay Minimum</para>
		/// </summary>
		public DecimalValue? NetPayMinimum { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideHoursPerYearForCertified</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Override Hours per Year for Certified Project</para>
		/// </summary>
		public BooleanValue? OverrideHoursPerYearforCertProject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayGroupID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Pay Group</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? PayGroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UsePayrollProjectWorkLocation</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Use Payroll Work Location from Project</para>
		/// </summary>
		public BooleanValue? UsePayrollWorkLocationfromProject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HoursPerWeek</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Working Hours per Week</para>
		/// </summary>
		public DecimalValue? WorkingHoursPerWeek { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HoursPerYear</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Working Hours per Year</para>
		/// </summary>
		public DecimalValue? WorkingHoursPerYear { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdWeeksPerYear</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Working Weeks per Year</para>
		/// </summary>
		public ByteValue? WorkingWeeksPerYear { get; set; }

		public List<EmployeeClassWorkLocation>? WorkLocations { get; set; }

	}
}