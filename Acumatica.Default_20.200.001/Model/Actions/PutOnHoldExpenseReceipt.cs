using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class PutOnHoldExpenseReceipt : EntityAction<ExpenseReceipt>
	{
		public PutOnHoldExpenseReceipt(ExpenseReceipt entity) : base(entity)
		{ }
		public PutOnHoldExpenseReceipt() : base()
		{ }
	}
}
