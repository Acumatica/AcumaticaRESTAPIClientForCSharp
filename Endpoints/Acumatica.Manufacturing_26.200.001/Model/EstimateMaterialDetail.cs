using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	[DataContract]
	public class EstimateMaterialDetail : Entity
	{

		/// <summary>
		/// Determine whether user need to release material manually or not 
		/// <para>DAC Field Name: BackFlush</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Backflush Materials</para>
		/// </summary>
		[DataMember(Name="Backflush", EmitDefaultValue=false)]
		public BooleanValue? Backflush { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Batch Size</para>
		/// </summary>
		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemDesc</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryCD</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Inventory ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="LineOrder", EmitDefaultValue=false)]
		public IntValue? LineOrder { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Material Type</para>
		/// </summary>
		[DataMember(Name="MaterialType", EmitDefaultValue=false)]
		public StringValue? MaterialType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsNonInventory</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Non-Inventory</para>
		/// </summary>
		[DataMember(Name="NonInventory", EmitDefaultValue=false)]
		public BooleanValue? NonInventory { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Phantom Routing</para>
		/// </summary>
		[DataMember(Name="PhantomRouting", EmitDefaultValue=false)]
		public StringValue? PhantomRouting { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyReq</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Required Qty.</para>
		/// </summary>
		[DataMember(Name="QtyRequired", EmitDefaultValue=false)]
		public DecimalValue? QtyRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Round Qty. Up</para>
		/// </summary>
		[DataMember(Name="QtyRoundUp", EmitDefaultValue=false)]
		public BooleanValue? QtyRoundUp { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Scrap Factor</para>
		/// </summary>
		[DataMember(Name="ScrapFactor", EmitDefaultValue=false)]
		public DecimalValue? ScrapFactor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Subcontract Source</para>
		/// </summary>
		[DataMember(Name="SubcontractSource", EmitDefaultValue=false)]
		public StringValue? SubcontractSource { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MaterialOperCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Total Cost</para>
		/// </summary>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalQtyRequired</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Total Required</para>
		/// </summary>
		[DataMember(Name="TotalRequired", EmitDefaultValue=false)]
		public DecimalValue? TotalRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateMatl</para>
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

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}