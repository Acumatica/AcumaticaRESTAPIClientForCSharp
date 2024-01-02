using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.GLConsolidation_22_200_001.Model
{
	[DataContract]
	public class ConsolidationItem : Entity
	{

		[DataMember(Name="AccountCD", EmitDefaultValue=false)]
		public StringValue? AccountCD { get; set; }

		[DataMember(Name="ConsolAmtCredit", EmitDefaultValue=false)]
		public DecimalValue? ConsolAmtCredit { get; set; }

		[DataMember(Name="ConsolAmtDebit", EmitDefaultValue=false)]
		public DecimalValue? ConsolAmtDebit { get; set; }

		[DataMember(Name="FinPeriodID", EmitDefaultValue=false)]
		public StringValue? FinPeriodID { get; set; }

		[DataMember(Name="MappedValue", EmitDefaultValue=false)]
		public StringValue? MappedValue { get; set; }

		[DataMember(Name="MappedValueLength", EmitDefaultValue=false)]
		public IntValue? MappedValueLength { get; set; }

	}
}