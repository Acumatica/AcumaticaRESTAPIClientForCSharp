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
	public class ProFormaTaxDetail : Entity
	{

		[DataMember(Name="RetainedTax", EmitDefaultValue=false)]
		public DecimalValue? RetainedTax { get; set; }

		[DataMember(Name="RetainedTaxable", EmitDefaultValue=false)]
		public DecimalValue? RetainedTaxable { get; set; }

		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmount { get; set; }

		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

	}
}