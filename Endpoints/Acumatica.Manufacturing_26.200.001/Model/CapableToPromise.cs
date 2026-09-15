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
	/// Corresponds to the screen <c>AM515000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CapableToPromise : Entity, ITopLevelEntity
	{

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CapableToPromiseDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPFilter</para>
		/// </summary>
		[DataMember(Name="ProcessAction", EmitDefaultValue=false)]
		public StringValue? ProcessAction { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DefaultOrderType</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPFilter</para>
		/// </summary>
		[DataMember(Name="RegularProductionOrderType", EmitDefaultValue=false)]
		public StringValue? RegularProductionOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderNbr</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPFilter</para>
		/// </summary>
		[DataMember(Name="SONbr", EmitDefaultValue=false)]
		public StringValue? SONbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrderType</para>
		/// <para>DAC: PX.Objects.AM.CTPProcess+CTPFilter</para>
		/// </summary>
		[DataMember(Name="SOType", EmitDefaultValue=false)]
		public StringValue? SOType { get; set; }

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
			public const string Details = "Details";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}