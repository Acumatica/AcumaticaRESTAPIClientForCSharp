using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class GarnishmentDetails : Entity
	{

		public DateTimeValue? GarnCourtDate { get; set; }

		public StringValue? GarnCourtName { get; set; }

		public StringValue? GarnDocRefNbr { get; set; }

		public DecimalValue? GarnOrigAmount { get; set; }

		public DecimalValue? GarnPaidAmount { get; set; }

		public StringValue? GarnVendorID { get; set; }

		public StringValue? GarnVendorInvDescr { get; set; }

	}
}