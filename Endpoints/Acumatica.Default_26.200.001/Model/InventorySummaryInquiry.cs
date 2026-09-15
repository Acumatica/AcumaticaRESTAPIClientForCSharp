using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN401000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class InventorySummaryInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Expand by Lot/Serial Numbers</para>
		/// </summary>
		[DataMember(Name="ExpandByLotSerialNbr", EmitDefaultValue=false)]
		public BooleanValue? ExpandByLotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<InventorySummaryRow>? Results { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

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
			public const string Results = "Results";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}