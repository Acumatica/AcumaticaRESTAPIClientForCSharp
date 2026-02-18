using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ShipToSettings : Entity
	{

		public Address? ShipToAddress { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address is overriden.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.SO.SOShipmentAddress</para>
		/// <para>Display Name: Override Address</para>
		/// </summary>
		public BooleanValue? ShipToAddressOverride { get; set; }

		public DocContact? ShipToContact { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact is overriden.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.SO.SOShipmentContact</para>
		/// <para>Display Name: Override Contact</para>
		/// </summary>
		public BooleanValue? ShipToContactOverride { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address has been validated with a third-party specialized software or service.
		/// <para>DAC Field Name: IsValidated</para>
		/// <para>DAC: PX.Objects.SO.SOShipmentAddress</para>
		/// </summary>
		public BooleanValue? Validated { get; set; }

	}
}