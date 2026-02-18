using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>BC201000</c> in the Acumatica ERP
	/// <para>Key Fields: Connector, StoreName</para>
	/// </summary>
	public class BigCommerceStores : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The access token of the BigCommerce store.
		/// <para>DAC Field Name: StoreXAuthToken</para>
		/// <para>DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce</para>
		/// <para>Display Name: Access Token</para>
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
		/// The base URL of the BigCommerce store.
		/// <para>DAC Field Name: StoreBaseURL</para>
		/// <para>DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce</para>
		/// <para>Display Name: API Path</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? APIPath { get; set; }

		/// <summary>
		/// The client ID of the BigCommerce store.
		/// <para>DAC Field Name: StoreXAuthClient</para>
		/// <para>DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce</para>
		/// <para>Display Name: Client ID</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? ClientID { get; set; }

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
		/// The admin URL of the BigCommerce store.
		/// <para>DAC Field Name: StoreAdminUrl</para>
		/// <para>DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce</para>
		/// <para>Display Name: Store Admin URL</para>
		/// <para>SQL Type: nvarchar(200)</para>
		/// </summary>
		public StringValue? StoreAdminPath { get; set; }

		/// <summary>
		/// A user-friendly name of the store.
		/// <para>DAC Field Name: BindingName</para>
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// <para>Display Name: Store Name</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? StoreName { get; set; }

		/// <summary>
		/// The password for the DAV server of the BigCommerce store.
		/// <para>DAC Field Name: StoreWDAVClientPass</para>
		/// <para>DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce</para>
		/// <para>Display Name: WebDAV Password</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? WebDAVPassword { get; set; }

		/// <summary>
		/// The URL of the DAV server of the BigCommerce store.
		/// <para>DAC Field Name: StoreWDAVServerUrl</para>
		/// <para>DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce</para>
		/// <para>Display Name: WebDAV Path</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? WebDAVPath { get; set; }

		/// <summary>
		/// The username for the DAV server of the BigCommerce store.
		/// <para>DAC Field Name: StoreWDAVClientUser</para>
		/// <para>DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce</para>
		/// <para>Display Name: WebDAV Username</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? WebDAVUsername { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}