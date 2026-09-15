using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR303000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Customer : Acumatica.Default_24_200_001.Model.Customer, ITopLevelEntity
	{

		[DataMember(Name="LegalName", EmitDefaultValue=false)]
		public StringValue? LegalName { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}