using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class DiscountCode : Acumatica.Default_22_200_001.Model.DiscountCode, ITopLevelEntity
	{

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}