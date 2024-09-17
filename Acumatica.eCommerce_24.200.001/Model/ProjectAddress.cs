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
	public class ProjectAddress : Entity
	{

		[DataMember(Name="AddressLine1", EmitDefaultValue=false)]
		public StringValue? AddressLine1 { get; set; }

		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		[DataMember(Name="PostalCode", EmitDefaultValue=false)]
		public StringValue? PostalCode { get; set; }

		[DataMember(Name="Latitude", EmitDefaultValue=false)]
		public DecimalValue? Latitude { get; set; }

		[DataMember(Name="Longitude", EmitDefaultValue=false)]
		public DecimalValue? Longitude { get; set; }

	}
}