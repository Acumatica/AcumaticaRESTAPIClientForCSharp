using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class EmployeeGeneralInfo : Entity
	{

		/// <summary>
		/// DAC Field Name: CalendarID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue? Calendar { get; set; }

		/// <summary>
		/// DAC Field Name: CalendarIDUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="CalendarClassDefault", EmitDefaultValue=false)]
		public BooleanValue? CalendarClassDefault { get; set; }

		/// <summary>
		/// DAC Field Name: HoursPerYearForCertified 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Certified Project Hours per Year 
		/// </summary>
		[DataMember(Name="CertifiedProjectHoursperYear", EmitDefaultValue=false)]
		public IntValue? CertifiedProjectHoursperYear { get; set; }

		/// <summary>
		/// DAC Field Name: UnionID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Default Union 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="DefaultUnion", EmitDefaultValue=false)]
		public StringValue? DefaultUnion { get; set; }

		/// <summary>
		/// DAC Field Name: WorkCodeID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Default WCC Code 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="DefaultWCCCode", EmitDefaultValue=false)]
		public StringValue? DefaultWCCCode { get; set; }

		/// <summary>
		/// DAC Field Name: ExemptFromCertifiedReporting 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Exempt from Certified Reporting 
		/// </summary>
		[DataMember(Name="ExemptFromCertReporting", EmitDefaultValue=false)]
		public BooleanValue? ExemptFromCertReporting { get; set; }

		/// <summary>
		/// DAC Field Name: ExemptFromCertifiedReportingUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="ExemptFromCertReportingClassDefault", EmitDefaultValue=false)]
		public BooleanValue? ExemptFromCertReportingClassDefault { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Exempt from Overtime Rules 
		/// </summary>
		[DataMember(Name="ExemptFromOvertimeRules", EmitDefaultValue=false)]
		public BooleanValue? ExemptFromOvertimeRules { get; set; }

		/// <summary>
		/// DAC Field Name: ExemptFromOvertimeRulesUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="ExemptFromOvertimeRulesClassDefault", EmitDefaultValue=false)]
		public BooleanValue? ExemptFromOvertimeRulesClassDefault { get; set; }

		/// <summary>
		/// DAC Field Name: NetPayMinUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="NetPayMinClassDefault", EmitDefaultValue=false)]
		public BooleanValue? NetPayMinClassDefault { get; set; }

		/// <summary>
		/// DAC Field Name: NetPayMin 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Net Pay Minimum 
		/// </summary>
		[DataMember(Name="NetPayMinimum", EmitDefaultValue=false)]
		public DecimalValue? NetPayMinimum { get; set; }

		/// <summary>
		/// DAC Field Name: OverrideHoursPerYearForCertifiedUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="OverrideHoursPerYearForCertClassDefault", EmitDefaultValue=false)]
		public BooleanValue? OverrideHoursPerYearForCertClassDefault { get; set; }

		/// <summary>
		/// DAC Field Name: OverrideHoursPerYearForCertified 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Override Hours per Year for Certified Project 
		/// </summary>
		[DataMember(Name="OverrideHrsPerYearForCertProjects", EmitDefaultValue=false)]
		public BooleanValue? OverrideHrsPerYearForCertProjects { get; set; }

		/// <summary>
		/// DAC Field Name: PayGroupID 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Pay Group 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		/// <summary>
		/// DAC Field Name: PayGroupUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="PayGroupClassDefault", EmitDefaultValue=false)]
		public BooleanValue? PayGroupClassDefault { get; set; }

		/// <summary>
		/// DAC Field Name: UnionUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="UnionClassDefault", EmitDefaultValue=false)]
		public BooleanValue? UnionClassDefault { get; set; }

		/// <summary>
		/// DAC Field Name: HoursPerYearForCertifiedUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="UseClassDefaultValueHoursPerYearForCertifiedUseDflt", EmitDefaultValue=false)]
		public BooleanValue? UseClassDefaultValueHoursPerYearForCertifiedUseDflt { get; set; }

		/// <summary>
		/// DAC Field Name: WorkCodeUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="WCCCodeClassDefault", EmitDefaultValue=false)]
		public BooleanValue? WCCCodeClassDefault { get; set; }

		/// <summary>
		/// DAC Field Name: StdWeeksPerYearUseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="WeeksPerYearClassDefault", EmitDefaultValue=false)]
		public BooleanValue? WeeksPerYearClassDefault { get; set; }

		/// <summary>
		/// DAC Field Name: HoursPerWeek 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Working Hours per Week 
		/// </summary>
		[DataMember(Name="WorkingHoursPerWeek", EmitDefaultValue=false)]
		public DecimalValue? WorkingHoursPerWeek { get; set; }

		/// <summary>
		/// DAC Field Name: HoursPerYear 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Working Hours per Year 
		/// </summary>
		[DataMember(Name="WorkingHoursPerYear", EmitDefaultValue=false)]
		public DecimalValue? WorkingHoursPerYear { get; set; }

		/// <summary>
		/// DAC Field Name: StdWeeksPerYear 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Working Weeks per Year 
		/// </summary>
		[DataMember(Name="WorkingWeeksPerYear", EmitDefaultValue=false)]
		public ByteValue? WorkingWeeksPerYear { get; set; }

	}
}