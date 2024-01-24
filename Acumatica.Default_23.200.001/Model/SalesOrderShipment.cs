using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class SalesOrderShipment : Entity
	{

		[DataMember(Name="InventoryDocType", EmitDefaultValue=false)]
		public StringValue? InventoryDocType { get; set; }

		[DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
		public StringValue? InventoryRefNbr { get; set; }

		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		[DataMember(Name="InvoiceType", EmitDefaultValue=false)]
		public StringValue? InvoiceType { get; set; }

		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue? ShipmentDate { get; set; }

		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringValue? ShipmentType { get; set; }

		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue? ShippedQty { get; set; }

		[DataMember(Name="ShippedVolume", EmitDefaultValue=false)]
		public DecimalValue? ShippedVolume { get; set; }

		[DataMember(Name="ShippedWeight", EmitDefaultValue=false)]
		public DecimalValue? ShippedWeight { get; set; }

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