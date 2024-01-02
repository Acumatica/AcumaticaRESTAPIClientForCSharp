using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ShipViaFreightRate : Entity
	{

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="Rate", EmitDefaultValue=false)]
		public DecimalValue? Rate { get; set; }

		[DataMember(Name="Volume", EmitDefaultValue=false)]
		public DecimalValue? Volume { get; set; }

		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue? Weight { get; set; }

		[DataMember(Name="ZoneID", EmitDefaultValue=false)]
		public StringValue? ZoneID { get; set; }

	}
}