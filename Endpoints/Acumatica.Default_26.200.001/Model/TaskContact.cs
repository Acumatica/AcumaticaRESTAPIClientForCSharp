using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class TaskContact : Entity
	{

		#region Fields
		public StringValue? DisplayName { get; set; }

		public StringValue? Email { get; set; }

		public StringValue? Phone1 { get; set; }

		#endregion

	}
}