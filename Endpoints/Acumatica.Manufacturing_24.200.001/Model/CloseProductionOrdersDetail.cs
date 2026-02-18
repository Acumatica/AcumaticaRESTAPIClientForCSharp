using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class CloseProductionOrdersDetail : Entity
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
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

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

		public DecimalValue? QtyComplete { get; set; }

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
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteId</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: WIP Balance</para>
		/// </summary>
		public DecimalValue? WIPBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPVarianceAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: WIP Variance Account</para>
		/// </summary>
		public StringValue? WIPVarianceAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPVarianceSubID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: WIP Variance Subaccount</para>
		/// </summary>
		public StringValue? WIPVarianceSubaccount { get; set; }

	}
}