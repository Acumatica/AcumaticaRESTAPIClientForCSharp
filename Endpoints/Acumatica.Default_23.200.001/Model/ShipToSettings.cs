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
	public class ShipToSettings : Entity
	{

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public Address? ShipToAddress { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address is overriden.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.SO.SOShipmentAddress</para>
		/// <para>Display Name: Override Address</para>
		/// </summary>
		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressOverride { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact? ShipToContact { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact is overriden.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.SO.SOShipmentContact</para>
		/// <para>Display Name: Override Contact</para>
		/// </summary>
		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address has been validated with a third-party specialized software or service.
		/// <para>DAC Field Name: IsValidated</para>
		/// <para>DAC: PX.Objects.SO.SOShipmentAddress</para>
		/// </summary>
		[DataMember(Name="Validated", EmitDefaultValue=false)]
		public BooleanValue? Validated { get; set; }

	}
}