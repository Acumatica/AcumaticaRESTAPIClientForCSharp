using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class TaxSettingsUS : Entity_v4
	{

		[DataMember(Name="AllowSupplementalElection", EmitDefaultValue=false)]
		public BooleanValue AllowSupplementalElection { get; set; }

		[DataMember(Name="CodeType", EmitDefaultValue=false)]
		public StringValue CodeType { get; set; }

		[DataMember(Name="ImpactonTaxableWage", EmitDefaultValue=false)]
		public StringValue ImpactonTaxableWage { get; set; }

		[DataMember(Name="TaxDetailsUS", EmitDefaultValue=false)]
		public List<DeductionOrBenefitTaxDetailUS> TaxDetailsUS { get; set; }

	}
}