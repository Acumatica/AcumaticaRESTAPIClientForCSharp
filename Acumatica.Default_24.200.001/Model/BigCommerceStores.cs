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
	/// Corresponds to the screen BC201000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BigCommerceStores : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StoreXAuthToken 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
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
		/// DAC Field Name: StoreBaseURL 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="APIPath", EmitDefaultValue=false)]
		public StringValue? APIPath { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StoreXAuthClient 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ClientID", EmitDefaultValue=false)]
		public StringValue? ClientID { get; set; }

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
		/// DAC Field Name: StoreAdminUrl 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StoreAdminPath", EmitDefaultValue=false)]
		public StringValue? StoreAdminPath { get; set; }

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

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StoreWDAVClientPass 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WebDAVPassword", EmitDefaultValue=false)]
		public StringValue? WebDAVPassword { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StoreWDAVServerUrl 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WebDAVPath", EmitDefaultValue=false)]
		public StringValue? WebDAVPath { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StoreWDAVClientUser 
		/// DAC: PX.Commerce.BigCommerce.BCBindingBigCommerce 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WebDAVUsername", EmitDefaultValue=false)]
		public StringValue? WebDAVUsername { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}