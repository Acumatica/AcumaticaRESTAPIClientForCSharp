using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class UnitsOfMeasure : Entity
	{

		[DataMember(Name="ConversionFactor", EmitDefaultValue=false)]
		public DecimalValue ConversionFactor { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="FromUOM", EmitDefaultValue=false)]
		public StringValue FromUOM { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="MultiplyOrDivide", EmitDefaultValue=false)]
		public StringValue MultiplyOrDivide { get; set; }

		[DataMember(Name="ToUOM", EmitDefaultValue=false)]
		public StringValue ToUOM { get; set; }

	}
}