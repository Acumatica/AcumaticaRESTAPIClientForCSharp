using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class PurchaseReceiptDetail : Acumatica.Default_24_200_001.Model.PurchaseReceiptDetail
	{

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.PO.POReceipt</para>
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

	}
}