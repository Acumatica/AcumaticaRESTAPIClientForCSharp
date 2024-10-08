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
	public class BusinessAccountOrder : Entity
	{

		/// <summary>
		/// The identifier of the Currency,which is applied to the documents of the business account.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The reference number of the original customer document that the sales order is based on.
		/// DAC Field Name: CustomerOrderNbr 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Customer Order Nbr. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		/// <remarks>
		/// A reference number must be specified if theRequire Customer Order Nbr field istrue for the order type.This field is available for orders of the TR type.
		/// </remarks>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// A brief description of the document.
		/// DAC Field Name: OrderDesc 
		/// DAC: PX.Objects.SO.SOOrder 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The summarized quantity of all items that have been added to the child order from the blanket sales order.
		/// DAC Field Name: OrderQty 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Ordered Qty. 
		/// </summary>
		/// <remarks>
		/// If any items that are not from the current blanket sales order have been added to the child order,their quantity is not summed up to the value in this field.
		/// </remarks>
		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// The unique reference number of the order.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		/// <remarks>
		/// When the new sales order is saved for the first time, the system automatically generatesthis number by using the numbering sequence assigned to orders of SOOrderType.
		/// </remarks>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// The total amount of the document (in the currency of the document).
		/// DAC Field Name: CuryOrderTotal 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Total 
		/// </summary>
		[DataMember(Name="OrderTotal", EmitDefaultValue=false)]
		public DecimalValue? OrderTotal { get; set; }

		/// <summary>
		/// The type of the document, which is a part of the identifier of the order.The identifier of the order type.The field is included in the OrderType foreign key.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		/// <remarks>
		/// The type of the document, which is one of the predefined order types or a custom order type created byusing the Order Types (SO201000) form.
		/// </remarks>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// The total volume of goods according to the document.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Volume 
		/// </summary>
		[DataMember(Name="OrderVolume", EmitDefaultValue=false)]
		public DecimalValue? OrderVolume { get; set; }

		/// <summary>
		/// The total weight of the goods according to the document.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Order Weight 
		/// </summary>
		[DataMember(Name="OrderWeight", EmitDefaultValue=false)]
		public DecimalValue? OrderWeight { get; set; }

		/// <summary>
		/// The date when the customer wants to receive the goods.
		/// DAC Field Name: RequestDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Requested On 
		/// </summary>
		/// <remarks>
		/// This date provides the default values for the requestDate dates for order lines.
		/// </remarks>
		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOn { get; set; }

		/// <summary>
		/// The date when the ordered goods are scheduled to be shipped.
		/// DAC Field Name: ShipDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Sched. Shipment 
		/// </summary>
		/// <remarks>
		/// By default, it is the date that is specified in requestDate minus the number of lead days,but it is not earlier than the current business date.
		/// </remarks>
		[DataMember(Name="ScheduledShipment", EmitDefaultValue=false)]
		public DateTimeValue? ScheduledShipment { get; set; }

		/// <summary>
		/// The identifier of the shipping zone of the customer to be used tocalculate freight.The field is included in the ShippingZone foreign key.
		/// DAC Field Name: ShipZoneID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Shipping Zone 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShippingZone", EmitDefaultValue=false)]
		public StringValue? ShippingZone { get; set; }

		/// <summary>
		/// The identifier of the ship via code that represents the carrier andits service to be used for shipping the ordered goods.The field is included in the Carrier foreign key.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Ship Via 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		/// <remarks>
		/// For this ship via code, if Manual is specified as the freight calculation method, the freight amount mustbe specified in the Freight Price field.Changing the Ship Via code for an open sales order may update thecustomer tax zone field.
		/// </remarks>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.BAccount 
		/// Display Name: Customer Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

	}
}