using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN402000</c> in the Acumatica ERP
	/// </summary>
	public class InventoryAllocationInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: QtyAvail</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// </summary>
		public DecimalValue? Available { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyActual</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Available for Issue</para>
		/// </summary>
		public DecimalValue? AvailableForIssue { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyHardAvail</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Available for Shipping</para>
		/// </summary>
		public DecimalValue? AvailableForShipping { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Base Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? BaseUnit { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyInTransit</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: In-Transit [**]</para>
		/// </summary>
		public DecimalValue? InTransit { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyInTransitToSO</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: In-Transit to SO</para>
		/// </summary>
		public DecimalValue? InTransitToSO { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyINIssues</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: IN Issues [**]</para>
		/// </summary>
		public DecimalValue? InventoryIssues { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyINReceipts</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: IN Receipts [*]</para>
		/// </summary>
		public DecimalValue? InventoryReceipts { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyINAssemblyDemand</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Kit Assembly Demand</para>
		/// </summary>
		public DecimalValue? KitAssemblyDemand { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyINAssemblySupply</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Kit Assembly Supply</para>
		/// </summary>
		public DecimalValue? KitAssemblySupply { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyOnHand</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: On Hand</para>
		/// </summary>
		public DecimalValue? OnHand { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyNotAvail</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: On Loc. Not Available</para>
		/// </summary>
		public DecimalValue? OnLocationNotAvailable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOFixedOrders</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Purchase for SO</para>
		/// </summary>
		public DecimalValue? PurchaseForSO { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOFixedPrepared</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Purchase for SO Prepared</para>
		/// </summary>
		public DecimalValue? PurchaseForSOPrepared { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOOrders</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Purchase Orders</para>
		/// </summary>
		public DecimalValue? PurchaseOrders { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOPrepared</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Purchase Prepared</para>
		/// </summary>
		public DecimalValue? PurchasePrepared { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOReceipts</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: PO Receipts</para>
		/// </summary>
		public DecimalValue? PurchaseReceipts { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOFixedReceipts</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Receipts for SO</para>
		/// </summary>
		public DecimalValue? ReceiptsForSO { get; set; }

		public List<InventoryAllocationRow>? Results { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOShipping</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO Allocated [**]</para>
		/// </summary>
		public DecimalValue? SOAllocated { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOBackOrdered</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO Back Ordered [**]</para>
		/// </summary>
		public DecimalValue? SOBackOrdered { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOBooked</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO Booked [**]</para>
		/// </summary>
		public DecimalValue? SOBooked { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOPrepared</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO Prepared</para>
		/// </summary>
		public DecimalValue? SOPrepared { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOShipped</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO Shipped [**]</para>
		/// </summary>
		public DecimalValue? SOShipped { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOFixed</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO to Purchase</para>
		/// </summary>
		public DecimalValue? SOToPurchase { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyTotalAddition</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Total Addition</para>
		/// </summary>
		public DecimalValue? TotalAddition { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyTotalDeduction</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Total Deduction</para>
		/// </summary>
		public DecimalValue? TotalDeduction { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}