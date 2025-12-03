using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class DiscountCustomerPriceClassesDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CustomerPriceClassID</para>
		/// <para>DAC: PX.Objects.AR.DiscountCustomerPriceClass</para>
		/// <para>Display Name: Price Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="PriceClassID", EmitDefaultValue=false)]
		public StringValue? PriceClassID { get; set; }

	}
}