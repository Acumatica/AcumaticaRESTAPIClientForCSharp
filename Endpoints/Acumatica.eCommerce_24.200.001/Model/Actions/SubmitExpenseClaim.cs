using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	public class SubmitExpenseClaim : EntityAction<ExpenseClaim>
	{
		public SubmitExpenseClaim(ExpenseClaim entity) : base(entity)
		{ }
	}
}
