using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ShippingInstructions : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: ShipDestType</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Shipping Destination Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringSingleSelectValue? ShippingDestinationType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipToBAccountID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Ship To</para>
		/// </summary>
		public StringValue? ShipTo { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ShipToLocationID</para>
		/// <para>DAC: PX.Objects.PO.POOrder</para>
		/// <para>Display Name: Shipping Location</para>
		/// </summary>
		public StringValue? ShippingLocation { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address is overriden.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.PO.PORemitAddress</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? ShipToAddressOverride { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the address has been validated with a third-party specialized software or service.
		/// <para>DAC Field Name: IsValidated</para>
		/// <para>DAC: PX.Objects.PO.PORemitAddress</para>
		/// <para>Display Name: Validated</para>
		/// </summary>
		public BooleanValue? ShipToAddressValidated { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact is overriden.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.PO.PORemitContact</para>
		/// <para>Display Name: Override</para>
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