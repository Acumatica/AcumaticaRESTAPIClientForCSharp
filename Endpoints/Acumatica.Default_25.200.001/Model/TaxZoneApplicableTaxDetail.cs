using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class TaxZoneApplicableTaxDetail : Entity
	{

		/// <summary>
		/// The field contains ID of a tax that would be used to create tax transactions in documents.
		/// <para>DAC: PX.Objects.TX.TaxZone</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? TaxID { get; set; }

	}
}