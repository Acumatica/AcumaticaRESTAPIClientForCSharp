using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class PTOBankBandingRuleDetail : Entity
	{

		public DecimalValue? AccrualPercent { get; set; }

		public DecimalValue? BalanceLimit { get; set; }

		public DecimalValue? CarryoverHours { get; set; }

		public StringValue? EmployeeClass { get; set; }

		public DecimalValue? FrontLoadingHours { get; set; }

		public DecimalValue? HoursperYear { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public IntValue? YearsofService { get; set; }

	}
}