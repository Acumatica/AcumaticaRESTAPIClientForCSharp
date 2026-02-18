using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class NonStockItemVendorDetail : Entity
	{

		public IntValue? RecordID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Vendor ID</para>
		/// </summary>
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Vendor__AcctName</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		public BooleanValue? Default { get; set; }

	}
}