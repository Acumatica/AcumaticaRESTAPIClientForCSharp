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
	public class OpportunityDiscount : Entity
	{

		[DataMember(Name="DiscountableAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountableAmount { get; set; }

		[DataMember(Name="DiscountableQty", EmitDefaultValue=false)]
		public DecimalValue? DiscountableQty { get; set; }

		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? DiscountPercent { get; set; }

		[DataMember(Name="FreeItem", EmitDefaultValue=false)]
		public StringValue? FreeItem { get; set; }

		[DataMember(Name="FreeItemQty", EmitDefaultValue=false)]
		public DecimalValue? FreeItemQty { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue? ManualDiscount { get; set; }

		[DataMember(Name="SequenceID", EmitDefaultValue=false)]
		public StringValue? SequenceID { get; set; }

		[DataMember(Name="SkipDiscount", EmitDefaultValue=false)]
		public BooleanValue? SkipDiscount { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}