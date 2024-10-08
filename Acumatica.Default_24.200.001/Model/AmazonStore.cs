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
	/// Corresponds to the screen BC201020 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class AmazonStore : Entity, ITopLevelEntity
	{

		/// <summary>
		/// A user-friendly name of the store.
		/// DAC: PX.Commerce.Core.BCBinding 
		/// Display Name: Store Name 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BindingName", EmitDefaultValue=false)]
		public StringValue? BindingName { get; set; }

		/// <summary>
		/// The name of the locale for this binding.
		/// DAC: PX.Commerce.Core.BCBinding 
		/// Display Name: Locale 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="LocaleName", EmitDefaultValue=false)]
		public StringValue? LocaleName { get; set; }

		/// <summary>
		/// Marketplace where selling partners authorizes the application            
		/// DAC: PX.Commerce.Amazon.BCBindingAmazon 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="Marketplace", EmitDefaultValue=false)]
		public StringValue? Marketplace { get; set; }

		[DataMember(Name="RefreshToken", EmitDefaultValue=false)]
		public StringValue? RefreshToken { get; set; }

		/// <summary>
		/// AWS region
		/// DAC: PX.Commerce.Amazon.BCBindingAmazon 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="Region", EmitDefaultValue=false)]
		public StringValue? Region { get; set; }

		/// <summary>
		/// The identifier of the selling partner who is authorizing your application.
		/// DAC: PX.Commerce.Amazon.BCBindingAmazon 
		/// Display Name: Seller Partner ID 
		/// SQL Type: nvarchar(14) 
		/// </summary>
		[DataMember(Name="SellerPartnerId", EmitDefaultValue=false)]
		public StringValue? SellerPartnerId { get; set; }

		/// <summary>
		/// Determines whether the store is accessible through other Commerce forms.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Determines whether the store will be chosen as default through other Commerce screens.
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}