using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class BCShipments : Entity_v4
	{

		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue LastModified { get; set; }

		[DataMember(Name="ShippingNoteID", EmitDefaultValue=false)]
		public GuidValue ShippingNoteID { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue OrderNbr { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="BindingID", EmitDefaultValue=false)]
		public IntValue BindingID { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<BCShipmentsResult> Results { get; set; }

	}
}