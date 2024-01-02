using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class ConvertLeadToBAccountParameters
	{
		public ConvertLeadToBAccountParameters() { }

		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue AccountClass { get; set; }
		[DataMember(Name="AccountName", EmitDefaultValue=false)]
		public StringValue AccountName { get; set; }
		[DataMember(Name="BAccountID", EmitDefaultValue=false)]
		public StringValue BAccountID { get; set; }
		public virtual string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}
	}
}