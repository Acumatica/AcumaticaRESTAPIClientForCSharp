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
	public class TaxDetail : Entity
	{

		[DataMember(Name="CustomerTaxZone", EmitDefaultValue=false)]
		public StringValue? CustomerTaxZone { get; set; }

		[DataMember(Name="IncludeInVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeInVATExemptTotal { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue? PendingVAT { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue? ReverseVAT { get; set; }

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