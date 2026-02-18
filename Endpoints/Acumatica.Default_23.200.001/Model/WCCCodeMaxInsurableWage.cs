using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class WCCCodeMaxInsurableWage : Entity
	{

		public StringValue? DeductionandBenefitCode { get; set; }

		public DateTimeValue? EffectiveDate { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? State { get; set; }

		public DecimalValue? Wage { get; set; }

		public StringValue? WCCode { get; set; }

	}
}