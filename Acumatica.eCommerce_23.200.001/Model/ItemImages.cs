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
	/// Corresponds to the screen BC408020 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ItemImages : Entity, ITopLevelEntity
	{

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<ItemImageDetails>? Results { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}