using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class RunProjectBilling : EntityAction<Project>
	{
		public RunProjectBilling(Project entity) : base(entity)
		{ }
		public RunProjectBilling() : base()
		{ }
	}
}
