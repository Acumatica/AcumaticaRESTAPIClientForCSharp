using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class ReleaseInventoryIssue : EntityAction<InventoryIssue>
	{
		public ReleaseInventoryIssue(InventoryIssue entity) : base(entity)
		{ }
		public ReleaseInventoryIssue() : base()
		{ }
	}
}
