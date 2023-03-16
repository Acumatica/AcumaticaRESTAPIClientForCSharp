using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class NonStockItemVendorDetail : Entity
	{

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue Default { get; set; }

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue VendorID { get; set; }

		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue VendorName { get; set; }

	}
}