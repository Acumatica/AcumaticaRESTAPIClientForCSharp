using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class DiscountBreakpointDetail : Entity_v4
	{

		[DataMember(Name="BreakAmount", EmitDefaultValue=false)]
		public DecimalValue BreakAmount { get; set; }

		[DataMember(Name="BreakQty", EmitDefaultValue=false)]
		public DecimalValue BreakQty { get; set; }

		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue DiscountAmount { get; set; }

		[DataMember(Name="DiscountDetailID", EmitDefaultValue=false)]
		public IntValue DiscountDetailID { get; set; }

		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue DiscountPercent { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="FreeItemQty", EmitDefaultValue=false)]
		public DecimalValue FreeItemQty { get; set; }

		[DataMember(Name="LastBreakAmount", EmitDefaultValue=false)]
		public DecimalValue LastBreakAmount { get; set; }

		[DataMember(Name="LastBreakQty", EmitDefaultValue=false)]
		public DecimalValue LastBreakQty { get; set; }

		[DataMember(Name="LastDiscountAmount", EmitDefaultValue=false)]
		public DecimalValue LastDiscountAmount { get; set; }

		[DataMember(Name="LastDiscountPercent", EmitDefaultValue=false)]
		public DecimalValue LastDiscountPercent { get; set; }

		[DataMember(Name="LastFreeItemQty", EmitDefaultValue=false)]
		public DecimalValue LastFreeItemQty { get; set; }

		[DataMember(Name="PendingBreakAmount", EmitDefaultValue=false)]
		public DecimalValue PendingBreakAmount { get; set; }

		[DataMember(Name="PendingBreakQty", EmitDefaultValue=false)]
		public DecimalValue PendingBreakQty { get; set; }

		[DataMember(Name="PendingDate", EmitDefaultValue=false)]
		public DateTimeValue PendingDate { get; set; }

		[DataMember(Name="PendingDiscountAmount", EmitDefaultValue=false)]
		public DecimalValue PendingDiscountAmount { get; set; }

		[DataMember(Name="PendingDiscountPercent", EmitDefaultValue=false)]
		public DecimalValue PendingDiscountPercent { get; set; }

		[DataMember(Name="PendingFreeItemQty", EmitDefaultValue=false)]
		public DecimalValue PendingFreeItemQty { get; set; }

	}
}