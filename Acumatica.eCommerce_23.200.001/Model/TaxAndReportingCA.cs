using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class TaxAndReportingCA : Entity
	{

		[DataMember(Name="ReportingType", EmitDefaultValue=false)]
		public StringValue? ReportingType { get; set; }

		[DataMember(Name="SupplementalIncome", EmitDefaultValue=false)]
		public BooleanValue? SupplementalIncome { get; set; }

		[DataMember(Name="TaxDetailsCA", EmitDefaultValue=false)]
		public List<EarningCodeTaxDetailCA>? TaxDetailsCA { get; set; }

		[DataMember(Name="WageType", EmitDefaultValue=false)]
		public StringValue? WageType { get; set; }

	}
}