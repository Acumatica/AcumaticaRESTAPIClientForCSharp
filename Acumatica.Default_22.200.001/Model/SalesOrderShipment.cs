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
	public class SalesOrderShipment : Entity
	{

		/// <summary>
		/// DAC Field Name: InvtDocType 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="InventoryDocType", EmitDefaultValue=false)]
		public StringValue? InventoryDocType { get; set; }

		/// <summary>
		/// DAC Field Name: InvtRefNbr 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
		public StringValue? InventoryRefNbr { get; set; }

		/// <summary>
		/// The reference number of the original invoice (which lists the goods that were ordered andlater returned by the customer).The field is included in the Invoice foreign key.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Invoice Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		/// <remarks>
		/// This field is available for orders of the CR, RC, RR, and RM types.
		/// </remarks>
		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="InvoiceType", EmitDefaultValue=false)]
		public StringValue? InvoiceType { get; set; }

		/// <summary>
		/// The date when the ordered goods are scheduled to be shipped.
		/// DAC Field Name: ShipDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Sched. Shipment 
		/// </summary>
		/// <remarks>
		/// By default, it is the date that is specified in requestDate minus the number of lead days,but it is not earlier than the current business date.
		/// </remarks>
		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue? ShipmentDate { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringValue? ShipmentType { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentQty 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentVolume 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="ShippedVolume", EmitDefaultValue=false)]
		public DecimalValue? ShippedVolume { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentWeight 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="ShippedWeight", EmitDefaultValue=false)]
		public DecimalValue? ShippedWeight { get; set; }

		/// <summary>
		/// DAC Field Name: SOShipment__StatusIsNull 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="InventoryNoteID", EmitDefaultValue=false)]
		public GuidValue? InventoryNoteID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="OrderNoteID", EmitDefaultValue=false)]
		public GuidValue? OrderNoteID { get; set; }

		[DataMember(Name="ShippingNoteID", EmitDefaultValue=false)]
		public GuidValue? ShippingNoteID { get; set; }

	}
}