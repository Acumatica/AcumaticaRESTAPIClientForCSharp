using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class DefaultTaskForGLAccount : Entity
	{

		public StringValue? Account { get; set; }

		public StringValue? DefaultTask { get; set; }

	}
}