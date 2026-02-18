using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class BatchOvertimeRules : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ApplyOvertimeRules</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Apply Overtime Rules for the Document</para>
		/// </summary>
		public BooleanValue? ApplyOvertimeRulesfortheDocument { get; set; }

		public List<BatchOvertimeRulesDetail>? OvertimeRulesDetails { get; set; }

	}
}