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
	public class ShipToSettings : Entity
	{

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public Address? ShipToAddress { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address is overriden.
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.SO.SOShipmentAddress 
		/// Display Name: Override Address 
		/// </summary>
		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressOverride { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact? ShipToContact { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact is overriden.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.SO.SOShipmentContact 
		/// Display Name: Override Contact 
		/// </summary>
		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address has been validated with a third-party specialized software or service.
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.SO.SOShipmentAddress 
		/// </summary>
		[DataMember(Name="Validated", EmitDefaultValue=false)]
		public BooleanValue? Validated { get; set; }

	}
}