using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class SalesPersonDetail : Entity
	{

		[DataMember(Name="CommissionableAmount", EmitDefaultValue=false)]
		public DecimalValue? CommissionableAmount { get; set; }

		[DataMember(Name="CommissionAmount", EmitDefaultValue=false)]
		public DecimalValue? CommissionAmount { get; set; }

		[DataMember(Name="CommissionPercent", EmitDefaultValue=false)]
		public DecimalValue? CommissionPercent { get; set; }

		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue? SalespersonID { get; set; }

	}
}