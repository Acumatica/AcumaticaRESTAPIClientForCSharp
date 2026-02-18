using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class WCCCodeRateDetail : Entity
	{

		public GuidValue? Active { get; set; }

		public DecimalValue? BenefitRate { get; set; }

		public StringValue? Branch { get; set; }

		public DecimalValue? DeductionRate { get; set; }

		public StringValue? Description { get; set; }

		public DateTimeValue? EffectiveDate { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? WCCCode { get; set; }

		public List<WCCCodeMaxInsurableWageDetail>? WCCCodeMaxInsurableWages { get; set; }

	}
}