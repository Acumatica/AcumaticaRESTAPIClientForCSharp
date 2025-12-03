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
		/// <para>DAC Field Name: HoursPerYearForCertified</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Certified Project Hours per Year</para>
		/// </summary>
		[DataMember(Name="CertifiedProjectHoursperYear", EmitDefaultValue=false)]
		public IntValue? CertifiedProjectHoursperYear { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CalendarID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Default Calendar</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DefaultCalendar", EmitDefaultValue=false)]
		public StringValue? DefaultCalendar { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Default Union</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="DefaultUnion", EmitDefaultValue=false)]
		public StringValue? DefaultUnion { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Default WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="DefaultWCCCode", EmitDefaultValue=false)]
		public StringValue? DefaultWCCCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmpType</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Employee Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="EmployeeType", EmitDefaultValue=false)]
		public StringValue? EmployeeType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Exempt from Certified Reporting</para>
		/// </summary>
		[DataMember(Name="ExemptFromCertifiedReporting", EmitDefaultValue=false)]
		public BooleanValue? ExemptFromCertifiedReporting { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Exempt from Overtime Rules</para>
		/// </summary>
		[DataMember(Name="ExemptFromOvertimeRules", EmitDefaultValue=false)]
		public BooleanValue? ExemptFromOvertimeRules { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmpType</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Employee Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="HoursPerYearForCertified", EmitDefaultValue=false)]
		public StringValue? HoursPerYearForCertified { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GrnMaxPctNet</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Maximum Percent of Net Pay for All Garnishments</para>
		/// </summary>
		[DataMember(Name="MaximumPercentofNetPayforallGarnishments", EmitDefaultValue=false)]
		public DecimalValue? MaximumPercentofNetPayforallGarnishments { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NetPayMin</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Net Pay Minimum</para>
		/// </summary>
		[DataMember(Name="NetPayMinimum", EmitDefaultValue=false)]
		public DecimalValue? NetPayMinimum { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideHoursPerYearForCertified</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Override Hours per Year for Certified Project</para>
		/// </summary>
		[DataMember(Name="OverrideHoursPerYearforCertProject", EmitDefaultValue=false)]
		public BooleanValue? OverrideHoursPerYearforCertProject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayGroupID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Pay Group</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UsePayrollProjectWorkLocation</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Use Payroll Work Location from Project</para>
		/// </summary>
		[DataMember(Name="UsePayrollWorkLocationfromProject", EmitDefaultValue=false)]
		public BooleanValue? UsePayrollWorkLocationfromProject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HoursPerWeek</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Working Hours per Week</para>
		/// </summary>
		[DataMember(Name="WorkingHoursPerWeek", EmitDefaultValue=false)]
		public DecimalValue? WorkingHoursPerWeek { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HoursPerYear</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Working Hours per Year</para>
		/// </summary>
		[DataMember(Name="WorkingHoursPerYear", EmitDefaultValue=false)]
		public DecimalValue? WorkingHoursPerYear { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdWeeksPerYear</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Working Weeks per Year</para>
		/// </summary>
		[DataMember(Name="WorkingWeeksPerYear", EmitDefaultValue=false)]
		public ByteValue? WorkingWeeksPerYear { get; set; }

		[DataMember(Name="WorkLocations", EmitDefaultValue=false)]
		public List<EmployeeClassWorkLocation>? WorkLocations { get; set; }

	}
}