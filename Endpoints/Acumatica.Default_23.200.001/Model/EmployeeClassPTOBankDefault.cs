using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class EmployeeClassPTOBankDefault : Entity
	{

		public DecimalValue? AccrualLimit { get; set; }

		public StringValue? AccrualMethod { get; set; }

		public DecimalValue? AccrualPercent { get; set; }

		public BooleanValue? Active { get; set; }

		public DecimalValue? CarryoverAmount { get; set; }

		public StringValue? CarryoverType { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? DisbursingType { get; set; }

		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeClassID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Payroll Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? EmployeeClass { get; set; }

		public DecimalValue? FrontLoadingAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Working Hours per Year</para>
		/// </summary>
		public DecimalValue? HoursPerYear { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? PTOBank { get; set; }

	}
}