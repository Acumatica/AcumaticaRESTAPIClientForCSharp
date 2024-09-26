using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen BC201010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ShopifyStore : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShopifyAccessToken 
		/// DAC: PX.Commerce.Shopify.BCBindingShopify 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccessToken", EmitDefaultValue=false)]
		public StringValue? AccessToken { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ConnectorType 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Connector", EmitDefaultValue=false)]
		public StringValue? Connector { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StoreSharedSecret 
		/// DAC: PX.Commerce.Shopify.BCBindingShopify 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SharedSecret", EmitDefaultValue=false)]
		public StringValue? SharedSecret { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShopifyApiBaseUrl 
		/// DAC: PX.Commerce.Shopify.BCBindingShopify 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StoreAdminURL", EmitDefaultValue=false)]
		public StringValue? StoreAdminURL { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BindingName 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StoreName", EmitDefaultValue=false)]
		public StringValue? StoreName { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}