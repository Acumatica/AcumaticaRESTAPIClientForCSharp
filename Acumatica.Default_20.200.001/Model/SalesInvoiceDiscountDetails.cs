using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SalesInvoiceDiscountDetails : Entity_v4
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DiscountableAmount", EmitDefaultValue=false)]
		public DecimalValue DiscountableAmount { get; set; }

		[DataMember(Name="DiscountableQty", EmitDefaultValue=false)]
		public DecimalValue DiscountableQty { get; set; }

		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue DiscountAmount { get; set; }

		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue DiscountCode { get; set; }

		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue DiscountPercent { get; set; }

		[DataMember(Name="ExternalDiscountCode", EmitDefaultValue=false)]
		public StringValue ExternalDiscountCode { get; set; }

		[DataMember(Name="FreeItem", EmitDefaultValue=false)]
		public StringValue FreeItem { get; set; }

		[DataMember(Name="FreeItemQty", EmitDefaultValue=false)]
		public DecimalValue FreeItemQty { get; set; }

		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue ManualDiscount { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue OrderNbr { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="SequenceID", EmitDefaultValue=false)]
		public StringValue SequenceID { get; set; }

		[DataMember(Name="SkipDiscount", EmitDefaultValue=false)]
		public BooleanValue SkipDiscount { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

	}
}