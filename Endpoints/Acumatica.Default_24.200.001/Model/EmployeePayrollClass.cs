using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR202000</c> in the Acumatica ERP
	/// <para>Key Fields: EmployeePayrollClassID</para>
	/// </summary>
	public class EmployeePayrollClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeClassID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Payroll Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? EmployeePayrollClassID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public EmployeePayrollClassDefaults? PayrollDefaults { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string PayrollDefaults = "PayrollDefaults";
			public const string PayrollDefaults_WorkLocations = "PayrollDefaults/WorkLocations";
			public const string PayrollDefaults_WorkLocations_Files = "PayrollDefaults/WorkLocations/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,PayrollDefaults,PayrollDefaults/WorkLocations,PayrollDefaults/WorkLocations/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}