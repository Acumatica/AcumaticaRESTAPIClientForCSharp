using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class BOMReferenceDesignator : Entity
	{

		public StringValue? Description { get; set; }

		public IntValue? LineID { get; set; }

		public IntValue? MaterialLineID { get; set; }

		public StringValue? RefDes { get; set; }

	}
}