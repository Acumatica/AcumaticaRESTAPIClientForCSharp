using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class PurchasingDetail : Entity_v4
	{

		[DataMember(Name="POOrderLineNbr", EmitDefaultValue=false)]
		public IntValue POOrderLineNbr { get; set; }

		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue POOrderNbr { get; set; }

		[DataMember(Name="POOrderType", EmitDefaultValue=false)]
		public StringValue POOrderType { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

	}
}