using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class DeductionsAndBenefits : Entity
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