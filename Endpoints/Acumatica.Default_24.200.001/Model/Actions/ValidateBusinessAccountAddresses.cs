using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ValidateBusinessAccountAddresses : EntityAction<BusinessAccount>
	{
		public ValidateBusinessAccountAddresses(BusinessAccount entity) : base(entity)
		{ }
	}
}
