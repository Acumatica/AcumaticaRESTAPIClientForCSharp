using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class DeductionsAndBenefits : Entity
	{

		/// <summary>
		/// DAC Field Name: GrnMaxPctuseDflt 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Use Default 
		/// </summary>
		[DataMember(Name="DeductionAndBenefitUseClassDefaults", EmitDefaultValue=false)]
		public BooleanValue? DeductionAndBenefitUseClassDefaults { get; set; }

		[DataMember(Name="DeductionsAndBenefitsDetails", EmitDefaultValue=false)]
		public List<EmployeeDeductionOrBenefitDetail>? DeductionsAndBenefitsDetails { get; set; }

		/// <summary>
		/// DAC Field Name: DedSplitType 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Split Method 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="DeductionSplitMethod", EmitDefaultValue=false)]
		public StringValue? DeductionSplitMethod { get; set; }

		/// <summary>
		/// DAC Field Name: GrnMaxPctNet 
		/// DAC: PX.Objects.PR.PREmployee 
		/// Display Name: Maximum Percent of Net Pay for All Garnishments 
		/// </summary>
		[DataMember(Name="MaxPercOfNetPayForAllGarnishm", EmitDefaultValue=false)]
		public DecimalValue? MaxPercOfNetPayForAllGarnishm { get; set; }

	}
}