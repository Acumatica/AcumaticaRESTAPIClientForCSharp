using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class DiscountCustomerDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountCustomer</para>
		/// <para>Display Name: Customer</para>
		/// Key Field
		/// </summary>
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Customer__AcctName</para>
		/// <para>DAC: PX.Objects.AR.DiscountCustomer</para>
		/// </summary>
		public StringValue? CustomerName { get; set; }

	}
}