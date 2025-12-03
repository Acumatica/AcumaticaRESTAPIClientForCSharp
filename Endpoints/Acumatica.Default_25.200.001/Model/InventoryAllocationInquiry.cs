using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN402000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class InventoryAllocationInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: QtyAvail</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// </summary>
		[DataMember(Name="Available", EmitDefaultValue=false)]
		public DecimalValue? Available { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyActual</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Available for Issue</para>
		/// </summary>
		[DataMember(Name="AvailableForIssue", EmitDefaultValue=false)]
		public DecimalValue? AvailableForIssue { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyHardAvail</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Available for Shipping</para>
		/// </summary>
		[DataMember(Name="AvailableForShipping", EmitDefaultValue=false)]
		public DecimalValue? AvailableForShipping { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Base Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="BaseUnit", EmitDefaultValue=false)]
		public StringValue? BaseUnit { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyInTransit</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: In-Transit [**]</para>
		/// </summary>
		[DataMember(Name="InTransit", EmitDefaultValue=false)]
		public DecimalValue? InTransit { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyInTransitToSO</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: In-Transit to SO</para>
		/// </summary>
		[DataMember(Name="InTransitToSO", EmitDefaultValue=false)]
		public DecimalValue? InTransitToSO { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyINIssues</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: IN Issues [**]</para>
		/// </summary>
		[DataMember(Name="InventoryIssues", EmitDefaultValue=false)]
		public DecimalValue? InventoryIssues { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyINReceipts</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: IN Receipts [*]</para>
		/// </summary>
		[DataMember(Name="InventoryReceipts", EmitDefaultValue=false)]
		public DecimalValue? InventoryReceipts { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyINAssemblyDemand</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Kit Assembly Demand</para>
		/// </summary>
		[DataMember(Name="KitAssemblyDemand", EmitDefaultValue=false)]
		public DecimalValue? KitAssemblyDemand { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyINAssemblySupply</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Kit Assembly Supply</para>
		/// </summary>
		[DataMember(Name="KitAssemblySupply", EmitDefaultValue=false)]
		public DecimalValue? KitAssemblySupply { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyOnHand</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: On Hand</para>
		/// </summary>
		[DataMember(Name="OnHand", EmitDefaultValue=false)]
		public DecimalValue? OnHand { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyNotAvail</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: On Loc. Not Available</para>
		/// </summary>
		[DataMember(Name="OnLocationNotAvailable", EmitDefaultValue=false)]
		public DecimalValue? OnLocationNotAvailable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOFixedOrders</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Purchase for SO</para>
		/// </summary>
		[DataMember(Name="PurchaseForSO", EmitDefaultValue=false)]
		public DecimalValue? PurchaseForSO { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOFixedPrepared</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Purchase for SO Prepared</para>
		/// </summary>
		[DataMember(Name="PurchaseForSOPrepared", EmitDefaultValue=false)]
		public DecimalValue? PurchaseForSOPrepared { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOOrders</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Purchase Orders</para>
		/// </summary>
		[DataMember(Name="PurchaseOrders", EmitDefaultValue=false)]
		public DecimalValue? PurchaseOrders { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOPrepared</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Purchase Prepared</para>
		/// </summary>
		[DataMember(Name="PurchasePrepared", EmitDefaultValue=false)]
		public DecimalValue? PurchasePrepared { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOReceipts</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: PO Receipts</para>
		/// </summary>
		[DataMember(Name="PurchaseReceipts", EmitDefaultValue=false)]
		public DecimalValue? PurchaseReceipts { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyPOFixedReceipts</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Receipts for SO</para>
		/// </summary>
		[DataMember(Name="ReceiptsForSO", EmitDefaultValue=false)]
		public DecimalValue? ReceiptsForSO { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<InventoryAllocationRow>? Results { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOShipping</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO Allocated [**]</para>
		/// </summary>
		[DataMember(Name="SOAllocated", EmitDefaultValue=false)]
		public DecimalValue? SOAllocated { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOBackOrdered</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO Back Ordered [**]</para>
		/// </summary>
		[DataMember(Name="SOBackOrdered", EmitDefaultValue=false)]
		public DecimalValue? SOBackOrdered { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOBooked</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO Booked [**]</para>
		/// </summary>
		[DataMember(Name="SOBooked", EmitDefaultValue=false)]
		public DecimalValue? SOBooked { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOPrepared</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO Prepared</para>
		/// </summary>
		[DataMember(Name="SOPrepared", EmitDefaultValue=false)]
		public DecimalValue? SOPrepared { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOShipped</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO Shipped [**]</para>
		/// </summary>
		[DataMember(Name="SOShipped", EmitDefaultValue=false)]
		public DecimalValue? SOShipped { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtySOFixed</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: SO to Purchase</para>
		/// </summary>
		[DataMember(Name="SOToPurchase", EmitDefaultValue=false)]
		public DecimalValue? SOToPurchase { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyTotalAddition</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Total Addition</para>
		/// </summary>
		[DataMember(Name="TotalAddition", EmitDefaultValue=false)]
		public DecimalValue? TotalAddition { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyTotalDeduction</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Total Deduction</para>
		/// </summary>
		[DataMember(Name="TotalDeduction", EmitDefaultValue=false)]
		public DecimalValue? TotalDeduction { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}