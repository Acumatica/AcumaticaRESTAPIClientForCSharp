using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class ReleaseDisassemblyEntry : EntityAction<DisassemblyEntry>
	{
		public ReleaseDisassemblyEntry(DisassemblyEntry entity) : base(entity)
		{ }
	}
}
