using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class MatrixItems : Entity_v4
	{

		[DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
		public DecimalValue DefaultPrice { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue MSRP { get; set; }

		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue ItemStatus { get; set; }

		[DataMember(Name="ExportToExternal", EmitDefaultValue=false)]
		public BooleanValue ExportToExternal { get; set; }

	}
}