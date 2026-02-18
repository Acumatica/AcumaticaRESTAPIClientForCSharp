using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class WCCCodeProjectSource : Entity
	{

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public IntValue? LineNbr { get; set; }

		public StringValue? Project { get; set; }

		public StringValue? ProjectTask { get; set; }

		public StringValue? WorkCodeID { get; set; }

	}
}