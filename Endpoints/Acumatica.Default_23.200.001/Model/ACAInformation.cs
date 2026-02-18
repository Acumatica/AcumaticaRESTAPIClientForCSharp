using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ACAInformation : Entity
	{

		public List<ACAInfoDetail>? ACAInfoDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinimumIndividualContribution</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Minimum Individual Contribution</para>
		/// </summary>
		public DecimalValue? MinIndividualContribution { get; set; }

	}
}