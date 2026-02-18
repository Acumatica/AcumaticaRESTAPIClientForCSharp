using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM312000</c> in the Acumatica ERP
	/// <para>Key Fields: LotSerialNbr, OrderType, ProductionNbr</para>
	/// </summary>
	public class LateAssignment : Entity, ITopLevelEntity
	{

		public List<LateAssignmentAllocatedDetail>? AllocatedDetail { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyComplete</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Complete Qty.</para>
		/// </summary>
		public DecimalValue? CompleteQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// Key Field
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

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
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Qty. to Produce</para>
		/// </summary>
		public DecimalValue? QtytoProduce { get; set; }

		/// <summary>
		/// Quantity remaining to be completed on the production order
		/// <para>DAC Field Name: QtyRemaining</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Remaining Qty.</para>
		/// </summary>
		public DecimalValue? RemainingQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyScrapped</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>Display Name: Scrapped Qty.</para>
		/// </summary>
		public DecimalValue? ScrappedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StatusID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public List<LateAssignmentUnallocatedDetail>? UnallocatedDetail { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteId</para>
		/// <para>DAC: PX.Objects.AM.AMProdItemSplitPreassign</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string AllocatedDetail = "AllocatedDetail";
			public const string AllocatedDetail_Files = "AllocatedDetail/Files";
			public const string UnallocatedDetail = "UnallocatedDetail";
			public const string UnallocatedDetail_Files = "UnallocatedDetail/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,AllocatedDetail,AllocatedDetail/Files,UnallocatedDetail,UnallocatedDetail/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}