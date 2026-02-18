using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class DiscountCustomerPriceClassesDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CustomerPriceClassID</para>
		/// <para>DAC: PX.Objects.AR.DiscountCustomerPriceClass</para>
		/// <para>Display Name: Price Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? PriceClassID { get; set; }

	}
}