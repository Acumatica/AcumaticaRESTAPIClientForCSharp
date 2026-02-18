using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class InventoryQuantityAvailableDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: INSiteStatusQtyAggregated_inventoryID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatusQtyAggregated_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatusQtyAggregated_qtyAvail</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyAvailable { get; set; }

	}
}