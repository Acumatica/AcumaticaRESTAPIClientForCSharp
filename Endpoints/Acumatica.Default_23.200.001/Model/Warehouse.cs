using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN204000</c> in the Acumatica ERP
	/// <para>Key Fields: WarehouseID</para>
	/// </summary>
	public class Warehouse : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: COGSAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: COGS/Expense Account</para>
		/// </summary>
		public StringValue? COGSExpenseAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: COGSSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: COGS/Expense Sub.</para>
		/// </summary>
		public StringValue? COGSExpenseSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public StringValue? DiscountAccount { get; set; }

		public StringValue? DiscountSubaccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Drop-Ship Location</para>
		/// </summary>
		public StringValue? DropShipLocationID { get; set; }

		public StringValue? FreightChargeAccount { get; set; }

		public StringValue? FreightChargeSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Inventory Account</para>
		/// </summary>
		public StringValue? InventoryAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Inventory Sub.</para>
		/// </summary>
		public StringValue? InventorySubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LCVarianceAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Landed Cost Variance Account</para>
		/// </summary>
		public StringValue? LandedCostVarianceAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LCVarianceSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Landed Cost Variance Sub.</para>
		/// </summary>
		public StringValue? LandedCostVarianceSubaccount { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public List<WarehouseLocation>? Locations { get; set; }

		public StringValue? MiscChargeAccount { get; set; }

		public StringValue? MiscChargeSubaccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Non-Stock Location</para>
		/// </summary>
		public StringValue? NonStockPickingLocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideInvtAccSub</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Override Inventory Account/Sub.</para>
		/// </summary>
		public BooleanValue? OverrideInventoryAccountSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POAccrualAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: PO Accrual Account</para>
		/// </summary>
		public StringValue? POAccrualAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POAccrualSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: PO Accrual Sub.</para>
		/// </summary>
		public StringValue? POAccrualSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PPVAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Purchase Price Variance Account</para>
		/// </summary>
		public StringValue? PurchasePriceVarianceAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PPVSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Purchase Price Variance Sub.</para>
		/// </summary>
		public StringValue? PurchasePriceVarianceSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReasonCodeSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Reason Code Sub.</para>
		/// </summary>
		public StringValue? ReasonCodeSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReceiptLocationID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Receiving Location</para>
		/// </summary>
		public StringValue? ReceivingLocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReturnLocationID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: RMA Location</para>
		/// </summary>
		public StringValue? RMALocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Sales Account</para>
		/// </summary>
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Sales Sub.</para>
		/// </summary>
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipLocationID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Shipping Location</para>
		/// </summary>
		public StringValue? ShippingLocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCstRevAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Standard Cost Revaluation Account</para>
		/// </summary>
		public StringValue? StandardCostRevaluationAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCstRevSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Standard Cost Revaluation Sub.</para>
		/// </summary>
		public StringValue? StandardCostRevaluationSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCstVarAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Standard Cost Variance Account</para>
		/// </summary>
		public StringValue? StandardCostVarianceAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCstVarSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Standard Cost Variance Sub.</para>
		/// </summary>
		public StringValue? StandardCostVarianceSubaccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Use Item Default Location for Picking</para>
		/// </summary>
		public BooleanValue? UseItemDefaultLocationForPicking { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteCD</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Warehouse ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Locations = "Locations";
			public const string Locations_Files = "Locations/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Locations,Locations/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}