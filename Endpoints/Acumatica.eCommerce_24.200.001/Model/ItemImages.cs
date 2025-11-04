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
	/// Corresponds to the screen BC408020 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ItemImages : Entity, ITopLevelEntity
	{

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<ItemImageDetails>? Results { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}