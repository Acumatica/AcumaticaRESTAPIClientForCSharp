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
	public class RecalculatePricesDiscountsParameters
	{
		public RecalculatePricesDiscountsParameters() { }

		[DataMember(Name="OverrideManualDiscounts", EmitDefaultValue=false)]
		public BooleanValue? OverrideManualDiscounts { get; set; }
		[DataMember(Name="OverrideManualDocGroupDiscounts", EmitDefaultValue=false)]
		public BooleanValue? OverrideManualDocGroupDiscounts { get; set; }
		[DataMember(Name="OverrideManualPrices", EmitDefaultValue=false)]
		public BooleanValue? OverrideManualPrices { get; set; }
		[DataMember(Name="RecalcDiscounts", EmitDefaultValue=false)]
		public BooleanValue? RecalcDiscounts { get; set; }
		[DataMember(Name="RecalcUnitPrices", EmitDefaultValue=false)]
		public BooleanValue? RecalcUnitPrices { get; set; }
	}
}