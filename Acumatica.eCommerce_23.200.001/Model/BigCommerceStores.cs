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
	public class BigCommerceStores : Entity, ITopLevelEntity
	{

		[DataMember(Name="AccessToken", EmitDefaultValue=false)]
		public StringValue? AccessToken { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="APIPath", EmitDefaultValue=false)]
		public StringValue? APIPath { get; set; }

		[DataMember(Name="ClientID", EmitDefaultValue=false)]
		public StringValue? ClientID { get; set; }

		[DataMember(Name="Connector", EmitDefaultValue=false)]
		public StringValue? Connector { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		[DataMember(Name="StoreAdminPath", EmitDefaultValue=false)]
		public StringValue? StoreAdminPath { get; set; }

		[DataMember(Name="StoreName", EmitDefaultValue=false)]
		public StringValue? StoreName { get; set; }

		[DataMember(Name="WebDAVPassword", EmitDefaultValue=false)]
		public StringValue? WebDAVPassword { get; set; }

		[DataMember(Name="WebDAVPath", EmitDefaultValue=false)]
		public StringValue? WebDAVPath { get; set; }

		[DataMember(Name="WebDAVUsername", EmitDefaultValue=false)]
		public StringValue? WebDAVUsername { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}