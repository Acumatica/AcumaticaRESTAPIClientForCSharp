using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class PayrollWCCCode : Entity, ITopLevelEntity
	{

		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="WCCCodes", EmitDefaultValue=false)]
		public List<WCCCode>? WCCCodes { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string WCCCodes = "WCCCodes";
			public const string WCCCodes_Files = "WCCCodes/Files";
			public const string WCCCodes_WCCCodeCostCodeSources = "WCCCodes/WCCCodeCostCodeSources";
			public const string WCCCodes_WCCCodeCostCodeSources_Files = "WCCCodes/WCCCodeCostCodeSources/Files";
			public const string WCCCodes_WCCCodeLaborItemSources = "WCCCodes/WCCCodeLaborItemSources";
			public const string WCCCodes_WCCCodeLaborItemSources_Files = "WCCCodes/WCCCodeLaborItemSources/Files";
			public const string WCCCodes_WCCCodeMaxInsurableWages = "WCCCodes/WCCCodeMaxInsurableWages";
			public const string WCCCodes_WCCCodeMaxInsurableWages_Files = "WCCCodes/WCCCodeMaxInsurableWages/Files";
			public const string WCCCodes_WCCCodeProjectSources = "WCCCodes/WCCCodeProjectSources";
			public const string WCCCodes_WCCCodeProjectSources_Files = "WCCCodes/WCCCodeProjectSources/Files";
			public const string WCCCodes_WCCCodeRates = "WCCCodes/WCCCodeRates";
			public const string WCCCodes_WCCCodeRates_Files = "WCCCodes/WCCCodeRates/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,WCCCodes,WCCCodes/Files,WCCCodes/WCCCodeCostCodeSources,WCCCodes/WCCCodeCostCodeSources/Files,WCCCodes/WCCCodeLaborItemSources,WCCCodes/WCCCodeLaborItemSources/Files,WCCCodes/WCCCodeMaxInsurableWages,WCCCodes/WCCCodeMaxInsurableWages/Files,WCCCodes/WCCCodeProjectSources,WCCCodes/WCCCodeProjectSources/Files,WCCCodes/WCCCodeRates,WCCCodes/WCCCodeRates/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}