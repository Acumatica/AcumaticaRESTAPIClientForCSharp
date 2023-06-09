using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	[DataContract]
	public class Printer : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

        [DataMember(Name = "DeviceHub", EmitDefaultValue = false)]
        public StringValue DeviceHub { get; set; }

        [DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue IsActive { get; set; }

		[DataMember(Name="PrinterName", EmitDefaultValue=false)]
		public StringValue PrinterName { get; set; }

	}
}