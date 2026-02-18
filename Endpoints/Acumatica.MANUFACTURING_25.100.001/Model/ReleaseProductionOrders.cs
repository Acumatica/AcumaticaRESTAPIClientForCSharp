using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM500000</c> in the Acumatica ERP
	/// <para>Key Fields: OrderType, ProductionNbr</para>
	/// </summary>
	public class ReleaseProductionOrders : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_descr</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Order Date</para>
		/// </summary>
		public DateTimeValue? OrderDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// Key Field
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// Selected Project fot the Production Order
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtytoProd</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Qty. to Produce</para>
		/// </summary>
		public DecimalValue? QtytoProduce { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrdNbr</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Sales Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrdTypeRef</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Sales Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// Indicates where the production detail source comes from.
		/// <para>DAC Field Name: DetailSource</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Source { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteId</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}