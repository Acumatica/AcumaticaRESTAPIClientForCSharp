using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM310000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class VendorShipment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: ControlQty 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Control Quantity 
		/// </summary>
		[DataMember(Name="ControlQuantity", EmitDefaultValue=false)]
		public DecimalValue? ControlQuantity { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<VendorShipmentDetails>? Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC Field Name: EmployeeID 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Shipment Date 
		/// </summary>
		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue? ShipmentDate { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentNbr 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Shipment ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ShipmentID", EmitDefaultValue=false)]
		public StringValue? ShipmentID { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentQty 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Shipped Quantity 
		/// </summary>
		[DataMember(Name="ShippedQuantity", EmitDefaultValue=false)]
		public DecimalValue? ShippedQuantity { get; set; }

		[DataMember(Name="ShippingSettings", EmitDefaultValue=false)]
		public ShipToSettings? ShippingSettings { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: ShipmentType 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}