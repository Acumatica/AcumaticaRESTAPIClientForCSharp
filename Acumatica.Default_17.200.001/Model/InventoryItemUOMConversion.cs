using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class InventoryItemUOMConversion : Entity_v3
	{

		[DataMember(Name="ConversionFactor", EmitDefaultValue=false)]
		public DecimalValue ConversionFactor { get; set; }

		[DataMember(Name="FromUOM", EmitDefaultValue=false)]
		public StringValue FromUOM { get; set; }

		[DataMember(Name="MultiplyOrDivide", EmitDefaultValue=false)]
		public StringValue MultiplyOrDivide { get; set; }

		[DataMember(Name="ToUOM", EmitDefaultValue=false)]
		public StringValue ToUOM { get; set; }

	}
}