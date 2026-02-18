using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ApplicableWage : Entity
	{

		public BenefitIncreasingApplWage? BenefitIncreasingApplWage { get; set; }

		public DeductionDecreasingApplWage? DeductionsDecreasingApplWage { get; set; }

		public EarningIncreasingApplWage? EarningIncreasingApplWage { get; set; }

		public TaxesDecreasingApplWage? EmployeeTaxesDecreasingApplWage { get; set; }

		public EmployerTaxesIncreasingApplWage? EmployerTaxesIncreasingApplWage { get; set; }

	}
}