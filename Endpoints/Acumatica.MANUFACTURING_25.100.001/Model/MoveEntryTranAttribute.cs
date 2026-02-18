using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class MoveEntryTranAttribute : Entity
	{

		public StringValue? Attribute { get; set; }

		public StringValue? AttributeID { get; set; }

		public StringValue? Description { get; set; }

		public IntValue? ProdAttributeLineNbr { get; set; }

		public BooleanValue? Required { get; set; }

		public IntValue? TranLineNbr { get; set; }

		public StringValue? Value { get; set; }

	}
}