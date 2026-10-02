using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class DeductionBenefitWCCCode : Entity
	{

		#region Fields
		/// <summary>
		/// The state or province to which the deduction or benefit corresponds.The field is included in State.
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? State { get; set; }

		#endregion

		#region Details
		public List<WCCCodeRateDetail>? WCCCodeRates { get; set; }

		#endregion

	}
}