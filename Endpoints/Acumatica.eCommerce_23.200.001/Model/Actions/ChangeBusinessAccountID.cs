using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	public class ChangeBusinessAccountID : EntityActionWithParameters<BusinessAccount, ChangeBusinessAccountIDParameters>
	{
		public ChangeBusinessAccountID(BusinessAccount entity, ChangeBusinessAccountIDParameters parameters) : base(entity, parameters)
		{ }
	}
}