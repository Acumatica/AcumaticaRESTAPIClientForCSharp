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
	public class SrvOrdTaxDetails : Entity
	{

		[DataMember(Name="IncludeinVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeinVATExemptTotal { get; set; }

		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue? PendingVAT { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue? ReverseVAT { get; set; }

		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue? ServiceOrderNbr { get; set; }

		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		[DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
		public BooleanValue? StatisticalVAT { get; set; }

		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmount { get; set; }

		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue? TaxType { get; set; }

	}
}