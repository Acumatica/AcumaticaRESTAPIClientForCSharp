using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class ConvertLeadToContact : EntityActionWithParameters<Lead, ConvertLeadToContactParameters>
	{
		public ConvertLeadToContact(Lead entity, ConvertLeadToContactParameters parameters) : base(entity, parameters)
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
	}
}