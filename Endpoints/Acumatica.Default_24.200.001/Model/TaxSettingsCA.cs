using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class TaxSettingsCA : Entity
	{

		#region Fields
		/// <summary>
		/// The benefit type that is used for reporting and calculation purposes in Canada.
		/// <para>DAC Field Name: BenefitTypeCDCAN</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Code Type</para>
		/// </summary>
		public StringValue? CodeType { get; set; }

		#endregion

		#region Details
		public List<DeductionOrBenefitTaxDetailCA>? TaxDetailsCA { get; set; }

		#endregion

	}
}