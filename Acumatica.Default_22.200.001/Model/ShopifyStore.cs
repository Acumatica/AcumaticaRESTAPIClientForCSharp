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
	/// Corresponds to the screen BC201010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ShopifyStore : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The API access token of the Shopify store.
		/// DAC Field Name: ShopifyAccessToken 
		/// DAC: PX.Commerce.Shopify.BCBindingShopify 
		/// Display Name: API Access Token 
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
		/// DAC Field Name: ShopifyApiKey 
		/// DAC: PX.Commerce.Shopify.BCBindingShopify 
		/// </summary>
		[DataMember(Name="APIKey", EmitDefaultValue=false)]
		public StringValue? APIKey { get; set; }

		[DataMember(Name="APIPassword", EmitDefaultValue=false)]
		public StringValue? APIPassword { get; set; }

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
		/// The API secret key of the Shopify store.
		/// DAC Field Name: StoreSharedSecret 
		/// DAC: PX.Commerce.Shopify.BCBindingShopify 
		/// Display Name: API Secret Key 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="SharedSecret", EmitDefaultValue=false)]
		public StringValue? SharedSecret { get; set; }

		/// <summary>
		/// The admin URL of the Shopify store.
		/// DAC Field Name: ShopifyApiBaseUrl 
		/// DAC: PX.Commerce.Shopify.BCBindingShopify 
		/// Display Name: Store Admin URL 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="StoreAdminURL", EmitDefaultValue=false)]
		public StringValue? StoreAdminURL { get; set; }

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

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}