using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>BC201010</c> in the Acumatica ERP
	/// <para>Key Fields: Connector, StoreName</para>
	/// </summary>
	public class ShopifyStore : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The API access token of the Shopify store.
		/// <para>DAC Field Name: ShopifyAccessToken</para>
		/// <para>DAC: PX.Commerce.Shopify.BCBindingShopify</para>
		/// <para>Display Name: API Access Token</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? AccessToken { get; set; }

		/// <summary>
		/// Determines whether the store is accessible through other Commerce forms.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShopifyApiKey</para>
		/// <para>DAC: PX.Commerce.Shopify.BCBindingShopify</para>
		/// </summary>
		public StringValue? APIKey { get; set; }

		public StringValue? APIPassword { get; set; }

		/// <summary>
		/// Represents a connector to which the store belongs.The property is a key field.
		/// <para>DAC Field Name: ConnectorType</para>
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		public StringValue? Connector { get; set; }

		/// <summary>
		/// Determines whether the store will be chosen as default through other Commerce screens.
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// </summary>
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// The API secret key of the Shopify store.
		/// <para>DAC Field Name: StoreSharedSecret</para>
		/// <para>DAC: PX.Commerce.Shopify.BCBindingShopify</para>
		/// <para>Display Name: API Secret Key</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? SharedSecret { get; set; }

		/// <summary>
		/// The admin URL of the Shopify store.
		/// <para>DAC Field Name: ShopifyApiBaseUrl</para>
		/// <para>DAC: PX.Commerce.Shopify.BCBindingShopify</para>
		/// <para>Display Name: Store Admin URL</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? StoreAdminURL { get; set; }

		/// <summary>
		/// A user-friendly name of the store.
		/// <para>DAC Field Name: BindingName</para>
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// <para>Display Name: Store Name</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? StoreName { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}