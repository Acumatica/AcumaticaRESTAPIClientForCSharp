using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen SO302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Shipment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseCuryID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ControlQty 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ControlQty", EmitDefaultValue=false)]
		public DecimalValue? ControlQty { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SampleCuryRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrencyRateTypeID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryViewState 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyViewState", EmitDefaultValue=false)]
		public BooleanValue? CurrencyViewState { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		[DataMember(Name="CreateNewShipmentForEveryOrder", EmitDefaultValue=false)]
		public BooleanValue? CreateNewShipmentForEveryOrder { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ShipmentDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipmentDesc 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryEffDate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FOBPoint 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideFreightAmount 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideFreightPrice", EmitDefaultValue=false)]
		public BooleanValue? OverrideFreightPrice { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryFreightAmt 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FreightPrice", EmitDefaultValue=false)]
		public DecimalValue? FreightPrice { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryFreightCost 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FreightCurrencyID", EmitDefaultValue=false)]
		public StringValue? FreightCurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: GroundCollect 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="GroundCollect", EmitDefaultValue=false)]
		public BooleanValue? GroundCollect { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Insurance 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue? Insurance { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Operation 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public StringValue? Operation { get; set; }

		[DataMember(Name="Orders", EmitDefaultValue=false)]
		public List<ShipmentOrderDetail>? Orders { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PackageCount 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PackageCount", EmitDefaultValue=false)]
		public IntValue? PackageCount { get; set; }

		[DataMember(Name="Packages", EmitDefaultValue=false)]
		public List<ShipmentPackage>? Packages { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PackageWeight 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PackageWeight", EmitDefaultValue=false)]
		public DecimalValue? PackageWeight { get; set; }

		[DataMember(Name="Picked", EmitDefaultValue=false)]
		public BooleanValue? Picked { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SampleRecipRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Resedential 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SaturdayDelivery 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipDate 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue? ShipmentDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipmentNbr 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue? ShipmentNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipmentQty 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipmentVolume 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippedVolume", EmitDefaultValue=false)]
		public DecimalValue? ShippedVolume { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipmentWeight 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippedWeight", EmitDefaultValue=false)]
		public DecimalValue? ShippedWeight { get; set; }

		[DataMember(Name="ShippingSettings", EmitDefaultValue=false)]
		public ShipToSettings? ShippingSettings { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipTermsID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipZoneID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShippingZoneID", EmitDefaultValue=false)]
		public StringValue? ShippingZoneID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipVia 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DestinationSiteID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ToWarehouseID", EmitDefaultValue=false)]
		public StringValue? ToWarehouseID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShipmentType 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="UnlimitedPackages", EmitDefaultValue=false)]
		public BooleanValue? UnlimitedPackages { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UseCustomerAccount 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseCustomersAccount", EmitDefaultValue=false)]
		public BooleanValue? UseCustomersAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
		public StringValue? WorkgroupID { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}