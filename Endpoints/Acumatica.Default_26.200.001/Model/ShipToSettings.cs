using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ShipToSettings : Entity
	{

		#region Fields
		/// <summary>
		/// Specifies (if set to true) that the address is overriden.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.SO.SOShipmentAddress</para>
		/// <para>Display Name: Override Address</para>
		/// </summary>
		public BooleanValue? ShipToAddressOverride { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address has been validated with a third-party specialized software or service.
		/// <para>DAC Field Name: IsValidated</para>
		/// <para>DAC: PX.Objects.SO.SOShipmentAddress</para>
		/// </summary>
		public BooleanValue? Validated { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact is overriden.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.SO.SOShipmentContact</para>
		/// <para>Display Name: Override Contact</para>
		/// </summary>
		public BooleanValue? ShipToContactOverride { get; set; }

		#endregion

		#region LinkedEntities
		public Address? ShipToAddress { get; set; }

		public DocContact? ShipToContact { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string ShipToAddress = "ShipToAddress";
			public const string ShipToContact = "ShipToContact";

			//Intentionally excluded
			//public const string All = "ShipToAddress,ShipToContact";
		}
	}
}