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
	/// Corresponds to the screen <c>AM501000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class RoughCutPlanning : Entity, ITopLevelEntity
	{

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<RoughCutPlanningDetail>? Detail { get; set; }

		/// <summary>
		/// Show/hide orders which are schedule status Firm
		/// <para>DAC: PX.Objects.AM.APSRoughCutProcessFilter</para>
		/// <para>Display Name: Exclude Firm Orders</para>
		/// </summary>
		[DataMember(Name="ExcludeFirmOrders", EmitDefaultValue=false)]
		public BooleanValue? ExcludeFirmOrders { get; set; }

		/// <summary>
		/// Show/hide planning type orders
		/// <para>DAC: PX.Objects.AM.APSRoughCutProcessFilter</para>
		/// <para>Display Name: Exclude Planning Orders</para>
		/// </summary>
		[DataMember(Name="ExcludePlanningOrders", EmitDefaultValue=false)]
		public BooleanValue? ExcludePlanningOrders { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.APSRoughCutProcessFilter</para>
		/// <para>Display Name: Action</para>
		/// <para>SQL Type: nchar(1)</para>
		/// </summary>
		[DataMember(Name="ProcessAction", EmitDefaultValue=false)]
		public StringValue? ProcessAction { get; set; }

		/// <summary>
		/// During processing, should the selected orders be released (true)
		/// <para>DAC: PX.Objects.AM.APSRoughCutProcessFilter</para>
		/// <para>Display Name: Release Orders</para>
		/// </summary>
		[DataMember(Name="ReleaseOrders", EmitDefaultValue=false)]
		public BooleanValue? ReleaseOrders { get; set; }

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
			public const string Detail = "Detail";

			//Intentionally excluded
			//public const string All = "Files,Translations,Detail";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}