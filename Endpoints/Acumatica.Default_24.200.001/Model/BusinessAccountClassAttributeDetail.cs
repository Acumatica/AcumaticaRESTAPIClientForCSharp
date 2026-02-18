using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class BusinessAccountClassAttributeDetail : Entity
	{

		public BooleanValue? Active { get; set; }

		public StringValue? AttributeID { get; set; }

		public StringValue? DefaultValue { get; set; }

		public StringValue? Description { get; set; }

		public BooleanValue? Required { get; set; }

		public ShortValue? SortOrder { get; set; }

	}
}