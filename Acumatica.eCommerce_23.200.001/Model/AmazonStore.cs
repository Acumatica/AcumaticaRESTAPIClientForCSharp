using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen BC201020 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class AmazonStore : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BindingName 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BindingName", EmitDefaultValue=false)]
		public StringValue? BindingName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LocaleName 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LocaleName", EmitDefaultValue=false)]
		public StringValue? LocaleName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Marketplace 
		/// DAC: PX.Commerce.Amazon.BCBindingAmazon 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Marketplace", EmitDefaultValue=false)]
		public StringValue? Marketplace { get; set; }

		[DataMember(Name="RefreshToken", EmitDefaultValue=false)]
		public StringValue? RefreshToken { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Region 
		/// DAC: PX.Commerce.Amazon.BCBindingAmazon 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Region", EmitDefaultValue=false)]
		public StringValue? Region { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SellerPartnerId 
		/// DAC: PX.Commerce.Amazon.BCBindingAmazon 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SellerPartnerId", EmitDefaultValue=false)]
		public StringValue? SellerPartnerId { get; set; }

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
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Commerce.Core.BCBinding 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}