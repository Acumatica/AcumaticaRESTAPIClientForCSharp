using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	public class SalesInvoiceAddress : Entity
	{

		/// <summary>
		/// The first line of the street address.
		/// <para>DAC: PX.Objects.AR.ARShippingAddress</para>
		/// <para>Display Name: Address Line 1</para>
		/// <para>SQL Type: nvarchar(2500)</para>
		/// </summary>
		public StringValue? AddressLine1 { get; set; }

		/// <summary>
		/// The second line of the street address.
		/// <para>DAC: PX.Objects.AR.ARShippingAddress</para>
		/// <para>Display Name: Address Line 2</para>
		/// <para>SQL Type: nvarchar(2500)</para>
		/// </summary>
		public StringValue? AddressLine2 { get; set; }

		/// <summary>
		/// The name of the city or inhabited locality.
		/// <para>DAC: PX.Objects.AR.ARShippingAddress</para>
		/// <para>SQL Type: nvarchar(2500)</para>
		/// </summary>
		public StringValue? City { get; set; }

		/// <summary>
		/// The identifier of the Country record.
		/// <para>DAC Field Name: CountryID</para>
		/// <para>DAC: PX.Objects.AR.ARShippingAddress</para>
		/// <para>SQL Type: nvarchar(2500)</para>
		/// </summary>
		public StringValue? Country { get; set; }

		/// <summary>
		/// The postal code.
		/// <para>DAC: PX.Objects.AR.ARShippingAddress</para>
		/// <para>Display Name: Postal Code</para>
		/// <para>SQL Type: varchar(2500)</para>
		/// </summary>
		public StringValue? PostalCode { get; set; }

		/// <summary>
		/// The name of the state.
		/// <para>DAC: PX.Objects.AR.ARShippingAddress</para>
		/// <para>SQL Type: nvarchar(2500)</para>
		/// </summary>
		public StringValue? State { get; set; }

	}
}