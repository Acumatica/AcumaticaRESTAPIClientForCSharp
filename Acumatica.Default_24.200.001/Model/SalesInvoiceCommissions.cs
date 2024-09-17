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
	public class SalesInvoiceCommissions : Entity
	{

		[DataMember(Name="CommissionAmount", EmitDefaultValue=false)]
		public DecimalValue? CommissionAmount { get; set; }

		[DataMember(Name="SalesPersons", EmitDefaultValue=false)]
		public List<SalesInvoiceSalesPersonDetail>? SalesPersons { get; set; }

		[DataMember(Name="TotalCommissionableAmount", EmitDefaultValue=false)]
		public DecimalValue? TotalCommissionableAmount { get; set; }

	}
}