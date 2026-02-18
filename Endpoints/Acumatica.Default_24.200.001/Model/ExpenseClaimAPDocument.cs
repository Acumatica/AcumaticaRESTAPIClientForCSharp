using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ExpenseClaimAPDocument : Entity
	{

		public DecimalValue? Amount { get; set; }

		public StringValue? RefNbr { get; set; }

		public StringValue? Status { get; set; }

		public StringValue? TaxZone { get; set; }

		public StringValue? Type { get; set; }

	}
}