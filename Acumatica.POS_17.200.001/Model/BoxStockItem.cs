using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class BoxStockItem : Entity
	{

		[DataMember(Name="BoxID", EmitDefaultValue=false)]
		public StringValue BoxID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue MaxQty { get; set; }

		[DataMember(Name="MaxVolume", EmitDefaultValue=false)]
		public DecimalValue MaxVolume { get; set; }

		[DataMember(Name="MaxWeight", EmitDefaultValue=false)]
		public DecimalValue MaxWeight { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}