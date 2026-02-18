using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class SubcontractTaxDetail : Entity
	{

		public DecimalValue? RetainedTax { get; set; }

		public DecimalValue? RetainedTaxable { get; set; }

		public DecimalValue? TaxableAmount { get; set; }

		public DecimalValue? TaxAmount { get; set; }

		public StringValue? TaxID { get; set; }

		public DecimalValue? TaxRate { get; set; }

		public StringValue? TaxType { get; set; }

	}
}