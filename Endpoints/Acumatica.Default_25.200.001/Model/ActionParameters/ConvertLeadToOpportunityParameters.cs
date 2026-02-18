using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ConvertLeadToOpportunityParameters
	{
		public ConvertLeadToOpportunityParameters() { }


		public StringValue? FirstName { get; set; }

		public StringValue? LastName { get; set; }

		public StringValue? AccountName { get; set; }

		public StringValue? JobTitle { get; set; }

		public StringValue? Phone1Type { get; set; }

		public StringValue? Phone1 { get; set; }

		public StringValue? Phone2Type { get; set; }

		public StringValue? Phone2 { get; set; }

		public StringValue? Email { get; set; }

		public StringValue? ContactClass { get; set; }

		public StringValue? BusinessAccountID { get; set; }

		public StringValue? BusinessAccountName { get; set; }

		public StringValue? BusinessAccountClass { get; set; }

		public StringValue? OpportunitySubject { get; set; }

		public StringValue? OpportunityCloseDate { get; set; }

		public StringValue? OpportunityClass { get; set; }
	}
}