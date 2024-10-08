using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class InventorySummaryRow : Entity
	{

		/// <summary>
		/// DAC Field Name: BaseUnit 
		/// DAC: PX.Objects.IN.InventorySummaryEnquiryResult 
		/// Display Name: Base Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		/// <summary>
		/// DAC Field Name: TotalCost 
		/// DAC: PX.Objects.IN.InventorySummaryEnquiryResult 
		/// Display Name: Estimated Total Cost 
		/// </summary>
		[DataMember(Name="EstimatedTotalCost", EmitDefaultValue=false)]
		public DecimalValue? EstimatedTotalCost { get; set; }

		/// <summary>
		/// DAC Field Name: UnitCost 
		/// DAC: PX.Objects.IN.InventorySummaryEnquiryResult 
		/// Display Name: Estimated Unit Cost 
		/// </summary>
		[DataMember(Name="EstimatedUnitCost", EmitDefaultValue=false)]
		public DecimalValue? EstimatedUnitCost { get; set; }

		/// <summary>
		/// DAC Field Name: ExpireDate 
		/// DAC: PX.Objects.IN.InventorySummaryEnquiryResult 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventorySummaryEnqFilter 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventorySummaryEnquiryResult 
		/// Display Name: Lot/Serial Number 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC Field Name: QtyAvail 
		/// DAC: PX.Objects.IN.InventorySummaryEnquiryResult 
		/// Display Name: Available 
		/// </summary>
		[DataMember(Name="QtyAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailable { get; set; }

		/// <summary>
		/// DAC Field Name: QtyHardAvail 
		/// DAC: PX.Objects.IN.InventorySummaryEnquiryResult 
		/// Display Name: Available for Shipment 
		/// </summary>
		[DataMember(Name="QtyAvailableForShipment", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableForShipment { get; set; }

		/// <summary>
		/// DAC Field Name: QtyNotAvail 
		/// DAC: PX.Objects.IN.InventorySummaryEnquiryResult 
		/// Display Name: Not Available 
		/// </summary>
		[DataMember(Name="QtyNotAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyNotAvailable { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventorySummaryEnquiryResult 
		/// Display Name: On Hand 
		/// </summary>
		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.IN.InventorySummaryEnquiryResult 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.IN.InventorySummaryEnqFilter 
		/// Display Name: Warehouse 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

	}
}