using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_21_200_001.Model
{
	public class Customers : Entity
	{

		public StringValue? InstalledAcumaticaVersion { get; set; }

		public StringValue? PartnerAccountName { get; set; }

		public StringValue? ContractID { get; set; }

		public StringValue? Customer { get; set; }

		public DateTimeValue? DateLiveISVSolution { get; set; }

		public StringValue? CustomerName { get; set; }

		public StringValue? InstalledISVVersion { get; set; }

	}
}