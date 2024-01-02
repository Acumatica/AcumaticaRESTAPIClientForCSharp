using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Totals : Entity
	{

		[DataMember(Name="DiscountTotal", EmitDefaultValue=false)]
		public DecimalValue? DiscountTotal { get; set; }

		[DataMember(Name="LineTotalAmount", EmitDefaultValue=false)]
		public DecimalValue? LineTotalAmount { get; set; }

		[DataMember(Name="MiscTotalAmount", EmitDefaultValue=false)]
		public DecimalValue? MiscTotalAmount { get; set; }

		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		[DataMember(Name="UnbilledAmount", EmitDefaultValue=false)]
		public DecimalValue? UnbilledAmount { get; set; }

		[DataMember(Name="UnbilledQty", EmitDefaultValue=false)]
		public DecimalValue? UnbilledQty { get; set; }

		[DataMember(Name="UnpaidBalance", EmitDefaultValue=false)]
		public DecimalValue? UnpaidBalance { get; set; }

	}
}