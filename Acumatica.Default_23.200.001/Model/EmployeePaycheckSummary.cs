using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class EmployeePaycheckSummary : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.PR.PRBatchEmployee 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// DAC Field Name: AcctCD 
		/// DAC: PX.Objects.PR.PRBatchEmployee 
		/// SQL Type: varchar(MAX) 
		/// </summary>
		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		/// <summary>
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.PR.PRBatchEmployee 
		/// Display Name: Employee Name 
		/// SQL Type: varchar(MAX) 
		/// </summary>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		[DataMember(Name="EmployeePaycheckEarnings", EmitDefaultValue=false)]
		public EmployeePaycheckEarnings? EmployeePaycheckEarnings { get; set; }

		/// <summary>
		/// DAC Field Name: HourQty 
		/// DAC: PX.Objects.PR.PRBatchEmployee 
		/// </summary>
		[DataMember(Name="Hours", EmitDefaultValue=false)]
		public DecimalValue? Hours { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: PaymentDocAndRef 
		/// DAC: PX.Objects.PR.PRBatchEmployee 
		/// Display Name: Paycheck Ref 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="PaycheckRef", EmitDefaultValue=false)]
		public StringValue? PaycheckRef { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRBatchEmployee 
		/// </summary>
		[DataMember(Name="Rate", EmitDefaultValue=false)]
		public DecimalValue? Rate { get; set; }

		/// <summary>
		/// DAC Field Name: VoidPaymentDocAndRef 
		/// DAC: PX.Objects.PR.PRBatchEmployee 
		/// Display Name: Void Paycheck Ref 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="VoidPaycheckRef", EmitDefaultValue=false)]
		public StringValue? VoidPaycheckRef { get; set; }

	}
}