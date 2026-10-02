using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class AssignTagsParameters
	{
		public AssignTagsParameters() { }


		public StringValue? FileIDs { get; set; }

		public StringValue? Tags { get; set; }
	}
}