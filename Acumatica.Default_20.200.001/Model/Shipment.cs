using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Shipment : Entity_v4
	{

		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue BaseCurrencyID { get; set; }

		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue ControlQty { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue CurrencyRate { get; set; }

		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue CurrencyRateTypeID { get; set; }

		[DataMember(Name="CurrencyViewState", EmitDefaultValue=false)]
		public BooleanValue CurrencyViewState { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue CustomerID { get; set; }

		[DataMember(Name="CreateNewShipmentForEveryOrder", EmitDefaultValue=false)]
		public BooleanValue CreateNewShipmentForEveryOrder { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ShipmentDetail> Details { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue FOBPoint { get; set; }

		[DataMember(Name="OverrideFreightPrice", EmitDefaultValue=false)]
		public BooleanValue OverrideFreightPrice { get; set; }

		[DataMember(Name="FreightAmount", EmitDefaultValue=false)]
		public DecimalValue FreightAmount { get; set; }

		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue FreightCost { get; set; }

		[DataMember(Name="FreightCurrencyID", EmitDefaultValue=false)]
		public StringValue FreightCurrencyID { get; set; }

		[DataMember(Name="GroundCollect", EmitDefaultValue=false)]
		public BooleanValue GroundCollect { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue Insurance { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public StringValue Operation { get; set; }

		[DataMember(Name="Orders", EmitDefaultValue=false)]
		public List<ShipmentOrderDetail> Orders { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="PackageCount", EmitDefaultValue=false)]
		public IntValue PackageCount { get; set; }

		[DataMember(Name="Packages", EmitDefaultValue=false)]
		public List<ShipmentPackage> Packages { get; set; }

		[DataMember(Name="PackageWeight", EmitDefaultValue=false)]
		public DecimalValue PackageWeight { get; set; }

		[DataMember(Name="Picked", EmitDefaultValue=false)]
		public BooleanValue Picked { get; set; }

		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue ReciprocalRate { get; set; }

		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue ResidentialDelivery { get; set; }

		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue SaturdayDelivery { get; set; }

		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue ShipmentDate { get; set; }

		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue ShipmentNbr { get; set; }

		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue ShippedQty { get; set; }

		[DataMember(Name="ShippedVolume", EmitDefaultValue=false)]
		public DecimalValue ShippedVolume { get; set; }

		[DataMember(Name="ShippedWeight", EmitDefaultValue=false)]
		public DecimalValue ShippedWeight { get; set; }

		[DataMember(Name="ShippingSettings", EmitDefaultValue=false)]
		public ShipToSettings ShippingSettings { get; set; }

		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue ShippingTerms { get; set; }

		[DataMember(Name="ShippingZoneID", EmitDefaultValue=false)]
		public StringValue ShippingZoneID { get; set; }

		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue ShipVia { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="ToWarehouseID", EmitDefaultValue=false)]
		public StringValue ToWarehouseID { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="UseCustomersAccount", EmitDefaultValue=false)]
		public BooleanValue UseCustomersAccount { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

		[DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
		public StringValue WorkgroupID { get; set; }

	}
}