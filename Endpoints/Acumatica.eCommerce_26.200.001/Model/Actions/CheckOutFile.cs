using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_26_200_001.Model
{
	public class CheckOutFile : EntityActionWithParameters<UploadedFiles, CheckOutFileParameters>
	{
		public CheckOutFile(UploadedFiles entity, CheckOutFileParameters parameters) : base(entity, parameters)
		{ }
	}
}