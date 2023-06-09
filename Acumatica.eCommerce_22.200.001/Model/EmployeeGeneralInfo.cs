using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class EmployeeGeneralInfo : Entity
	{

		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue Calendar { get; set; }

		[DataMember(Name="CalendarClassDefault", EmitDefaultValue=false)]
		public BooleanValue CalendarClassDefault { get; set; }

		[DataMember(Name="CertifiedProjectHoursperYear", EmitDefaultValue=false)]
		public IntValue CertifiedProjectHoursperYear { get; set; }

		[DataMember(Name="DefaultUnion", EmitDefaultValue=false)]
		public StringValue DefaultUnion { get; set; }

		[DataMember(Name="DefaultWCCCode", EmitDefaultValue=false)]
		public StringValue DefaultWCCCode { get; set; }

		[DataMember(Name="ExemptFromCertReporting", EmitDefaultValue=false)]
		public BooleanValue ExemptFromCertReporting { get; set; }

		[DataMember(Name="ExemptFromCertReportingClassDefault", EmitDefaultValue=false)]
		public BooleanValue ExemptFromCertReportingClassDefault { get; set; }

		[DataMember(Name="ExemptFromOvertimeRules", EmitDefaultValue=false)]
		public BooleanValue ExemptFromOvertimeRules { get; set; }

		[DataMember(Name="ExemptFromOvertimeRulesClassDefault", EmitDefaultValue=false)]
		public BooleanValue ExemptFromOvertimeRulesClassDefault { get; set; }

		[DataMember(Name="NetPayMinClassDefault", EmitDefaultValue=false)]
		public BooleanValue NetPayMinClassDefault { get; set; }

		[DataMember(Name="NetPayMinimum", EmitDefaultValue=false)]
		public DecimalValue NetPayMinimum { get; set; }

		[DataMember(Name="OverrideHoursPerYearForCertClassDefault", EmitDefaultValue=false)]
		public BooleanValue OverrideHoursPerYearForCertClassDefault { get; set; }

		[DataMember(Name="OverrideHrsPerYearForCertProjects", EmitDefaultValue=false)]
		public BooleanValue OverrideHrsPerYearForCertProjects { get; set; }

		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue PayGroup { get; set; }

		[DataMember(Name="PayGroupClassDefault", EmitDefaultValue=false)]
		public BooleanValue PayGroupClassDefault { get; set; }

		[DataMember(Name="UnionClassDefault", EmitDefaultValue=false)]
		public BooleanValue UnionClassDefault { get; set; }

		[DataMember(Name="UseClassDefaultValueHoursPerYearForCertifiedUseDflt", EmitDefaultValue=false)]
		public BooleanValue UseClassDefaultValueHoursPerYearForCertifiedUseDflt { get; set; }

		[DataMember(Name="WCCCodeClassDefault", EmitDefaultValue=false)]
		public BooleanValue WCCCodeClassDefault { get; set; }

		[DataMember(Name="WeeksPerYearClassDefault", EmitDefaultValue=false)]
		public BooleanValue WeeksPerYearClassDefault { get; set; }

		[DataMember(Name="WorkingHoursPerWeek", EmitDefaultValue=false)]
		public DecimalValue WorkingHoursPerWeek { get; set; }

		[DataMember(Name="WorkingHoursPerYear", EmitDefaultValue=false)]
		public DecimalValue WorkingHoursPerYear { get; set; }

		[DataMember(Name="WorkingWeeksPerYear", EmitDefaultValue=false)]
		public ByteValue WorkingWeeksPerYear { get; set; }

	}
}