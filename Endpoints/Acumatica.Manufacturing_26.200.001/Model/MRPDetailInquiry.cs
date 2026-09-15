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
	/// Corresponds to the screen <c>AM404000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MRPDetailInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// U o m
		/// <para>DAC Field Name: UOM</para>
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Base Unit</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="BaseUnit", EmitDefaultValue=false)]
		public StringValue? BaseUnit { get; set; }

		[DataMember(Name="DaysOfSupply", EmitDefaultValue=false)]
		public IntValue? DaysOfSupply { get; set; }

		[DataMember(Name="EOQ", EmitDefaultValue=false)]
		public DecimalValue? EOQ { get; set; }

		/// <summary>
		/// Inventory ID
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="LotMultiple", EmitDefaultValue=false)]
		public DecimalValue? LotMultiple { get; set; }

		/// <summary>
		/// Lot qty
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Lot Qty.</para>
		/// </summary>
		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public DecimalValue? LotQty { get; set; }

		[DataMember(Name="ManufacturingEOQ", EmitDefaultValue=false)]
		public DecimalValue? ManufacturingEOQ { get; set; }

		[DataMember(Name="MaxLotSize", EmitDefaultValue=false)]
		public DecimalValue? MaxLotSize { get; set; }

		/// <summary>
		/// Max order qty
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Max. Order Qty.</para>
		/// </summary>
		[DataMember(Name="MaxOrderQty", EmitDefaultValue=false)]
		public DecimalValue? MaxOrderQty { get; set; }

		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue? MaxQty { get; set; }

		[DataMember(Name="MinLotSize", EmitDefaultValue=false)]
		public DecimalValue? MinLotSize { get; set; }

		/// <summary>
		/// Min order qty
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Min. Order Qty.</para>
		/// </summary>
		[DataMember(Name="MinOrderQty", EmitDefaultValue=false)]
		public DecimalValue? MinOrderQty { get; set; }

		/// <summary>
		/// Qty on hand
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Qty. On Hand</para>
		/// </summary>
		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

		[DataMember(Name="ReorderPoint", EmitDefaultValue=false)]
		public DecimalValue? ReorderPoint { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<MRPDetailInquiryResult>? Results { get; set; }

		/// <summary>
		/// Safety stock
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// <para>Display Name: Safety Stock</para>
		/// </summary>
		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// Sub item ID
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		[DataMember(Name="TransferERQ", EmitDefaultValue=false)]
		public DecimalValue? TransferERQ { get; set; }

		/// <summary>
		/// Warehouse
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.InvLookup</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

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
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}