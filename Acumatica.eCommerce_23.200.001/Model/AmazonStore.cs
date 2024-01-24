using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class AmazonStore : Entity, ITopLevelEntity
	{

		[DataMember(Name="BindingName", EmitDefaultValue=false)]
		public StringValue? BindingName { get; set; }

		[DataMember(Name="LocaleName", EmitDefaultValue=false)]
		public StringValue? LocaleName { get; set; }

		[DataMember(Name="Marketplace", EmitDefaultValue=false)]
		public StringValue? Marketplace { get; set; }

		[DataMember(Name="RefreshToken", EmitDefaultValue=false)]
		public StringValue? RefreshToken { get; set; }

		[DataMember(Name="Region", EmitDefaultValue=false)]
		public StringValue? Region { get; set; }

		[DataMember(Name="SellerPartnerId", EmitDefaultValue=false)]
		public StringValue? SellerPartnerId { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}