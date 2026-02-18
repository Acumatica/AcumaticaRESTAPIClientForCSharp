using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class InventorySummaryRow : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BaseUnit</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Base Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? BaseUOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalCost</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Estimated Total Cost</para>
		/// </summary>
		public DecimalValue? EstimatedTotalCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnitCost</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Estimated Unit Cost</para>
		/// </summary>
		public DecimalValue? EstimatedUnitCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Lot/Serial Number</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyAvail</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Available</para>
		/// </summary>
		public DecimalValue? QtyAvailable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyHardAvail</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Available for Shipment</para>
		/// </summary>
		public DecimalValue? QtyAvailableForShipment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyNotAvail</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Not Available</para>
		/// </summary>
		public DecimalValue? QtyNotAvailable { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: On Hand</para>
		/// </summary>
		public DecimalValue? QtyOnHand { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

	}
}