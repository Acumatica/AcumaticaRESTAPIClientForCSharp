using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class BusinessAccountPaymentInstructionDetail : Entity
	{

		public StringValue? Description { get; set; }

		public IntValue? LocationID { get; set; }

		public StringValue? PaymentInstructionsID { get; set; }

		public StringValue? PaymentMethod { get; set; }

		public StringValue? Value { get; set; }

	}
}