using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class MRPDetailInquiry : Entity
	{

		[DataMember(Name="BaseUnit", EmitDefaultValue=false)]
		public StringValue BaseUnit { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LotQty", EmitDefaultValue=false)]
		public DecimalValue LotQty { get; set; }

		[DataMember(Name="MaxOrderQty", EmitDefaultValue=false)]
		public DecimalValue MaxOrderQty { get; set; }

		[DataMember(Name="MinOrderQty", EmitDefaultValue=false)]
		public DecimalValue MinOrderQty { get; set; }

		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue QtyOnHand { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<MRPDetailInquiryResult> Results { get; set; }

		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue SafetyStock { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}