using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	public class SalesInvoiceDetail : Acumatica.Default_23_200_001.Model.SalesInvoiceDetail
	{

		public StringValue? Account { get; set; }

		public StringValue? ExternalRef { get; set; }

		public BooleanValue? ManualPrice { get; set; }

		public GuidValue? NoteID { get; set; }

		public StringValue? SubAccount { get; set; }

	}
}