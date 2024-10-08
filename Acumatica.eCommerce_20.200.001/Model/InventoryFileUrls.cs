using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class InventoryFileUrls : Entity
	{

		[DataMember(Name="FileType", EmitDefaultValue=false)]
		public StringValue? FileType { get; set; }

		[DataMember(Name="FileURL", EmitDefaultValue=false)]
		public StringValue? FileURL { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

	}
}