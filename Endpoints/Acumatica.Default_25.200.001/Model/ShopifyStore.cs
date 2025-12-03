using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>BC201010</c> in the Acumatica ERP
	/// <para>Key Fields: Connector, StoreName</para>
	/// </summary>
	[DataContract]
	public class ShopifyStore : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The API access token of the Shopify store.
		/// <para>DAC Field Name: ShopifyAccessToken</para>
		/// <para>DAC: PX.Commerce.Shopify.BCBindingShopify</para>
		/// <para>Display Name: API Access Token</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="AccessToken", EmitDefaultValue=false)]
		public StringValue? AccessToken { get; set; }

		/// <summary>
		/// Determines whether the store is accessible through other Commerce forms.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Represents a connector to which the store belongs.The property is a key field.
		/// <para>DAC Field Name: ConnectorType</para>
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Connector", EmitDefaultValue=false)]
		public StringValue? Connector { get; set; }

		/// <summary>
		/// Determines whether the store will be chosen as default through other Commerce screens.
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// The API secret key of the Shopify store.
		/// <para>DAC Field Name: StoreSharedSecret</para>
		/// <para>DAC: PX.Commerce.Shopify.BCBindingShopify</para>
		/// <para>Display Name: API Secret Key</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="SharedSecret", EmitDefaultValue=false)]
		public StringValue? SharedSecret { get; set; }

		/// <summary>
		/// The admin URL of the Shopify store.
		/// <para>DAC Field Name: ShopifyApiBaseUrl</para>
		/// <para>DAC: PX.Commerce.Shopify.BCBindingShopify</para>
		/// <para>Display Name: Store Admin URL</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="StoreAdminURL", EmitDefaultValue=false)]
		public StringValue? StoreAdminURL { get; set; }

		/// <summary>
		/// A user-friendly name of the store.
		/// <para>DAC Field Name: BindingName</para>
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// <para>Display Name: Store Name</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="StoreName", EmitDefaultValue=false)]
		public StringValue? StoreName { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}