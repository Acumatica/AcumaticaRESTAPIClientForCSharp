using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class TaxSettingsCA : Entity
	{

		[DataMember(Name="CodeType", EmitDefaultValue=false)]
		public StringValue CodeType { get; set; }

		[DataMember(Name="TaxDetailsCA", EmitDefaultValue=false)]
		public List<DeductionOrBenefitTaxDetailCA> TaxDetailsCA { get; set; }

	}
}