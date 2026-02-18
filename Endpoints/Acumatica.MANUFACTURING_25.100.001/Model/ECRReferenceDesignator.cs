using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class ECRReferenceDesignator : Entity
	{

		public StringValue? ChangeStatus { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? ECRID { get; set; }

		public IntValue? LineID { get; set; }

		public IntValue? MaterialLineID { get; set; }

		public StringValue? OperationID { get; set; }

		public StringValue? RefDes { get; set; }

		public StringValue? Revision { get; set; }

	}
}