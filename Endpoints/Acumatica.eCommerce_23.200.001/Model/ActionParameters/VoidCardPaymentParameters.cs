using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	public class VoidCardPaymentParameters
	{
		public VoidCardPaymentParameters() { }


		public StringValue? TranType { get; set; }

		public StringValue? TranNbr { get; set; }

		public StringValue? ExtProfileId { get; set; }

		public DateTimeValue? TranDate { get; set; }

		public BooleanValue? NeedValidation { get; set; }

		public StringValue? OrigTranNbr { get; set; }
	}
}