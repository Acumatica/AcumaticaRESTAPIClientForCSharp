using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class DeductionOrBenefitTaxDetailCA : Entity
	{

		[DataMember(Name="Benefitincreasestaxablewage", EmitDefaultValue=false)]
		public BooleanValue Benefitincreasestaxablewage { get; set; }

		[DataMember(Name="Deductiondecreasestaxablewage", EmitDefaultValue=false)]
		public BooleanValue Deductiondecreasestaxablewage { get; set; }

		[DataMember(Name="TaxCode", EmitDefaultValue=false)]
		public StringValue TaxCode { get; set; }

		[DataMember(Name="TaxName", EmitDefaultValue=false)]
		public StringValue TaxName { get; set; }

	}
}