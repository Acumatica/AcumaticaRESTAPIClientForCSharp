using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class HoldProFormaInvoice : EntityAction<ProFormaInvoice>
	{
		public HoldProFormaInvoice(ProFormaInvoice entity) : base(entity)
		{ }
	}
}
