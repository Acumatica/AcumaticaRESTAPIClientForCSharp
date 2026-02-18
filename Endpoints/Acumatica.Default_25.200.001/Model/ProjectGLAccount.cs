using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ProjectGLAccount : Entity
	{

		public StringValue? AccrualAccount { get; set; }

		public StringValue? AccrualSubaccount { get; set; }

		public StringValue? DefaultAccount { get; set; }

		public StringValue? DefaultSubaccount { get; set; }

		public StringValue? DefaultCostAccount { get; set; }

		public StringValue? DefaultCostSubaccount { get; set; }

		public List<DefaultTaskForGLAccount>? DefaultTaskForGLAccounts { get; set; }

	}
}