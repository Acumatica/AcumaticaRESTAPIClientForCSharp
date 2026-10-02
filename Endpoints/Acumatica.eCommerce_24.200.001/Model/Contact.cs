using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR302000</c> in the Acumatica ERP
	/// </summary>
	public class Contact : Acumatica.Default_24_200_001.Model.Contact, ITopLevelEntity
	{

		#region Fields
		public StringValue? ExtUserRole { get; set; }

		#endregion

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}