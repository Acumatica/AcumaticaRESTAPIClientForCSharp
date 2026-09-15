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
	public class ApplicableWage : Entity
	{

		[DataMember(Name="BenefitIncreasingApplWage", EmitDefaultValue=false)]
		public BenefitIncreasingApplWage? BenefitIncreasingApplWage { get; set; }

		[DataMember(Name="DeductionsDecreasingApplWage", EmitDefaultValue=false)]
		public DeductionDecreasingApplWage? DeductionsDecreasingApplWage { get; set; }

		[DataMember(Name="EarningIncreasingApplWage", EmitDefaultValue=false)]
		public EarningIncreasingApplWage? EarningIncreasingApplWage { get; set; }

		[DataMember(Name="EmployeeTaxesDecreasingApplWage", EmitDefaultValue=false)]
		public TaxesDecreasingApplWage? EmployeeTaxesDecreasingApplWage { get; set; }

		[DataMember(Name="EmployerTaxesIncreasingApplWage", EmitDefaultValue=false)]
		public EmployerTaxesIncreasingApplWage? EmployerTaxesIncreasingApplWage { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string BenefitIncreasingApplWage = "BenefitIncreasingApplWage";
			public const string DeductionsDecreasingApplWage = "DeductionsDecreasingApplWage";
			public const string EarningIncreasingApplWage = "EarningIncreasingApplWage";
			public const string EmployeeTaxesDecreasingApplWage = "EmployeeTaxesDecreasingApplWage";
			public const string EmployerTaxesIncreasingApplWage = "EmployerTaxesIncreasingApplWage";

			//Intentionally excluded
			//public const string All = "BenefitIncreasingApplWage,DeductionsDecreasingApplWage,EarningIncreasingApplWage,EmployeeTaxesDecreasingApplWage,EmployerTaxesIncreasingApplWage";
		}
	}
}