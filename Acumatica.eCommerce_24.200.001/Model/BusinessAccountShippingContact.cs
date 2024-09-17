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
	public class BusinessAccountShippingContact : Entity
	{

		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue? Fax { get; set; }

		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue? JobTitle { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

	}
}