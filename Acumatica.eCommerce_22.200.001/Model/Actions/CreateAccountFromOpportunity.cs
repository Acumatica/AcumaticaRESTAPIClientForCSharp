using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class CreateAccountFromOpportunity : EntityActionWithParameters<Opportunity, CreateAccountFromOpportunityParameters>
	{
		public CreateAccountFromOpportunity(Opportunity entity, CreateAccountFromOpportunityParameters parameters) : base(entity, parameters)
		{ }

		public StringValue? AccountClass
		{
			get { return Parameters.AccountClass; }
			set { Parameters.AccountClass = value; }
		}
		public StringValue? AccountName
		{
			get { return Parameters.AccountName; }
			set { Parameters.AccountName = value; }
		}
		public StringValue? BAccountID
		{
			get { return Parameters.BAccountID; }
			set { Parameters.BAccountID = value; }
		}
	}
}