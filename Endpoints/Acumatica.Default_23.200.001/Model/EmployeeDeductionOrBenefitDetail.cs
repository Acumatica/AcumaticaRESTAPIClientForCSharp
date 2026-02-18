using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class EmployeeDeductionOrBenefitDetail : Entity
	{

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

		public GarnishmentDetails? GarnishmentDetails { get; set; }

		public BooleanValue? IsGarnish { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public IntValue? Sequence { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public BooleanValue? UseContributionDefaults { get; set; }

		public BooleanValue? UseDeductionDefaults { get; set; }

	}
}