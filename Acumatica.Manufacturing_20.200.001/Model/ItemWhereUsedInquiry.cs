using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class ItemWhereUsedInquiry : Entity
	{

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="MultiLevel", EmitDefaultValue=false)]
		public BooleanValue MultiLevel { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<ItemWhereUsedRow> Results { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}