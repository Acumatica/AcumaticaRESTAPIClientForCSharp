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
	public class SalesOrderPayment : Acumatica.Default_24_200_001.Model.SalesOrderPayment
	{

		[DataMember(Name="NewCard", EmitDefaultValue=false)]
		public BooleanValue? NewCard { get; set; }

		[DataMember(Name="PaymentNoteID", EmitDefaultValue=false)]
		public GuidValue? PaymentNoteID { get; set; }

	}
}