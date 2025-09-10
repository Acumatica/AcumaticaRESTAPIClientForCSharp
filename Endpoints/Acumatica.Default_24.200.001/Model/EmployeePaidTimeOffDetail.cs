using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class EmployeePaidTimeOffDetail : Entity
	{

		[DataMember(Name="AccrualMethod", EmitDefaultValue=false)]
		public StringValue? AccrualMethod { get; set; }

		[DataMember(Name="AccrualPercent", EmitDefaultValue=false)]
		public DecimalValue? AccrualPercent { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AllowNegativeBalance", EmitDefaultValue=false)]
		public BooleanValue? AllowNegativeBalance { get; set; }

		[DataMember(Name="AllowViewAvailablePTOPaidHours", EmitDefaultValue=false)]
		public BooleanValue? AllowViewAvailablePTOPaidHours { get; set; }

		[DataMember(Name="BalanceLimit", EmitDefaultValue=false)]
		public DecimalValue? BalanceLimit { get; set; }

		[DataMember(Name="BandingRule", EmitDefaultValue=false)]
		public IntValue? BandingRule { get; set; }

		[DataMember(Name="CanOnlyDisbursefromCarryover", EmitDefaultValue=false)]
		public BooleanValue? CanOnlyDisbursefromCarryover { get; set; }

		[DataMember(Name="CarryoverHours", EmitDefaultValue=false)]
		public DecimalValue? CarryoverHours { get; set; }

		[DataMember(Name="CarryoverType", EmitDefaultValue=false)]
		public StringValue? CarryoverType { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="FrontLoadingHours", EmitDefaultValue=false)]
		public DecimalValue? FrontLoadingHours { get; set; }

		[DataMember(Name="HoursperYear", EmitDefaultValue=false)]
		public DecimalValue? HoursperYear { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="OnSettlement", EmitDefaultValue=false)]
		public StringValue? OnSettlement { get; set; }

		[DataMember(Name="ProbationPeriodBehaviour", EmitDefaultValue=false)]
		public StringValue? ProbationPeriodBehaviour { get; set; }

		[DataMember(Name="PTOBank", EmitDefaultValue=false)]
		public StringValue? PTOBank { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="TransferDate", EmitDefaultValue=false)]
		public DateTimeValue? TransferDate { get; set; }

	}
}