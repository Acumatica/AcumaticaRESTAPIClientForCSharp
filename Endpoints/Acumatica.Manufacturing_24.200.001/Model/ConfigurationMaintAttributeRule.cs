using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class ConfigurationMaintAttributeRule : Entity
	{

		public StringValue? Condition { get; set; }

		public StringValue? ConfigurationID { get; set; }

		public IntValue? LineNbr { get; set; }

		public StringValue? Revision { get; set; }

		public StringValue? Rule { get; set; }

		public StringValue? RuleSource { get; set; }

		public IntValue? SourceLineNbr { get; set; }

		public StringValue? TargetFeature { get; set; }

		public StringValue? TargetOption { get; set; }

		public StringValue? Value1 { get; set; }

		public StringValue? Value2 { get; set; }

	}
}