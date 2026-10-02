using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class EmployeePaycheckSummary : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// <para>SQL Type: varchar(MAX)</para>
		/// </summary>
		public StringValue? Employee { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// <para>Display Name: Employee Name</para>
		/// <para>SQL Type: varchar(MAX)</para>
		/// </summary>
		public StringValue? EmployeeName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HourQty</para>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// </summary>
		public DecimalValue? Hours { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// </summary>
		public DecimalValue? Rate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentDocAndRef</para>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// <para>Display Name: Paycheck Ref</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? PaycheckRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VoidPaymentDocAndRef</para>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// <para>Display Name: Void Paycheck Ref</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? VoidPaycheckRef { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region LinkedEntities
		public EmployeePaycheckEarnings? EmployeePaycheckEarnings { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string EmployeePaycheckEarnings = "EmployeePaycheckEarnings";

			//Intentionally excluded
			//public const string All = "Files,EmployeePaycheckEarnings";
		}
	}
}