using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class BillToSettings : Entity
	{

		[DataMember(Name="BillToAddress", EmitDefaultValue=false)]
		public Address BillToAddress { get; set; }

		[DataMember(Name="BillToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue BillToAddressOverride { get; set; }

		[DataMember(Name="BillToContact", EmitDefaultValue=false)]
		public DocContact BillToContact { get; set; }

		[DataMember(Name="BillToContactOverride", EmitDefaultValue=false)]
		public BooleanValue BillToContactOverride { get; set; }

	}
}