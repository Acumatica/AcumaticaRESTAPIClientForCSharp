using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class CreateProductionDocuments : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: SOOrder__CustomerID</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrder__CustomerLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		public StringValue? CustomerLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SOOrder__CustomerID_BAccountR_acctName</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_descr</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		public StringValue? ItemDescription { get; set; }

		public LongValue? PlanID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PlanType_INPlanType_descr</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		public StringValue? PlanType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMOperationID</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// <para>Display Name: Prod. Operation ID</para>
		/// </summary>
		public StringValue? ProdOperationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMOrderType</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// <para>Display Name: Prod. Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? ProdOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrderQty</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PlanDate</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// <para>Display Name: Requested On</para>
		/// </summary>
		public DateTimeValue? RequestedOn { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMFixedDemand</para>
		/// <para>SQL Type: varchar(MAX)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.CreateProductionOrdersProcess+ProductionOrdersCreateFilter</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}