using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class ReleaseMoveEntry : EntityAction<MoveEntry>
	{
		public ReleaseMoveEntry(MoveEntry entity) : base(entity)
		{ }
	}
}
