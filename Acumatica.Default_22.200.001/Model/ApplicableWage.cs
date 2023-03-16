using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ApplicableWage : Entity
	{

		[DataMember(Name="BenefitIncreasingApplWage", EmitDefaultValue=false)]
		public BenefitIncreasingApplWage BenefitIncreasingApplWage { get; set; }

		[DataMember(Name="DeductionsDecreasingApplWage", EmitDefaultValue=false)]
		public DeductionDecreasingApplWage DeductionsDecreasingApplWage { get; set; }

		[DataMember(Name="EarningIncreasingApplWage", EmitDefaultValue=false)]
		public EarningIncreasingApplWage EarningIncreasingApplWage { get; set; }

		[DataMember(Name="EmployeeTaxesDecreasingApplWage", EmitDefaultValue=false)]
		public TaxesDecreasingApplWage EmployeeTaxesDecreasingApplWage { get; set; }

		[DataMember(Name="EmployerTaxesIncreasingApplWage", EmitDefaultValue=false)]
		public EmployerTaxesIncreasingApplWage EmployerTaxesIncreasingApplWage { get; set; }

	}
}