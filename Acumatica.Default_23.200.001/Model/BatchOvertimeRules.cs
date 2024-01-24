using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class BatchOvertimeRules : Entity
	{

		[DataMember(Name="ApplyOvertimeRulesfortheDocument", EmitDefaultValue=false)]
		public BooleanValue? ApplyOvertimeRulesfortheDocument { get; set; }

		[DataMember(Name="OvertimeRulesDetails", EmitDefaultValue=false)]
		public List<BatchOvertimeRulesDetail>? OvertimeRulesDetails { get; set; }

	}
}