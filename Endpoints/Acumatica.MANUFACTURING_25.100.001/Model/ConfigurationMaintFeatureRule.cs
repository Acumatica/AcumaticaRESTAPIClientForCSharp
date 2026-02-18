using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class ConfigurationMaintFeatureRule : Entity
	{

		public StringValue? ConfigurationID { get; set; }

		public IntValue? LineNbr { get; set; }

		public StringValue? Revision { get; set; }

		public StringValue? Rule { get; set; }

		public StringValue? RuleSource { get; set; }

		public IntValue? SourceLineNbr { get; set; }

		public StringValue? SourceOption { get; set; }

		public StringValue? TargetFeature { get; set; }

		public StringValue? TargetOption { get; set; }

	}
}