using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class LinkFile : EntityActionWithParameters<UploadedFiles, LinkFileParameters>
	{
		public LinkFile(UploadedFiles entity, LinkFileParameters parameters) : base(entity, parameters)
		{ }
	}
}