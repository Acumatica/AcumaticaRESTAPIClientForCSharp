using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_19_200_001.Model
{
	[DataContract]
	public class UpdateScannerList : EntityAction<Scanner>
	{
		public UpdateScannerList(Scanner entity) : base(entity)
		{ }
		public UpdateScannerList() : base()
		{ }
	}
}
