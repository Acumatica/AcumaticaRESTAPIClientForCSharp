using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class CardOperationParameters
	{
		public CardOperationParameters() { }


		public StringValue? TranType { get; set; }

		public StringValue? TranNbr { get; set; }

		public StringValue? TranApiNbr { get; set; }

		public StringValue? AuthNumber { get; set; }

		public StringValue? ExtProfileId { get; set; }

		public DateTimeValue? TranDate { get; set; }

		public StringValue? OrigTranNbr { get; set; }

		public DecimalValue? Amount { get; set; }
	}
}