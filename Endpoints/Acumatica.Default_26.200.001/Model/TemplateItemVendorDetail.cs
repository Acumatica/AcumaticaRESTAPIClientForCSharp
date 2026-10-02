using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class TemplateItemVendorDetail : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		public BooleanValue? Default { get; set; }

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

		public IntValue? RecordID { get; set; }

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