using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class DeductionsAndBenefits : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: GrnMaxPctuseDflt</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Use Default</para>
		/// </summary>
		[DataMember(Name="DeductionAndBenefitUseClassDefaults", EmitDefaultValue=false)]
		public BooleanValue? DeductionAndBenefitUseClassDefaults { get; set; }

		[DataMember(Name="DeductionsAndBenefitsDetails", EmitDefaultValue=false)]
		public List<EmployeeDeductionOrBenefitDetail>? DeductionsAndBenefitsDetails { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DedSplitType</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Split Method</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="DeductionSplitMethod", EmitDefaultValue=false)]
		public StringValue? DeductionSplitMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: GrnMaxPctNet</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Maximum Percent of Net Pay for All Garnishments</para>
		/// </summary>
		[DataMember(Name="MaxPercOfNetPayForAllGarnishm", EmitDefaultValue=false)]
		public DecimalValue? MaxPercOfNetPayForAllGarnishm { get; set; }

	}
}