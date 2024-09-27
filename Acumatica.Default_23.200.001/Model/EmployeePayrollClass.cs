using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PR202000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class EmployeePayrollClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: EmployeeClassID 
		/// DAC: PX.Objects.PR.PREmployeeClass 
		/// Display Name: Payroll Class ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="EmployeePayrollClassID", EmitDefaultValue=false)]
		public StringValue? EmployeePayrollClassID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PayrollDefaults", EmitDefaultValue=false)]
		public EmployeePayrollClassDefaults? PayrollDefaults { get; set; }

		[DataMember(Name="PTODefaults", EmitDefaultValue=false)]
		public List<EmployeeClassPTOBankDefault>? PTODefaults { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}