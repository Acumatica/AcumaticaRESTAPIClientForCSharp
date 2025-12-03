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
	/// Corresponds to the screen <c>PR202000</c> in the Acumatica ERP
	/// <para>Key Fields: EmployeePayrollClassID</para>
	/// </summary>
	[DataContract]
	public class EmployeePayrollClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeClassID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Payroll Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
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

		public static class Expand
		{
			public const string Files = "Files";
			public const string PayrollDefaults = "PayrollDefaults";
			public const string PayrollDefaults_WorkLocations = "PayrollDefaults/WorkLocations";
			public const string PayrollDefaults_WorkLocations_Files = "PayrollDefaults/WorkLocations/Files";
			public const string PTODefaults = "PTODefaults";
			public const string PTODefaults_Files = "PTODefaults/Files";

			//Intentionally excluded
			//public const string All = "Files,PayrollDefaults,PayrollDefaults/WorkLocations,PayrollDefaults/WorkLocations/Files,PTODefaults,PTODefaults/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}