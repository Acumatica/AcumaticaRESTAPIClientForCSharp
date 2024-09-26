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
	/// Corresponds to the screen IN402000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class InventoryAllocationInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyAvail 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Available", EmitDefaultValue=false)]
		public DecimalValue? Available { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyActual 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AvailableForIssue", EmitDefaultValue=false)]
		public DecimalValue? AvailableForIssue { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyHardAvail 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AvailableForShipping", EmitDefaultValue=false)]
		public DecimalValue? AvailableForShipping { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseUnit 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseUnit", EmitDefaultValue=false)]
		public StringValue? BaseUnit { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyInTransit 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InTransit", EmitDefaultValue=false)]
		public DecimalValue? InTransit { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyInTransitToSO 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InTransitToSO", EmitDefaultValue=false)]
		public DecimalValue? InTransitToSO { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyINIssues 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryIssues", EmitDefaultValue=false)]
		public DecimalValue? InventoryIssues { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyINReceipts 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryReceipts", EmitDefaultValue=false)]
		public DecimalValue? InventoryReceipts { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyINAssemblyDemand 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="KitAssemblyDemand", EmitDefaultValue=false)]
		public DecimalValue? KitAssemblyDemand { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyINAssemblySupply 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="KitAssemblySupply", EmitDefaultValue=false)]
		public DecimalValue? KitAssemblySupply { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyOnHand 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OnHand", EmitDefaultValue=false)]
		public DecimalValue? OnHand { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyNotAvail 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OnLocationNotAvailable", EmitDefaultValue=false)]
		public DecimalValue? OnLocationNotAvailable { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyPOFixedOrders 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchaseForSO", EmitDefaultValue=false)]
		public DecimalValue? PurchaseForSO { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyPOFixedPrepared 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchaseForSOPrepared", EmitDefaultValue=false)]
		public DecimalValue? PurchaseForSOPrepared { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyPOOrders 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchaseOrders", EmitDefaultValue=false)]
		public DecimalValue? PurchaseOrders { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyPOPrepared 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchasePrepared", EmitDefaultValue=false)]
		public DecimalValue? PurchasePrepared { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyPOReceipts 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchaseReceipts", EmitDefaultValue=false)]
		public DecimalValue? PurchaseReceipts { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyPOFixedReceipts 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReceiptsForSO", EmitDefaultValue=false)]
		public DecimalValue? ReceiptsForSO { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<InventoryAllocationRow>? Results { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtySOShipping 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOAllocated", EmitDefaultValue=false)]
		public DecimalValue? SOAllocated { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtySOBackOrdered 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOBackOrdered", EmitDefaultValue=false)]
		public DecimalValue? SOBackOrdered { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtySOBooked 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOBooked", EmitDefaultValue=false)]
		public DecimalValue? SOBooked { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtySOPrepared 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOPrepared", EmitDefaultValue=false)]
		public DecimalValue? SOPrepared { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtySOShipped 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOShipped", EmitDefaultValue=false)]
		public DecimalValue? SOShipped { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtySOFixed 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOToPurchase", EmitDefaultValue=false)]
		public DecimalValue? SOToPurchase { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyTotalAddition 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalAddition", EmitDefaultValue=false)]
		public DecimalValue? TotalAddition { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyTotalDeduction 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalDeduction", EmitDefaultValue=false)]
		public DecimalValue? TotalDeduction { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}