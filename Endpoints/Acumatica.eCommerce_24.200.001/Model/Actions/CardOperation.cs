using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	public class CardOperation : EntityActionWithParameters<Payment, CardOperationParameters>
	{
		public CardOperation(Payment entity, CardOperationParameters parameters) : base(entity, parameters)
		{ }
	}
}