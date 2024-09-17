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
	public class EmployeePayrollClass : Entity, ITopLevelEntity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EmployeePayrollClassID", EmitDefaultValue=false)]
		public StringValue? EmployeePayrollClassID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PayrollDefaults", EmitDefaultValue=false)]
		public EmployeePayrollClassDefaults? PayrollDefaults { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}