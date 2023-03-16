using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class TaxesDecreasingApplWageDetail : Entity
	{

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="TaxCode", EmitDefaultValue=false)]
		public StringValue TaxCode { get; set; }

		[DataMember(Name="TaxName", EmitDefaultValue=false)]
		public StringValue TaxName { get; set; }

	}
}