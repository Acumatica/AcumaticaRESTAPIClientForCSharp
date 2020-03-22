using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class Adjustment : Entity
	{

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<AdjustmentDetail> Details { get; set; }

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue ExternalRef { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue TotalCost { get; set; }

		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue TotalQty { get; set; }

	}
}