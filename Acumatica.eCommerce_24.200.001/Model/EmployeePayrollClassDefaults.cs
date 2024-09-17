using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class EmployeePayrollClassDefaults : Entity
	{

		[DataMember(Name="CertifiedProjectHoursperYear", EmitDefaultValue=false)]
		public IntValue? CertifiedProjectHoursperYear { get; set; }

		[DataMember(Name="DefaultCalendar", EmitDefaultValue=false)]
		public StringValue? DefaultCalendar { get; set; }

		[DataMember(Name="DefaultUnion", EmitDefaultValue=false)]
		public StringValue? DefaultUnion { get; set; }

		[DataMember(Name="DefaultWCCCode", EmitDefaultValue=false)]
		public StringValue? DefaultWCCCode { get; set; }

		[DataMember(Name="EmployeeType", EmitDefaultValue=false)]
		public StringValue? EmployeeType { get; set; }

		[DataMember(Name="ExemptFromCertifiedReporting", EmitDefaultValue=false)]
		public BooleanValue? ExemptFromCertifiedReporting { get; set; }

		[DataMember(Name="ExemptFromOvertimeRules", EmitDefaultValue=false)]
		public BooleanValue? ExemptFromOvertimeRules { get; set; }

		[DataMember(Name="HoursPerYearForCertified", EmitDefaultValue=false)]
		public StringValue? HoursPerYearForCertified { get; set; }

		[DataMember(Name="MaximumPercentofNetPayforallGarnishments", EmitDefaultValue=false)]
		public DecimalValue? MaximumPercentofNetPayforallGarnishments { get; set; }

		[DataMember(Name="NetPayMinimum", EmitDefaultValue=false)]
		public DecimalValue? NetPayMinimum { get; set; }

		[DataMember(Name="OverrideHoursPerYearforCertProject", EmitDefaultValue=false)]
		public BooleanValue? OverrideHoursPerYearforCertProject { get; set; }

		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		[DataMember(Name="UsePayrollWorkLocationfromProject", EmitDefaultValue=false)]
		public BooleanValue? UsePayrollWorkLocationfromProject { get; set; }

		[DataMember(Name="WorkingHoursPerWeek", EmitDefaultValue=false)]
		public DecimalValue? WorkingHoursPerWeek { get; set; }

		[DataMember(Name="WorkingHoursPerYear", EmitDefaultValue=false)]
		public DecimalValue? WorkingHoursPerYear { get; set; }

		[DataMember(Name="WorkingWeeksPerYear", EmitDefaultValue=false)]
		public ByteValue? WorkingWeeksPerYear { get; set; }

		[DataMember(Name="WorkLocations", EmitDefaultValue=false)]
		public List<EmployeeClassWorkLocation>? WorkLocations { get; set; }

	}
}