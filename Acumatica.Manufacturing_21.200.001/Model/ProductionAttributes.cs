using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ProductionAttributes : Entity
	{

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<ProductionAttributesDetail> Detail { get; set; }

		[DataMember(Name="OrderAttributes", EmitDefaultValue=false)]
		public BooleanValue OrderAttributes { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue ProductionNbr { get; set; }

		[DataMember(Name="TransactionAttributes", EmitDefaultValue=false)]
		public BooleanValue TransactionAttributes { get; set; }

	}
}