using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class HoldProFormaInvoice : EntityAction<ProFormaInvoice>
	{
		public HoldProFormaInvoice(ProFormaInvoice entity) : base(entity)
		{ }
	}
}
