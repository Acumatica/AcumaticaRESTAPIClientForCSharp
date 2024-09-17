using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class ConfigurationEntryAttributes : Entity
	{

		[DataMember(Name="AttributeLineNbr", EmitDefaultValue=false)]
		public IntValue? AttributeLineNbr { get; set; }

		[DataMember(Name="ConfigResultsID", EmitDefaultValue=false)]
		public IntValue? ConfigResultsID { get; set; }

		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}