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
	/// Corresponds to the screen IN204000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Warehouse : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC Field Name: COGSAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: COGS/Expense Account 
		/// </summary>
		[DataMember(Name="COGSExpenseAccount", EmitDefaultValue=false)]
		public StringValue? COGSExpenseAccount { get; set; }

		/// <summary>
		/// DAC Field Name: COGSSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: COGS/Expense Sub. 
		/// </summary>
		[DataMember(Name="COGSExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? COGSExpenseSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.INSite 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue? DiscountAccount { get; set; }

		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue? DiscountSubaccount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Drop-Ship Location 
		/// </summary>
		[DataMember(Name="DropShipLocationID", EmitDefaultValue=false)]
		public StringValue? DropShipLocationID { get; set; }

		[DataMember(Name="FreightChargeAccount", EmitDefaultValue=false)]
		public StringValue? FreightChargeAccount { get; set; }

		[DataMember(Name="FreightChargeSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightChargeSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: InvtAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Inventory Account 
		/// </summary>
		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue? InventoryAccount { get; set; }

		/// <summary>
		/// DAC Field Name: InvtSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Inventory Sub. 
		/// </summary>
		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue? InventorySubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: LCVarianceAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Landed Cost Variance Account 
		/// </summary>
		[DataMember(Name="LandedCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue? LandedCostVarianceAccount { get; set; }

		/// <summary>
		/// DAC Field Name: LCVarianceSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Landed Cost Variance Sub. 
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
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Picking Location for Non-Stock Items 
		/// </summary>
		[DataMember(Name="NonStockPickingLocationID", EmitDefaultValue=false)]
		public StringValue? NonStockPickingLocationID { get; set; }

		/// <summary>
		/// DAC Field Name: OverrideInvtAccSub 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Override Inventory Account/Sub. 
		/// </summary>
		[DataMember(Name="OverrideInventoryAccountSubaccount", EmitDefaultValue=false)]
		public BooleanValue? OverrideInventoryAccountSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: POAccrualAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: PO Accrual Account 
		/// </summary>
		[DataMember(Name="POAccrualAccount", EmitDefaultValue=false)]
		public StringValue? POAccrualAccount { get; set; }

		/// <summary>
		/// DAC Field Name: POAccrualSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: PO Accrual Sub. 
		/// </summary>
		[DataMember(Name="POAccrualSubaccount", EmitDefaultValue=false)]
		public StringValue? POAccrualSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: PPVAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Purchase Price Variance Account 
		/// </summary>
		[DataMember(Name="PurchasePriceVarianceAccount", EmitDefaultValue=false)]
		public StringValue? PurchasePriceVarianceAccount { get; set; }

		/// <summary>
		/// DAC Field Name: PPVSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Purchase Price Variance Sub. 
		/// </summary>
		[DataMember(Name="PurchasePriceVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? PurchasePriceVarianceSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: ReasonCodeSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Reason Code Sub. 
		/// </summary>
		[DataMember(Name="ReasonCodeSubaccount", EmitDefaultValue=false)]
		public StringValue? ReasonCodeSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: ReceiptLocationID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Receiving Location 
		/// </summary>
		[DataMember(Name="ReceivingLocationID", EmitDefaultValue=false)]
		public StringValue? ReceivingLocationID { get; set; }

		/// <summary>
		/// DAC Field Name: ReturnLocationID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: RMA Location 
		/// </summary>
		[DataMember(Name="RMALocationID", EmitDefaultValue=false)]
		public StringValue? RMALocationID { get; set; }

		/// <summary>
		/// DAC Field Name: SalesAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Sales Account 
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// DAC Field Name: SalesSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Sales Sub. 
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: ShipLocationID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Shipping Location 
		/// </summary>
		[DataMember(Name="ShippingLocationID", EmitDefaultValue=false)]
		public StringValue? ShippingLocationID { get; set; }

		/// <summary>
		/// DAC Field Name: StdCstRevAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Standard Cost Revaluation Account 
		/// </summary>
		[DataMember(Name="StandardCostRevaluationAccount", EmitDefaultValue=false)]
		public StringValue? StandardCostRevaluationAccount { get; set; }

		/// <summary>
		/// DAC Field Name: StdCstRevSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Standard Cost Revaluation Sub. 
		/// </summary>
		[DataMember(Name="StandardCostRevaluationSubaccount", EmitDefaultValue=false)]
		public StringValue? StandardCostRevaluationSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: StdCstVarAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Standard Cost Variance Account 
		/// </summary>
		[DataMember(Name="StandardCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue? StandardCostVarianceAccount { get; set; }

		/// <summary>
		/// DAC Field Name: StdCstVarSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Standard Cost Variance Sub. 
		/// </summary>
		[DataMember(Name="StandardCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? StandardCostVarianceSubaccount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Use Item Default Location for Picking 
		/// </summary>
		[DataMember(Name="UseItemDefaultLocationForPicking", EmitDefaultValue=false)]
		public BooleanValue? UseItemDefaultLocationForPicking { get; set; }

		/// <summary>
		/// DAC Field Name: SiteCD 
		/// DAC: PX.Objects.IN.INSite 
		/// Display Name: Warehouse ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}