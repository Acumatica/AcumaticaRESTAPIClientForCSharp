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
	/// Corresponds to the screen <c>AR303020</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CustomerLocation : Acumatica.Default_24_200_001.Model.CustomerLocation, ITopLevelEntity
	{

		[DataMember(Name="LocationType", EmitDefaultValue=false)]
		public StringValue? LocationType { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}