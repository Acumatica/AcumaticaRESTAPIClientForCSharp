using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ItemSalesCategoryMember : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: InventoryItem__Descr</para>
		/// <para>DAC: PX.Objects.IN.INItemCategory</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemCategory</para>
		/// <para>Display Name: Inventory ID</para>
		/// Key Field
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryItem__ItemClassID</para>
		/// <para>DAC: PX.Objects.IN.INItemCategory</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryItem__ItemStatus</para>
		/// <para>DAC: PX.Objects.IN.INItemCategory</para>
		/// </summary>
		public StringValue? ItemStatus { get; set; }

	}
}