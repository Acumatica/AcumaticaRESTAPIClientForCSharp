using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class BillToSettings : Entity_v4
	{

		[DataMember(Name="BillToAddress", EmitDefaultValue=false)]
		public Address BillToAddress { get; set; }

		[DataMember(Name="BillToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue BillToAddressOverride { get; set; }

		[DataMember(Name="BillToContact", EmitDefaultValue=false)]
		public DocContact BillToContact { get; set; }

		[DataMember(Name="BillToContactOverride", EmitDefaultValue=false)]
		public BooleanValue BillToContactOverride { get; set; }

		[DataMember(Name="CustomerLocation", EmitDefaultValue=false)]
		public StringValue CustomerLocation { get; set; }

	}
}