using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class NonStockItemVendorDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Vendor ID</para>
		/// </summary>
		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Vendor__AcctName</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

	}
}