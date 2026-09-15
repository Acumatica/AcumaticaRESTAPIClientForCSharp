using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class InventorySummaryRow : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BaseUnit</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Base Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalCost</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Estimated Total Cost</para>
		/// </summary>
		[DataMember(Name="EstimatedTotalCost", EmitDefaultValue=false)]
		public DecimalValue? EstimatedTotalCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnitCost</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Estimated Unit Cost</para>
		/// </summary>
		[DataMember(Name="EstimatedUnitCost", EmitDefaultValue=false)]
		public DecimalValue? EstimatedUnitCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Lot/Serial Number</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyAvail</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Available</para>
		/// </summary>
		[DataMember(Name="QtyAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyHardAvail</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Available for Shipment</para>
		/// </summary>
		[DataMember(Name="QtyAvailableForShipment", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableForShipment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyNotAvail</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: Not Available</para>
		/// </summary>
		[DataMember(Name="QtyNotAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyNotAvailable { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnquiryResult</para>
		/// <para>Display Name: On Hand</para>
		/// </summary>
		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.InventorySummaryEnqFilter</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}