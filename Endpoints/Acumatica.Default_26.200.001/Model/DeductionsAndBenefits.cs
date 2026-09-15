using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
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

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string DeductionsAndBenefitsDetails = "DeductionsAndBenefitsDetails";

			//Intentionally excluded
			//public const string All = "DeductionsAndBenefitsDetails";
		}
	}
}