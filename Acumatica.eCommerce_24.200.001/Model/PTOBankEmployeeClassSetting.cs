using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class PTOBankEmployeeClassSetting : Entity
	{

		[DataMember(Name="AccrualPercent", EmitDefaultValue=false)]
		public DecimalValue? AccrualPercent { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AllowNegativeBalance", EmitDefaultValue=false)]
		public BooleanValue? AllowNegativeBalance { get; set; }

		[DataMember(Name="BalanceLimit", EmitDefaultValue=false)]
		public DecimalValue? BalanceLimit { get; set; }

		[DataMember(Name="CarryoverHours", EmitDefaultValue=false)]
		public DecimalValue? CarryoverHours { get; set; }

		[DataMember(Name="DisburseOnlyfromCarryover", EmitDefaultValue=false)]
		public BooleanValue? DisburseOnlyfromCarryover { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		[DataMember(Name="EmployeeClass", EmitDefaultValue=false)]
		public StringValue? EmployeeClass { get; set; }

		[DataMember(Name="FrontLoadingHours", EmitDefaultValue=false)]
		public DecimalValue? FrontLoadingHours { get; set; }

		[DataMember(Name="HoursperYear", EmitDefaultValue=false)]
		public DecimalValue? HoursperYear { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="ProbationPeriodBehaviour", EmitDefaultValue=false)]
		public StringValue? ProbationPeriodBehaviour { get; set; }

	}
}