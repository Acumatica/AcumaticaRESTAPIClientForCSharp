using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class PhysicalInventoryReview : Entity_v4
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<PhysicalInventoryReviewDetail> Details { get; set; }

		[DataMember(Name="FreezeDate", EmitDefaultValue=false)]
		public DateTimeValue FreezeDate { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TotalPhysicalQty", EmitDefaultValue=false)]
		public DecimalValue TotalPhysicalQty { get; set; }

		[DataMember(Name="TotalVarianceCost", EmitDefaultValue=false)]
		public DecimalValue TotalVarianceCost { get; set; }

		[DataMember(Name="TotalVarianceQty", EmitDefaultValue=false)]
		public DecimalValue TotalVarianceQty { get; set; }

		[DataMember(Name="TypeID", EmitDefaultValue=false)]
		public StringValue TypeID { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

	}
}