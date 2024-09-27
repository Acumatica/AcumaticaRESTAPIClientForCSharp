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
	public class ShippingInstructions : Entity
	{

		/// <summary>
		/// DAC Field Name: ShipDestType 
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Shipping Destination Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ShippingDestinationType", EmitDefaultValue=false)]
		public StringValue? ShippingDestinationType { get; set; }

		/// <summary>
		/// DAC Field Name: ShipToLocationID 
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Shipping Location 
		/// </summary>
		[DataMember(Name="ShippingLocation", EmitDefaultValue=false)]
		public StringValue? ShippingLocation { get; set; }

		/// <summary>
		/// DAC Field Name: ShipToBAccountID 
		/// DAC: PX.Objects.PO.POOrder 
		/// Display Name: Ship To 
		/// </summary>
		[DataMember(Name="ShipTo", EmitDefaultValue=false)]
		public StringValue? ShipTo { get; set; }

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public Address? ShipToAddress { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address is overriden.
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.PO.PORemitAddress 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressOverride { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address has been validated with a third-party specialized software or service.
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.PO.PORemitAddress 
		/// Display Name: Validated 
		/// </summary>
		[DataMember(Name="ShipToAddressValidated", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressValidated { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact? ShipToContact { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact is overriden.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.PO.PORemitContact 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.PO.POOrder 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}