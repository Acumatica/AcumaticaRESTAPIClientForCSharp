using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class BatchOvertimeRules : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: ApplyOvertimeRules</para>
		/// <para>DAC: PX.Objects.PR.PRBatch</para>
		/// <para>Display Name: Apply Overtime Rules for the Document</para>
		/// </summary>
		[DataMember(Name="ApplyOvertimeRulesfortheDocument", EmitDefaultValue=false)]
		public BooleanValue? ApplyOvertimeRulesfortheDocument { get; set; }

		[DataMember(Name="OvertimeRulesDetails", EmitDefaultValue=false)]
		public List<BatchOvertimeRulesDetail>? OvertimeRulesDetails { get; set; }

	}
}