using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class AttributeValue : Entity
	{

		public StringValue? AttributeID { get; set; }

		public StringValue? AttributeDescription { get; set; }

		public BooleanValue? IsActive { get; set; }

		public GuidValue? RefNoteID { get; set; }

		public BooleanValue? Required { get; set; }

		public StringValue? Value { get; set; }

		public StringValue? ValueDescription { get; set; }

	}
}