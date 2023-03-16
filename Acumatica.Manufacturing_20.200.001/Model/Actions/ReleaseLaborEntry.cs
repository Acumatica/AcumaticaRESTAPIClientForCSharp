using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class ReleaseLaborEntry : EntityAction<LaborEntry>
	{
		public ReleaseLaborEntry(LaborEntry entity) : base(entity)
		{ }
		public ReleaseLaborEntry() : base()
		{ }
	}
}
