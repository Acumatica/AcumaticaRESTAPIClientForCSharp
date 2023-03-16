using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ConvertLeadToContact : EntityAction<Lead>
	{
		public ConvertLeadToContact(Lead entity) : base(entity)
		{ }
		public ConvertLeadToContact() : base()
		{ }
	}
}
