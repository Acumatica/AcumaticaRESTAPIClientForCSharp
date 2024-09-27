using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen BC201000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BigCommerceStores : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The access token of the BigCommerce store.
		/// DAC Field Name: StoreXAuthToken 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// Display Name: Access Token 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="AccessToken", EmitDefaultValue=false)]
		public StringValue? AccessToken { get; set; }

		/// <summary>
		/// Determines whether the store is accessible through other Commerce forms.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The base URL of the BigCommerce store.
		/// DAC Field Name: StoreBaseURL 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// Display Name: API Path 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="APIPath", EmitDefaultValue=false)]
		public StringValue? APIPath { get; set; }

		/// <summary>
		/// The client ID of the BigCommerce store.
		/// DAC Field Name: StoreXAuthClient 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// Display Name: Client ID 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="ClientID", EmitDefaultValue=false)]
		public StringValue? ClientID { get; set; }

		/// <summary>
		/// Represents a connector to which the store belongs.The property is a key field.
		/// DAC Field Name: ConnectorType 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Connector", EmitDefaultValue=false)]
		public StringValue? Connector { get; set; }

		/// <summary>
		/// Determines whether the store will be chosen as default through other Commerce screens.
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// The admin URL of the BigCommerce store.
		/// DAC Field Name: StoreAdminUrl 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// Display Name: Store Admin URL 
		/// SQL Type: nvarchar(200) 
		/// </summary>
		[DataMember(Name="StoreAdminPath", EmitDefaultValue=false)]
		public StringValue? StoreAdminPath { get; set; }

		/// <summary>
		/// A user-friendly name of the store.
		/// DAC Field Name: BindingName 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// Display Name: Store Name 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="StoreName", EmitDefaultValue=false)]
		public StringValue? StoreName { get; set; }

		/// <summary>
		/// The password for the DAV server of the BigCommerce store.
		/// DAC Field Name: StoreWDAVClientPass 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// Display Name: WebDAV Password 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="WebDAVPassword", EmitDefaultValue=false)]
		public StringValue? WebDAVPassword { get; set; }

		/// <summary>
		/// The URL of the DAV server of the BigCommerce store.
		/// DAC Field Name: StoreWDAVServerUrl 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// Display Name: WebDAV Path 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="WebDAVPath", EmitDefaultValue=false)]
		public StringValue? WebDAVPath { get; set; }

		/// <summary>
		/// The username for the DAV server of the BigCommerce store.
		/// DAC Field Name: StoreWDAVClientUser 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// Display Name: WebDAV Username 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="WebDAVUsername", EmitDefaultValue=false)]
		public StringValue? WebDAVUsername { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}