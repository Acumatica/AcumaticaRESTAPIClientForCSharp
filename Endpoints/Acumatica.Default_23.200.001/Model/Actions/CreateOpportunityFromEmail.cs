using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class CreateOpportunityFromEmail : EntityAction<Email>
	{
		public CreateOpportunityFromEmail(Email entity) : base(entity)
		{ }
	}
}
