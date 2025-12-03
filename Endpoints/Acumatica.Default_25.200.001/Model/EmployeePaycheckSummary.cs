using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class EmployeePaycheckSummary : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// <para>SQL Type: varchar(MAX)</para>
		/// </summary>
		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// <para>Display Name: Employee Name</para>
		/// <para>SQL Type: varchar(MAX)</para>
		/// </summary>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		[DataMember(Name="EmployeePaycheckEarnings", EmitDefaultValue=false)]
		public EmployeePaycheckEarnings? EmployeePaycheckEarnings { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HourQty</para>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// </summary>
		[DataMember(Name="Hours", EmitDefaultValue=false)]
		public DecimalValue? Hours { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentDocAndRef</para>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// <para>Display Name: Paycheck Ref</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="PaycheckRef", EmitDefaultValue=false)]
		public StringValue? PaycheckRef { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// </summary>
		[DataMember(Name="Rate", EmitDefaultValue=false)]
		public DecimalValue? Rate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VoidPaymentDocAndRef</para>
		/// <para>DAC: PX.Objects.PR.PRBatchEmployee</para>
		/// <para>Display Name: Void Paycheck Ref</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="VoidPaycheckRef", EmitDefaultValue=false)]
		public StringValue? VoidPaycheckRef { get; set; }

	}
}