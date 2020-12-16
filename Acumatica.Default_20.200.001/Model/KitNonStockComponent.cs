using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class KitNonStockComponent : Entity_v4
	{

		[DataMember(Name="AllowComponentQtyVariance", EmitDefaultValue=false)]
		public BooleanValue AllowComponentQtyVariance { get; set; }

		[DataMember(Name="ComponentQty", EmitDefaultValue=false)]
		public DecimalValue ComponentQty { get; set; }

		[DataMember(Name="MaxComponentQty", EmitDefaultValue=false)]
		public DecimalValue MaxComponentQty { get; set; }

		[DataMember(Name="MinComponentQty", EmitDefaultValue=false)]
		public DecimalValue MinComponentQty { get; set; }

		[DataMember(Name="NonStockInventoryID", EmitDefaultValue=false)]
		public StringValue NonStockInventoryID { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}