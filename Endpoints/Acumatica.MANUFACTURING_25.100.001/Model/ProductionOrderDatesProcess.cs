using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM201560</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProductionOrderDatesProcess : Entity, ITopLevelEntity
	{

		[DataMember(Name="Orders", EmitDefaultValue=false)]
		public List<OrderDate>? Orders { get; set; }

		[DataMember(Name="ErrorMessages", EmitDefaultValue=false)]
		public StringValue? ErrorMessages { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Orders = "Orders";
			public const string Orders_Files = "Orders/Files";
			public const string Orders_Operations = "Orders/Operations";
			public const string Orders_Operations_Files = "Orders/Operations/Files";

			//Intentionally excluded
			//public const string All = "Files,Orders,Orders/Files,Orders/Operations,Orders/Operations/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}