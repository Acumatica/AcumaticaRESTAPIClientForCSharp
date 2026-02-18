using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class WCCCodeRate : Entity
	{

		public BooleanValue? Active { get; set; }

		public StringValue? BenefitCalculationMethod { get; set; }

		public DecimalValue? BenefitRate { get; set; }

		public StringValue? Branch { get; set; }

		public StringValue? DeductionCalculationMethod { get; set; }

		public StringValue? DeductionCode { get; set; }

		public DecimalValue? DeductionRate { get; set; }

		public DateTimeValue? EffectiveDate { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public IntValue? RecordID { get; set; }

		public StringValue? State { get; set; }

		public StringValue? WorkCodeID { get; set; }

	}
}