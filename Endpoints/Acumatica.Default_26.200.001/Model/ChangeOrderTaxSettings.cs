using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ChangeOrderTaxSettings : Entity
	{

		#region Fields
		public StringValue? TaxCalculationMode { get; set; }

		public StringValue? TaxExemptionNumber { get; set; }

		public StringValue? TaxExemptionType { get; set; }

		public StringValue? TaxZone { get; set; }

		#endregion

	}
}