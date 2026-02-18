using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class EmployeeGeneralInfo : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CalendarID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Calendar { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CalendarIDUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		public BooleanValue? CalendarClassDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HoursPerYearForCertified</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Certified Project Hours per Year</para>
		/// </summary>
		public IntValue? CertifiedProjectHoursperYear { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Default Union</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? DefaultUnion { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Default WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? DefaultWCCCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExemptFromCertifiedReporting</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Exempt from Certified Reporting</para>
		/// </summary>
		public BooleanValue? ExemptFromCertReporting { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExemptFromCertifiedReportingUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		public BooleanValue? ExemptFromCertReportingClassDefault { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Exempt from Overtime Rules</para>
		/// </summary>
		public BooleanValue? ExemptFromOvertimeRules { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExemptFromOvertimeRulesUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		public BooleanValue? ExemptFromOvertimeRulesClassDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NetPayMinUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		public BooleanValue? NetPayMinClassDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NetPayMin</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Net Pay Minimum</para>
		/// </summary>
		public DecimalValue? NetPayMinimum { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideHoursPerYearForCertifiedUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		public BooleanValue? OverrideHoursPerYearForCertClassDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideHoursPerYearForCertified</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Override Hours per Year for Certified Project</para>
		/// </summary>
		public BooleanValue? OverrideHrsPerYearForCertProjects { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayGroupID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Pay Group</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? PayGroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayGroupUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		public BooleanValue? PayGroupClassDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		public BooleanValue? UnionClassDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HoursPerYearForCertifiedUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		public BooleanValue? UseClassDefaultValueHoursPerYearForCertifiedUseDflt { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCodeUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		public BooleanValue? WCCCodeClassDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdWeeksPerYearUseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		public BooleanValue? WeeksPerYearClassDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HoursPerWeek</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Working Hours per Week</para>
		/// </summary>
		public DecimalValue? WorkingHoursPerWeek { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HoursPerYear</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Working Hours per Year</para>
		/// </summary>
		public DecimalValue? WorkingHoursPerYear { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdWeeksPerYear</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Working Weeks per Year</para>
		/// </summary>
		public ByteValue? WorkingWeeksPerYear { get; set; }

	}
}