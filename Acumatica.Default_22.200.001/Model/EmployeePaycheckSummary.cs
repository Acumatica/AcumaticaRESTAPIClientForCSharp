using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeePaycheckSummary : Entity
	{

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		[DataMember(Name="EmployeePaycheckEarnings", EmitDefaultValue=false)]
		public EmployeePaycheckEarnings? EmployeePaycheckEarnings { get; set; }

		[DataMember(Name="Hours", EmitDefaultValue=false)]
		public DecimalValue? Hours { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PaycheckRef", EmitDefaultValue=false)]
		public StringValue? PaycheckRef { get; set; }

		[DataMember(Name="Rate", EmitDefaultValue=false)]
		public DecimalValue? Rate { get; set; }

		[DataMember(Name="VoidPaycheckRef", EmitDefaultValue=false)]
		public StringValue? VoidPaycheckRef { get; set; }

	}
}