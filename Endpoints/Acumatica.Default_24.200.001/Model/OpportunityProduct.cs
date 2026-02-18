using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class OpportunityProduct : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryAmount</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// <para>Display Name: Detail Total</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscPct</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Discount, %</para>
		/// </summary>
		public DecimalValue? Discount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscAmt</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Discount Amount</para>
		/// </summary>
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Discount Code</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountSequenceID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Discount Sequence</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? DiscountSequence { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExtPrice</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Ext. Price</para>
		/// </summary>
		public DecimalValue? ExternalPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsFree</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Free Item</para>
		/// </summary>
		public BooleanValue? FreeItem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ManualDisc</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Manual Discount</para>
		/// </summary>
		public BooleanValue? ManualDiscount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineNbr</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? OpportunityProductID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Quantity</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? TransactionDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnitPrice</para>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Unit Price</para>
		/// </summary>
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.CR.CROpportunity</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// Indicates (if selected) that the automatic line discounts are not applied to this line.
		/// <para>DAC: PX.Objects.CR.CROpportunityProducts</para>
		/// <para>Display Name: Ignore Automatic Line Discounts</para>
		/// </summary>
		public BooleanValue? SkipLineDiscounts { get; set; }

	}
}