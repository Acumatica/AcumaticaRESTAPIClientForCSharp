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
	/// Corresponds to the screen <c>BC201020</c> in the Acumatica ERP
	/// <para>Key Fields: BindingName</para>
	/// </summary>
	[DataContract]
	public class AmazonStore : Entity, ITopLevelEntity
	{

		/// <summary>
		/// A user-friendly name of the store.
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// <para>Display Name: Store Name</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BindingName", EmitDefaultValue=false)]
		public StringValue? BindingName { get; set; }

		/// <summary>
		/// The name of the locale for this binding.
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// <para>Display Name: Locale</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="LocaleName", EmitDefaultValue=false)]
		public StringValue? LocaleName { get; set; }

		/// <summary>
		/// Marketplace where selling partners authorizes the application            
		/// <para>DAC: PX.Commerce.Amazon.BCBindingAmazon</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="Marketplace", EmitDefaultValue=false)]
		public StringValue? Marketplace { get; set; }

		[DataMember(Name="RefreshToken", EmitDefaultValue=false)]
		public StringValue? RefreshToken { get; set; }

		/// <summary>
		/// AWS region
		/// <para>DAC: PX.Commerce.Amazon.BCBindingAmazon</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="Region", EmitDefaultValue=false)]
		public StringValue? Region { get; set; }

		/// <summary>
		/// The identifier of the selling partner who is authorizing your application.
		/// <para>DAC: PX.Commerce.Amazon.BCBindingAmazon</para>
		/// <para>Display Name: Seller Partner ID</para>
		/// <para>SQL Type: nvarchar(14)</para>
		/// </summary>
		[DataMember(Name="SellerPartnerId", EmitDefaultValue=false)]
		public StringValue? SellerPartnerId { get; set; }

		/// <summary>
		/// Determines whether the store is accessible through other Commerce forms.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Determines whether the store will be chosen as default through other Commerce screens.
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Commerce.Core.BCBinding</para>
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}