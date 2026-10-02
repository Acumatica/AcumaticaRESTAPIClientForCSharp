using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class BusinessAccountLocation : Entity
	{

		#region Fields
		/// <summary>
		/// The human-readable identifier of the location that is specified by the user when they create a location.This field is a natural key as opposed to the LocationID surrogate key.
		/// <para>DAC Field Name: LocationCD</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// The price class of the customer.
		/// <para>DAC Field Name: CPriceClassID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Price Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// The customer's tax zone.
		/// <para>DAC Field Name: CTaxZoneID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// This field indicates whether the location is active.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The name of the location.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Location Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? LocationName { get; set; }

		/// <summary>
		/// This field indicates whether the location is default for the corresponding business account.
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Address__City</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		public StringValue? City { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Address__State</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		public StringValue? State { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Address__CountryID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		public StringValue? Country { get; set; }

		public StringValue? SalesAccount { get; set; }

		public StringValue? SalesSubaccount { get; set; }

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
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}