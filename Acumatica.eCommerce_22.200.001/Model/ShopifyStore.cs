using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class ShopifyStore : Entity, ITopLevelEntity
	{

		[DataMember(Name="AccessToken", EmitDefaultValue=false)]
		public StringValue? AccessToken { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="APIKey", EmitDefaultValue=false)]
		public StringValue? APIKey { get; set; }

		[DataMember(Name="APIPassword", EmitDefaultValue=false)]
		public StringValue? APIPassword { get; set; }

		[DataMember(Name="Connector", EmitDefaultValue=false)]
		public StringValue? Connector { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		[DataMember(Name="SharedSecret", EmitDefaultValue=false)]
		public StringValue? SharedSecret { get; set; }

		[DataMember(Name="StoreAdminURL", EmitDefaultValue=false)]
		public StringValue? StoreAdminURL { get; set; }

		[DataMember(Name="StoreName", EmitDefaultValue=false)]
		public StringValue? StoreName { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}