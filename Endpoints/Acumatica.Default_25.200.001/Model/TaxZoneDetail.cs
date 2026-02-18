using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class TaxZoneDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: TaxZone__DfltTaxCategoryID</para>
		/// <para>DAC: PX.Objects.TX.TaxZoneDet</para>
		/// </summary>
		public StringValue? DefaultTaxCategory { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxZone__Descr</para>
		/// <para>DAC: PX.Objects.TX.TaxZoneDet</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The tax ID. This is the key field, which can be specified by the user.
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// The foreign key to TaxZone.
		/// <para>DAC: PX.Objects.TX.TaxZoneDet</para>
		/// <para>Display Name: Tax Zone ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? TaxZoneID { get; set; }

	}
}