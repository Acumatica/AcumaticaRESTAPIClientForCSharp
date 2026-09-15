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
	public class ChangeOrderTaxSettings : Entity
	{

		[DataMember(Name="TaxCalculationMode", EmitDefaultValue=false)]
		public StringValue? TaxCalculationMode { get; set; }

		[DataMember(Name="TaxExemptionNumber", EmitDefaultValue=false)]
		public StringValue? TaxExemptionNumber { get; set; }

		[DataMember(Name="TaxExemptionType", EmitDefaultValue=false)]
		public StringValue? TaxExemptionType { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

	}
}