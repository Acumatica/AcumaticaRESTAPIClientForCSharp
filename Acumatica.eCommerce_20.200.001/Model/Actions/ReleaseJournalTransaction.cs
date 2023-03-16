using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ReleaseJournalTransaction : EntityAction<JournalTransaction>
	{
		public ReleaseJournalTransaction(JournalTransaction entity) : base(entity)
		{ }
		public ReleaseJournalTransaction() : base()
		{ }
	}
}
