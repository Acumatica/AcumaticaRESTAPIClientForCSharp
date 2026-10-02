using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ApplicableWage : Entity
	{

		#region LinkedEntities
		public BenefitIncreasingApplWage? BenefitIncreasingApplWage { get; set; }

		public DeductionDecreasingApplWage? DeductionsDecreasingApplWage { get; set; }

		public EarningIncreasingApplWage? EarningIncreasingApplWage { get; set; }

		public TaxesDecreasingApplWage? EmployeeTaxesDecreasingApplWage { get; set; }

		public EmployerTaxesIncreasingApplWage? EmployerTaxesIncreasingApplWage { get; set; }

		#endregion

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