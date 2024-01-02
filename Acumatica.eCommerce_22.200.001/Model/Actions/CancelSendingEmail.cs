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
	public class CancelSendingEmail : EntityAction<Email>
	{
		public CancelSendingEmail(Email entity) : base(entity)
		{ }
		public CancelSendingEmail() : base()
		{ }
	}
}
