using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
	[DataContract]
	public class Warehouse : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC Field Name: COGSAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: COGS/Expense Account</para>
		/// </summary>
		[DataMember(Name="COGSExpenseAccount", EmitDefaultValue=false)]
		public StringValue? COGSExpenseAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: COGSSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: COGS/Expense Sub.</para>
		/// </summary>
		[DataMember(Name="COGSExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? COGSExpenseSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue? DiscountAccount { get; set; }

		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue? DiscountSubaccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Drop-Ship Location</para>
		/// </summary>
		[DataMember(Name="DropShipLocationID", EmitDefaultValue=false)]
		public StringValue? DropShipLocationID { get; set; }

		[DataMember(Name="FreightChargeAccount", EmitDefaultValue=false)]
		public StringValue? FreightChargeAccount { get; set; }

		[DataMember(Name="FreightChargeSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightChargeSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Inventory Account</para>
		/// </summary>
		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue? InventoryAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Inventory Sub.</para>
		/// </summary>
		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue? InventorySubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LCVarianceAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Landed Cost Variance Account</para>
		/// </summary>
		[DataMember(Name="LandedCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue? LandedCostVarianceAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LCVarianceSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Landed Cost Variance Sub.</para>
		/// </summary>
		[DataMember(Name="LandedCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? LandedCostVarianceSubaccount { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Locations", EmitDefaultValue=false)]
		public List<WarehouseLocation>? Locations { get; set; }

		[DataMember(Name="MiscChargeAccount", EmitDefaultValue=false)]
		public StringValue? MiscChargeAccount { get; set; }

		[DataMember(Name="MiscChargeSubaccount", EmitDefaultValue=false)]
		public StringValue? MiscChargeSubaccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Non-Stock Location</para>
		/// </summary>
		[DataMember(Name="NonStockPickingLocationID", EmitDefaultValue=false)]
		public StringValue? NonStockPickingLocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideInvtAccSub</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Override Inventory Account/Sub.</para>
		/// </summary>
		[DataMember(Name="OverrideInventoryAccountSubaccount", EmitDefaultValue=false)]
		public BooleanValue? OverrideInventoryAccountSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POAccrualAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: PO Accrual Account</para>
		/// </summary>
		[DataMember(Name="POAccrualAccount", EmitDefaultValue=false)]
		public StringValue? POAccrualAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POAccrualSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: PO Accrual Sub.</para>
		/// </summary>
		[DataMember(Name="POAccrualSubaccount", EmitDefaultValue=false)]
		public StringValue? POAccrualSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PPVAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Purchase Price Variance Account</para>
		/// </summary>
		[DataMember(Name="PurchasePriceVarianceAccount", EmitDefaultValue=false)]
		public StringValue? PurchasePriceVarianceAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PPVSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Purchase Price Variance Sub.</para>
		/// </summary>
		[DataMember(Name="PurchasePriceVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? PurchasePriceVarianceSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReasonCodeSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Reason Code Sub.</para>
		/// </summary>
		[DataMember(Name="ReasonCodeSubaccount", EmitDefaultValue=false)]
		public StringValue? ReasonCodeSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReceiptLocationID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Receiving Location</para>
		/// </summary>
		[DataMember(Name="ReceivingLocationID", EmitDefaultValue=false)]
		public StringValue? ReceivingLocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReturnLocationID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: RMA Location</para>
		/// </summary>
		[DataMember(Name="RMALocationID", EmitDefaultValue=false)]
		public StringValue? RMALocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Sales Account</para>
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Sales Sub.</para>
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipLocationID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Shipping Location</para>
		/// </summary>
		[DataMember(Name="ShippingLocationID", EmitDefaultValue=false)]
		public StringValue? ShippingLocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCstRevAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Standard Cost Revaluation Account</para>
		/// </summary>
		[DataMember(Name="StandardCostRevaluationAccount", EmitDefaultValue=false)]
		public StringValue? StandardCostRevaluationAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCstRevSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Standard Cost Revaluation Sub.</para>
		/// </summary>
		[DataMember(Name="StandardCostRevaluationSubaccount", EmitDefaultValue=false)]
		public StringValue? StandardCostRevaluationSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCstVarAcctID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Standard Cost Variance Account</para>
		/// </summary>
		[DataMember(Name="StandardCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue? StandardCostVarianceAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCstVarSubID</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Standard Cost Variance Sub.</para>
		/// </summary>
		[DataMember(Name="StandardCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? StandardCostVarianceSubaccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Use Item Default Location for Picking</para>
		/// </summary>
		[DataMember(Name="UseItemDefaultLocationForPicking", EmitDefaultValue=false)]
		public BooleanValue? UseItemDefaultLocationForPicking { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteCD</para>
		/// <para>DAC: PX.Objects.IN.INSite</para>
		/// <para>Display Name: Warehouse ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Locations = "Locations";
			public const string Locations_Files = "Locations/Files";

			//Intentionally excluded
			//public const string All = "Files,Locations,Locations/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}