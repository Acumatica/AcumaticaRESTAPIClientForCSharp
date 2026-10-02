using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class BatchOvertimeRules : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: ApplyOvertimeRules</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Apply Overtime Rules for the Document</para>
		/// </summary>
		public BooleanValue? ApplyOvertimeRulesfortheDocument { get; set; }

		#endregion

		#region Details
		public List<BatchOvertimeRulesDetail>? OvertimeRulesDetails { get; set; }

		#endregion

	}
}