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
	public class EmployeeClassPTOBankDefault : Entity
	{

		[DataMember(Name="AccrualLimit", EmitDefaultValue=false)]
		public DecimalValue? AccrualLimit { get; set; }

		[DataMember(Name="AccrualMethod", EmitDefaultValue=false)]
		public StringValue? AccrualMethod { get; set; }

		[DataMember(Name="AccrualPercent", EmitDefaultValue=false)]
		public DecimalValue? AccrualPercent { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="CarryoverAmount", EmitDefaultValue=false)]
		public DecimalValue? CarryoverAmount { get; set; }

		[DataMember(Name="CarryoverType", EmitDefaultValue=false)]
		public StringValue? CarryoverType { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DisbursingType", EmitDefaultValue=false)]
		public StringValue? DisbursingType { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeClassID</para>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Payroll Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="EmployeeClass", EmitDefaultValue=false)]
		public StringValue? EmployeeClass { get; set; }

		[DataMember(Name="FrontLoadingAmount", EmitDefaultValue=false)]
		public DecimalValue? FrontLoadingAmount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PREmployeeClass</para>
		/// <para>Display Name: Working Hours per Year</para>
		/// </summary>
		[DataMember(Name="HoursPerYear", EmitDefaultValue=false)]
		public DecimalValue? HoursPerYear { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PTOBank", EmitDefaultValue=false)]
		public StringValue? PTOBank { get; set; }

	}
}