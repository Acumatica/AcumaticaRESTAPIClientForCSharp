using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class PurchaseSettings : Entity_v3
	{

		[DataMember(Name="POSiteID", EmitDefaultValue=false)]
		public StringValue POSiteID { get; set; }

		[DataMember(Name="POSource", EmitDefaultValue=false)]
		public StringValue POSource { get; set; }

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue VendorID { get; set; }

	}
}