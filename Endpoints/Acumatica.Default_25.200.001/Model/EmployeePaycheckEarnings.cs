using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class EmployeePaycheckEarnings : Entity
	{

		public DecimalValue? Amount { get; set; }

		public StringValue? Employee { get; set; }

		public StringValue? EmployeeType { get; set; }

		public DecimalValue? Hours { get; set; }

		public BooleanValue? ManualAmount { get; set; }

		public DecimalValue? RegularAmounttoBePaid { get; set; }

	}
}