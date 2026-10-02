using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM312000</c> in the Acumatica ERP
	/// <para>Key Fields: OrderType, ProductionNbr, LotSerialNbr</para>
	/// </summary>
	public class LateAssignment : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// Key Field
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// Key Field
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StatusID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteId</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Qty. to Produce</para>
		/// </summary>
		public DecimalValue? QtytoProduce { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyComplete</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Complete Qty.</para>
		/// </summary>
		public DecimalValue? CompleteQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyScrapped</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Scrapped Qty.</para>
		/// </summary>
		public DecimalValue? ScrappedQty { get; set; }

		/// <summary>
		/// Quantity remaining to be completed on the production order
		/// <para>DAC Field Name: QtyRemaining</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Remaining Qty.</para>
		/// </summary>
		public DecimalValue? RemainingQty { get; set; }

		#endregion

		#region Details
		public List<LateAssignmentAllocatedDetail>? AllocatedDetail { get; set; }

		public List<LateAssignmentUnallocatedDetail>? UnallocatedDetail { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(LateAssignment)} - \"{OrderType}\" - \"{ProductionNbr}\" - \"{LotSerialNbr}\"";
		}

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
			public const string AllocatedDetail = "AllocatedDetail";
			public const string UnallocatedDetail = "UnallocatedDetail";

			//Intentionally excluded
			//public const string All = "Files,Translations,AllocatedDetail,UnallocatedDetail";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}