using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class InventoryAllocationInquiry : Entity_v4
	{

		[DataMember(Name="Available", EmitDefaultValue=false)]
		public DecimalValue Available { get; set; }

		[DataMember(Name="AvailableForIssue", EmitDefaultValue=false)]
		public DecimalValue AvailableForIssue { get; set; }

		[DataMember(Name="AvailableForShipping", EmitDefaultValue=false)]
		public DecimalValue AvailableForShipping { get; set; }

		[DataMember(Name="BaseUnit", EmitDefaultValue=false)]
		public StringValue BaseUnit { get; set; }

		[DataMember(Name="InTransit", EmitDefaultValue=false)]
		public DecimalValue InTransit { get; set; }

		[DataMember(Name="InTransitToSO", EmitDefaultValue=false)]
		public DecimalValue InTransitToSO { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="InventoryIssues", EmitDefaultValue=false)]
		public DecimalValue InventoryIssues { get; set; }

		[DataMember(Name="InventoryReceipts", EmitDefaultValue=false)]
		public DecimalValue InventoryReceipts { get; set; }

		[DataMember(Name="KitAssemblyDemand", EmitDefaultValue=false)]
		public DecimalValue KitAssemblyDemand { get; set; }

		[DataMember(Name="KitAssemblySupply", EmitDefaultValue=false)]
		public DecimalValue KitAssemblySupply { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="OnHand", EmitDefaultValue=false)]
		public DecimalValue OnHand { get; set; }

		[DataMember(Name="OnLocationNotAvailable", EmitDefaultValue=false)]
		public DecimalValue OnLocationNotAvailable { get; set; }

		[DataMember(Name="PurchaseForSO", EmitDefaultValue=false)]
		public DecimalValue PurchaseForSO { get; set; }

		[DataMember(Name="PurchaseForSOPrepared", EmitDefaultValue=false)]
		public DecimalValue PurchaseForSOPrepared { get; set; }

		[DataMember(Name="PurchaseOrders", EmitDefaultValue=false)]
		public DecimalValue PurchaseOrders { get; set; }

		[DataMember(Name="PurchasePrepared", EmitDefaultValue=false)]
		public DecimalValue PurchasePrepared { get; set; }

		[DataMember(Name="PurchaseReceipts", EmitDefaultValue=false)]
		public DecimalValue PurchaseReceipts { get; set; }

		[DataMember(Name="ReceiptsForSO", EmitDefaultValue=false)]
		public DecimalValue ReceiptsForSO { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<InventoryAllocationRow> Results { get; set; }

		[DataMember(Name="SOAllocated", EmitDefaultValue=false)]
		public DecimalValue SOAllocated { get; set; }

		[DataMember(Name="SOBackOrdered", EmitDefaultValue=false)]
		public DecimalValue SOBackOrdered { get; set; }

		[DataMember(Name="SOBooked", EmitDefaultValue=false)]
		public DecimalValue SOBooked { get; set; }

		[DataMember(Name="SOPrepared", EmitDefaultValue=false)]
		public DecimalValue SOPrepared { get; set; }

		[DataMember(Name="SOShipped", EmitDefaultValue=false)]
		public DecimalValue SOShipped { get; set; }

		[DataMember(Name="SOToPurchase", EmitDefaultValue=false)]
		public DecimalValue SOToPurchase { get; set; }

		[DataMember(Name="TotalAddition", EmitDefaultValue=false)]
		public DecimalValue TotalAddition { get; set; }

		[DataMember(Name="TotalDeduction", EmitDefaultValue=false)]
		public DecimalValue TotalDeduction { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

	}
}