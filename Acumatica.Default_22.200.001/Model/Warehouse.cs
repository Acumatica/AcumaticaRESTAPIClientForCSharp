using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN204000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Warehouse : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Active 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COGSAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="COGSExpenseAccount", EmitDefaultValue=false)]
		public StringValue? COGSExpenseAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COGSSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="COGSExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? COGSExpenseSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue? DiscountAccount { get; set; }

		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue? DiscountSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DropShipLocationID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DropShipLocationID", EmitDefaultValue=false)]
		public StringValue? DropShipLocationID { get; set; }

		[DataMember(Name="FreightChargeAccount", EmitDefaultValue=false)]
		public StringValue? FreightChargeAccount { get; set; }

		[DataMember(Name="FreightChargeSubaccount", EmitDefaultValue=false)]
		public StringValue? FreightChargeSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvtAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue? InventoryAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvtSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue? InventorySubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LCVarianceAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LandedCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue? LandedCostVarianceAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LCVarianceSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LandedCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? LandedCostVarianceSubaccount { get; set; }

		[DataMember(Name="Locations", EmitDefaultValue=false)]
		public List<WarehouseLocation>? Locations { get; set; }

		[DataMember(Name="MiscChargeAccount", EmitDefaultValue=false)]
		public StringValue? MiscChargeAccount { get; set; }

		[DataMember(Name="MiscChargeSubaccount", EmitDefaultValue=false)]
		public StringValue? MiscChargeSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideInvtAccSub 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideInventoryAccountSubaccount", EmitDefaultValue=false)]
		public BooleanValue? OverrideInventoryAccountSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: POAccrualAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="POAccrualAccount", EmitDefaultValue=false)]
		public StringValue? POAccrualAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: POAccrualSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="POAccrualSubaccount", EmitDefaultValue=false)]
		public StringValue? POAccrualSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PPVAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchasePriceVarianceAccount", EmitDefaultValue=false)]
		public StringValue? PurchasePriceVarianceAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PPVSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchasePriceVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? PurchasePriceVarianceSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReasonCodeSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReasonCodeSubaccount", EmitDefaultValue=false)]
		public StringValue? ReasonCodeSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReceiptLocationID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReceivingLocationID", EmitDefaultValue=false)]
		public StringValue? ReceivingLocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReturnLocationID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RMALocationID", EmitDefaultValue=false)]
		public StringValue? RMALocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipLocationID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingLocationID", EmitDefaultValue=false)]
		public StringValue? ShippingLocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCstRevAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StandardCostRevaluationAccount", EmitDefaultValue=false)]
		public StringValue? StandardCostRevaluationAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCstRevSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StandardCostRevaluationSubaccount", EmitDefaultValue=false)]
		public StringValue? StandardCostRevaluationSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCstVarAcctID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StandardCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue? StandardCostVarianceAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCstVarSubID 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StandardCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? StandardCostVarianceSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteCD 
		/// DAC: PX.Objects.IN.INSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}