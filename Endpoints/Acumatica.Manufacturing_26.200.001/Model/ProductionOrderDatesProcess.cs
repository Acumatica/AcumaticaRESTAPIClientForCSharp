using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
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

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Orders = "Orders";

			//Intentionally excluded
			//public const string All = "Files,Translations,Orders";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}