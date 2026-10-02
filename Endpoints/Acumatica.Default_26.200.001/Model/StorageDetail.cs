using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class StorageDetail : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: InventoryItem_InventoryCD</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSite_siteCD</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formulac4a8e9dac5ed48729b5908f18d941567</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyOnHand { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formula35008a244cf145b19d8736b1575e86b4</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyAvailable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formula9ec92e4846854af1b90f879c98828563</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyHardAvailable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_Formula7bc6165efc984511a3f7952beb2337e8</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DecimalValue? QtyAvailableforIssue { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatus_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateofWarehouseQty { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}