using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class SettingsForPR : Entity
	{

		[DataMember(Name="ExportScenario", EmitDefaultValue=false)]
		public StringValue? ExportScenario { get; set; }

		[DataMember(Name="PRProcessing", EmitDefaultValue=false)]
		public StringValue? PRProcessing { get; set; }

		[DataMember(Name="Report", EmitDefaultValue=false)]
		public StringValue? Report { get; set; }

	}
}