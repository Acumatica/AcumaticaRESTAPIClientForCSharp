using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class CaseContact : Entity
	{

		#region Fields
		public StringValue? Email { get; set; }

		public StringValue? FirstName { get; set; }

		#endregion

	}
}