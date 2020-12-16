using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class VendorPricesInquiry : Entity_v4
	{

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue ProductManager { get; set; }

		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue ProductWorkgroup { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue Vendor { get; set; }

		[DataMember(Name="VendorPriceDetails", EmitDefaultValue=false)]
		public List<VendorPriceDetail> VendorPriceDetails { get; set; }

	}
}