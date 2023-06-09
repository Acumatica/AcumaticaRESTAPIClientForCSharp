using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class ChangeBusinessAccountID : EntityActionWithParameters<BusinessAccount, ChangeBusinessAccountIDParameters>
	{
		public ChangeBusinessAccountID() : base()
		{ }
		public ChangeBusinessAccountID(BusinessAccount entity, ChangeBusinessAccountIDParameters parameters) : base(entity, parameters)
		{ }

		public StringValue BusinessAccountID
		{
			get { return Parameters.BusinessAccountID; }
			set { Parameters.BusinessAccountID = value; }
		}
	}
}