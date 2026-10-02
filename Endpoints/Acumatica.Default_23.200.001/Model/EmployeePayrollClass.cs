using System;
using System.Collections.Generic;

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
	public class EmployeePayrollClass : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: EmployeeClassID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Payroll Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? EmployeePayrollClassID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region LinkedEntities
		public EmployeePayrollClassDefaults? PayrollDefaults { get; set; }

		#endregion

		#region Details
		public List<EmployeeClassPTOBankDefault>? PTODefaults { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(EmployeePayrollClass)} - \"{EmployeePayrollClassID}\"";
		}

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string PayrollDefaults = "PayrollDefaults";
			public const string PayrollDefaults_WorkLocations = "PayrollDefaults/WorkLocations";
			public const string PayrollDefaults_WorkLocations_Files = "PayrollDefaults/WorkLocations/Files";
			public const string PTODefaults = "PTODefaults";
			public const string PTODefaults_Files = "PTODefaults/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,PayrollDefaults,PayrollDefaults/WorkLocations,PayrollDefaults/WorkLocations/Files,PTODefaults,PTODefaults/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}