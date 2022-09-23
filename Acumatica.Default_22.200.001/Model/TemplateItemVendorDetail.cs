using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class TemplateItemVendorDetail : Entity_v4
	{

		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue VendorID { get; set; }

		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue VendorName { get; set; }

		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue Default { get; set; }

	}
}