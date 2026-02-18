using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class DiscountItemDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: InventoryItem__Descr</para>
		/// <para>DAC: PX.Objects.AR.DiscountItem</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.DiscountItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// Key Field
		/// </summary>
		public StringValue? InventoryID { get; set; }

	}
}