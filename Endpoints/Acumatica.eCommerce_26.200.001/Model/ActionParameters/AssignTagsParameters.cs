using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_26_200_001.Model
{
	[DataContract]
	public class AssignTagsParameters
	{
		public AssignTagsParameters() { }

		[DataMember(Name="FileIDs", EmitDefaultValue=false)]
		public StringValue? FileIDs { get; set; }
		[DataMember(Name="Tags", EmitDefaultValue=false)]
		public StringValue? Tags { get; set; }
	}
}