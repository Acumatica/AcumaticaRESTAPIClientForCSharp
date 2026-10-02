using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	public class TransferOrderDetail : Acumatica.Default_24_200_001.Model.TransferOrderDetail
	{

		#region Fields
		public IntValue? OrderLineNbr { get; set; }

		public StringValue? OrderNumber { get; set; }

		public StringValue? OrderType { get; set; }

		public DecimalValue? RecivedQty { get; set; }

		public StringValue? ShipmentNumber { get; set; }

		#endregion

	}
}