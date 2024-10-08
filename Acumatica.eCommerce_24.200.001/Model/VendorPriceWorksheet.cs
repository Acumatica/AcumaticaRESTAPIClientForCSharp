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
	public class VendorPriceWorksheet : Acumatica.Default_24_200_001.Model.VendorPriceWorksheet, ITopLevelEntity
	{

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}