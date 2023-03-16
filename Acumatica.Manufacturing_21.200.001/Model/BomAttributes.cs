using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class BomAttributes : Entity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeDetail> Attributes { get; set; }

		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue BOMID { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}