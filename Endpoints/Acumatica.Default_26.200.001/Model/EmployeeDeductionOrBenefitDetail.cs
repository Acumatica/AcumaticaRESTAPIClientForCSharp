using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class EmployeeDeductionOrBenefitDetail : Entity
	{

		#region Fields
		public BooleanValue? Active { get; set; }

		public DecimalValue? ContributionAmount { get; set; }

		public DecimalValue? ContributionMax { get; set; }

		public StringValue? ContributionMaximumFrequency { get; set; }

		public DecimalValue? ContributionPercent { get; set; }

		public DecimalValue? DeductionAmount { get; set; }

		public StringValue? DeductionCode { get; set; }

		public DecimalValue? DeductionMax { get; set; }

		public StringValue? DeductionMaximumFrequency { get; set; }

		public DecimalValue? DeductionPercent { get; set; }

		public StringValue? Description { get; set; }

		public DateTimeValue? EndDate { get; set; }

		public BooleanValue? IsGarnish { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public IntValue? Sequence { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public BooleanValue? UseContributionDefaults { get; set; }

		public BooleanValue? UseDeductionDefaults { get; set; }

		#endregion

		#region LinkedEntities
		public GarnishmentDetails? GarnishmentDetails { get; set; }

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
			public const string GarnishmentDetails = "GarnishmentDetails";

			//Intentionally excluded
			//public const string All = "Files,GarnishmentDetails";
		}
	}
}