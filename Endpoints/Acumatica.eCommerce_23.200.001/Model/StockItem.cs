using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN202500</c> in the Acumatica ERP
	/// </summary>
	public class StockItem : Acumatica.Default_23_200_001.Model.StockItem, ITopLevelEntity
	{

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}