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
	public class MachineDetail : Entity
	{

		[DataMember(Name="MachineAccount", EmitDefaultValue=false)]
		public StringValue? MachineAccount { get; set; }

		[DataMember(Name="MachineID", EmitDefaultValue=false)]
		public StringValue? MachineID { get; set; }

		[DataMember(Name="MachineOverride", EmitDefaultValue=false)]
		public BooleanValue? MachineOverride { get; set; }

		[DataMember(Name="MachineSubaccount", EmitDefaultValue=false)]
		public StringValue? MachineSubaccount { get; set; }

		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue? StandardCost { get; set; }

	}
}