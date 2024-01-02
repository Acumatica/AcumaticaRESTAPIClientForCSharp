using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EarningCodeTaxDetailCA : Entity
	{

		[DataMember(Name="Taxability", EmitDefaultValue=false)]
		public StringValue? Taxability { get; set; }

		[DataMember(Name="TaxCode", EmitDefaultValue=false)]
		public StringValue? TaxCode { get; set; }

		[DataMember(Name="TaxName", EmitDefaultValue=false)]
		public StringValue? TaxName { get; set; }

	}
}