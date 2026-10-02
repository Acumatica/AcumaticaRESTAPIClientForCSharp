using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class EmployeePaidTimeOffDetail : Entity
	{

		#region Fields
		public StringValue? AccrualMethod { get; set; }

		public DecimalValue? AccrualPercent { get; set; }

		public BooleanValue? Active { get; set; }

		public BooleanValue? AllowNegativeBalance { get; set; }

		public BooleanValue? AllowViewAvailablePTOPaidHours { get; set; }

		public DecimalValue? BalanceLimit { get; set; }

		public IntValue? BandingRule { get; set; }

		public BooleanValue? CanOnlyDisbursefromCarryover { get; set; }

		public DecimalValue? CarryoverHours { get; set; }

		public StringValue? CarryoverType { get; set; }

		public StringValue? Description { get; set; }

		public DecimalValue? FrontLoadingHours { get; set; }

		public DecimalValue? HoursperYear { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? OnSettlement { get; set; }

		public StringValue? ProbationPeriodBehaviour { get; set; }

		public StringValue? PTOBank { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public DateTimeValue? TransferDate { get; set; }

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

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}