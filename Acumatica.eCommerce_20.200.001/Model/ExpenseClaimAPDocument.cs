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
	public class ExpenseClaimAPDocument : Entity
	{

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}