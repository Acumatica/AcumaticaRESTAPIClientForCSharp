using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class DeductionsAndBenefits : Entity_v4
	{

		[DataMember(Name="DeductionAndBenefitUseClassDefaults", EmitDefaultValue=false)]
		public BooleanValue DeductionAndBenefitUseClassDefaults { get; set; }

		[DataMember(Name="DeductionsAndBenefitsDetails", EmitDefaultValue=false)]
		public List<EmployeeDeductionOrBenefitDetail> DeductionsAndBenefitsDetails { get; set; }

		[DataMember(Name="DeductionSplitMethod", EmitDefaultValue=false)]
		public StringValue DeductionSplitMethod { get; set; }

		[DataMember(Name="MaxPercOfNetPayForAllGarnishm", EmitDefaultValue=false)]
		public DecimalValue MaxPercOfNetPayForAllGarnishm { get; set; }

	}
}