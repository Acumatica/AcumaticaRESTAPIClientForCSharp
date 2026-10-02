using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class OrderDate : Entity
	{

		#region Fields
		public StringValue? Branch { get; set; }

		public StringValue? OrderType { get; set; }

		public StringValue? ProductionNbr { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public DateTimeValue? EndDate { get; set; }

		#endregion

		#region Details
		public List<OrderDateOperationDetail>? Operations { get; set; }

		#endregion

	}
}