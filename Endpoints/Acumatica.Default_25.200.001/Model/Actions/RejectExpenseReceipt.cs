using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class RejectExpenseReceipt : EntityAction<ExpenseReceipt>
	{
		public RejectExpenseReceipt(ExpenseReceipt entity) : base(entity)
		{ }
	}
}
