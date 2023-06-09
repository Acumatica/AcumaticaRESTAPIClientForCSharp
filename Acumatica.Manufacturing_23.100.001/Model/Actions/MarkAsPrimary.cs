using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class MarkAsPrimary : EntityAction<Estimate>
	{
		public MarkAsPrimary(Estimate entity) : base(entity)
		{ }
		public MarkAsPrimary() : base()
		{ }
	}
}
