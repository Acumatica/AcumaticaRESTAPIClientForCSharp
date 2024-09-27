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
	/// Corresponds to the screen IN402000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class InventoryAllocationInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: QtyAvail 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		[DataMember(Name="Available", EmitDefaultValue=false)]
		public DecimalValue? Available { get; set; }

		/// <summary>
		/// DAC Field Name: QtyActual 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Available for Issue 
		/// </summary>
		[DataMember(Name="AvailableForIssue", EmitDefaultValue=false)]
		public DecimalValue? AvailableForIssue { get; set; }

		/// <summary>
		/// DAC Field Name: QtyHardAvail 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Available for Shipping 
		/// </summary>
		[DataMember(Name="AvailableForShipping", EmitDefaultValue=false)]
		public DecimalValue? AvailableForShipping { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Base Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="BaseUnit", EmitDefaultValue=false)]
		public StringValue? BaseUnit { get; set; }

		/// <summary>
		/// DAC Field Name: QtyInTransit 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: In-Transit [**] 
		/// </summary>
		[DataMember(Name="InTransit", EmitDefaultValue=false)]
		public DecimalValue? InTransit { get; set; }

		/// <summary>
		/// DAC Field Name: QtyInTransitToSO 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: In-Transit to SO 
		/// </summary>
		[DataMember(Name="InTransitToSO", EmitDefaultValue=false)]
		public DecimalValue? InTransitToSO { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: QtyINIssues 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: IN Issues [**] 
		/// </summary>
		[DataMember(Name="InventoryIssues", EmitDefaultValue=false)]
		public DecimalValue? InventoryIssues { get; set; }

		/// <summary>
		/// DAC Field Name: QtyINReceipts 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: IN Receipts [*] 
		/// </summary>
		[DataMember(Name="InventoryReceipts", EmitDefaultValue=false)]
		public DecimalValue? InventoryReceipts { get; set; }

		/// <summary>
		/// DAC Field Name: QtyINAssemblyDemand 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Kit Assembly Demand 
		/// </summary>
		[DataMember(Name="KitAssemblyDemand", EmitDefaultValue=false)]
		public DecimalValue? KitAssemblyDemand { get; set; }

		/// <summary>
		/// DAC Field Name: QtyINAssemblySupply 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Kit Assembly Supply 
		/// </summary>
		[DataMember(Name="KitAssemblySupply", EmitDefaultValue=false)]
		public DecimalValue? KitAssemblySupply { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC Field Name: QtyOnHand 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: On Hand 
		/// </summary>
		[DataMember(Name="OnHand", EmitDefaultValue=false)]
		public DecimalValue? OnHand { get; set; }

		/// <summary>
		/// DAC Field Name: QtyNotAvail 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: On Loc. Not Available 
		/// </summary>
		[DataMember(Name="OnLocationNotAvailable", EmitDefaultValue=false)]
		public DecimalValue? OnLocationNotAvailable { get; set; }

		/// <summary>
		/// DAC Field Name: QtyPOFixedOrders 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Purchase for SO 
		/// </summary>
		[DataMember(Name="PurchaseForSO", EmitDefaultValue=false)]
		public DecimalValue? PurchaseForSO { get; set; }

		/// <summary>
		/// DAC Field Name: QtyPOFixedPrepared 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Purchase for SO Prepared 
		/// </summary>
		[DataMember(Name="PurchaseForSOPrepared", EmitDefaultValue=false)]
		public DecimalValue? PurchaseForSOPrepared { get; set; }

		/// <summary>
		/// DAC Field Name: QtyPOOrders 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Purchase Orders 
		/// </summary>
		[DataMember(Name="PurchaseOrders", EmitDefaultValue=false)]
		public DecimalValue? PurchaseOrders { get; set; }

		/// <summary>
		/// DAC Field Name: QtyPOPrepared 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Purchase Prepared 
		/// </summary>
		[DataMember(Name="PurchasePrepared", EmitDefaultValue=false)]
		public DecimalValue? PurchasePrepared { get; set; }

		/// <summary>
		/// DAC Field Name: QtyPOReceipts 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: PO Receipts 
		/// </summary>
		[DataMember(Name="PurchaseReceipts", EmitDefaultValue=false)]
		public DecimalValue? PurchaseReceipts { get; set; }

		/// <summary>
		/// DAC Field Name: QtyPOFixedReceipts 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Receipts for SO 
		/// </summary>
		[DataMember(Name="ReceiptsForSO", EmitDefaultValue=false)]
		public DecimalValue? ReceiptsForSO { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<InventoryAllocationRow>? Results { get; set; }

		/// <summary>
		/// DAC Field Name: QtySOShipping 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: SO Allocated [**] 
		/// </summary>
		[DataMember(Name="SOAllocated", EmitDefaultValue=false)]
		public DecimalValue? SOAllocated { get; set; }

		/// <summary>
		/// DAC Field Name: QtySOBackOrdered 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: SO Back Ordered [**] 
		/// </summary>
		[DataMember(Name="SOBackOrdered", EmitDefaultValue=false)]
		public DecimalValue? SOBackOrdered { get; set; }

		/// <summary>
		/// DAC Field Name: QtySOBooked 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: SO Booked [**] 
		/// </summary>
		[DataMember(Name="SOBooked", EmitDefaultValue=false)]
		public DecimalValue? SOBooked { get; set; }

		/// <summary>
		/// DAC Field Name: QtySOPrepared 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: SO Prepared 
		/// </summary>
		[DataMember(Name="SOPrepared", EmitDefaultValue=false)]
		public DecimalValue? SOPrepared { get; set; }

		/// <summary>
		/// DAC Field Name: QtySOShipped 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: SO Shipped [**] 
		/// </summary>
		[DataMember(Name="SOShipped", EmitDefaultValue=false)]
		public DecimalValue? SOShipped { get; set; }

		/// <summary>
		/// DAC Field Name: QtySOFixed 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: SO to Purchase 
		/// </summary>
		[DataMember(Name="SOToPurchase", EmitDefaultValue=false)]
		public DecimalValue? SOToPurchase { get; set; }

		/// <summary>
		/// DAC Field Name: QtyTotalAddition 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Total Addition 
		/// </summary>
		[DataMember(Name="TotalAddition", EmitDefaultValue=false)]
		public DecimalValue? TotalAddition { get; set; }

		/// <summary>
		/// DAC Field Name: QtyTotalDeduction 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Total Deduction 
		/// </summary>
		[DataMember(Name="TotalDeduction", EmitDefaultValue=false)]
		public DecimalValue? TotalDeduction { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Warehouse 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}