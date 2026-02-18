using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AP202000</c> in the Acumatica ERP
	/// </summary>
	public class VendorPricesInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassCD</para>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// <para>Display Name: Item Class</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// <para>Display Name: Product Manager</para>
		/// </summary>
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkGroupID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// <para>Display Name: Product Workgroup</para>
		/// </summary>
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		public List<VendorPriceDetail>? VendorPriceDetails { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string VendorPriceDetails = "VendorPriceDetails";
			public const string VendorPriceDetails_Files = "VendorPriceDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,VendorPriceDetails,VendorPriceDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}