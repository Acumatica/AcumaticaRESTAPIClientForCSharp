using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class ConvertLeadToOpportunity : EntityActionWithParameters<Lead, ConvertLeadToOpportunityParameters>
	{
		public ConvertLeadToOpportunity(Lead entity, ConvertLeadToOpportunityParameters parameters) : base(entity, parameters)
		{ }

		public StringValue? FirstName
		{
			get { return Parameters.FirstName; }
			set { Parameters.FirstName = value; }
		}
		public StringValue? LastName
		{
			get { return Parameters.LastName; }
			set { Parameters.LastName = value; }
		}
		public StringValue? AccountName
		{
			get { return Parameters.AccountName; }
			set { Parameters.AccountName = value; }
		}
		public StringValue? JobTitle
		{
			get { return Parameters.JobTitle; }
			set { Parameters.JobTitle = value; }
		}
		public StringValue? Phone1Type
		{
			get { return Parameters.Phone1Type; }
			set { Parameters.Phone1Type = value; }
		}
		public StringValue? Phone1
		{
			get { return Parameters.Phone1; }
			set { Parameters.Phone1 = value; }
		}
		public StringValue? Phone2Type
		{
			get { return Parameters.Phone2Type; }
			set { Parameters.Phone2Type = value; }
		}
		public StringValue? Phone2
		{
			get { return Parameters.Phone2; }
			set { Parameters.Phone2 = value; }
		}
		public StringValue? Email
		{
			get { return Parameters.Email; }
			set { Parameters.Email = value; }
		}
		public StringValue? ContactClass
		{
			get { return Parameters.ContactClass; }
			set { Parameters.ContactClass = value; }
		}
		public StringValue? BusinessAccountID
		{
			get { return Parameters.BusinessAccountID; }
			set { Parameters.BusinessAccountID = value; }
		}
		public StringValue? BusinessAccountName
		{
			get { return Parameters.BusinessAccountName; }
			set { Parameters.BusinessAccountName = value; }
		}
		public StringValue? BusinessAccountClass
		{
			get { return Parameters.BusinessAccountClass; }
			set { Parameters.BusinessAccountClass = value; }
		}
		public StringValue? OpportunitySubject
		{
			get { return Parameters.OpportunitySubject; }
			set { Parameters.OpportunitySubject = value; }
		}
		public StringValue? OpportunityCloseDate
		{
			get { return Parameters.OpportunityCloseDate; }
			set { Parameters.OpportunityCloseDate = value; }
		}
		public StringValue? OpportunityClass
		{
			get { return Parameters.OpportunityClass; }
			set { Parameters.OpportunityClass = value; }
		}
	}
}