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
	public class ShipmentOrderDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: InvtDocType 
		/// DAC: PX.Objects.SO.SOOrderShipment 
		/// Display Name: Inventory Doc. Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="InventoryDocType", EmitDefaultValue=false)]
		public StringValue? InventoryDocType { get; set; }

		/// <summary>
		/// DAC Field Name: InvtRefNbr 
		/// DAC: PX.Objects.SO.SOOrderShipment 
		/// Display Name: Inventory Ref. Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
		public StringValue? InventoryRefNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOOrderShipment 
		/// Display Name: Invoice Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOOrderShipment 
		/// Display Name: Invoice Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="InvoiceType", EmitDefaultValue=false)]
		public StringValue? InvoiceType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOOrderShipment 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOOrderShipment 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Shipment Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringValue? ShipmentType { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentQty 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Shipped Quantity 
		/// </summary>
		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentVolume 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Shipped Volume 
		/// </summary>
		[DataMember(Name="ShippedVolume", EmitDefaultValue=false)]
		public DecimalValue? ShippedVolume { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentWeight 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Shipped Weight 
		/// </summary>
		[DataMember(Name="ShippedWeight", EmitDefaultValue=false)]
		public DecimalValue? ShippedWeight { get; set; }

		[DataMember(Name="OrderNoteID", EmitDefaultValue=false)]
		public GuidValue? OrderNoteID { get; set; }

	}
}