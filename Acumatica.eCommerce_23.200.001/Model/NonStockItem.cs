using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN202000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class NonStockItem : Acumatica.Default_23_200_001.Model.NonStockItem, ITopLevelEntity
	{

		[DataMember(Name="IsAKit", EmitDefaultValue=false)]
		public BooleanValue? IsAKit { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}