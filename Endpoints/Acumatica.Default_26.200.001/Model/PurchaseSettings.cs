using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class PurchaseSettings : Entity
	{

		#region Fields
		public StringValue? POSiteID { get; set; }

		public StringValue? POSource { get; set; }

		public StringValue? VendorID { get; set; }

		#endregion

	}
}