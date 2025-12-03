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
	public class DiscountCustomerDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountCustomer</para>
		/// <para>Display Name: Customer</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Customer__AcctName</para>
		/// <para>DAC: PX.Objects.AR.DiscountCustomer</para>
		/// </summary>
		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

	}
}