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
	public class CreateAccountFromContact : EntityActionWithParameters<Contact, CreateAccountFromContactParameters>
	{
		public CreateAccountFromContact(Contact entity, CreateAccountFromContactParameters parameters) : base(entity, parameters)
		{ }

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
	}
}