using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class BOMReferenceDesignator : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue? LineID { get; set; }

		[DataMember(Name="MaterialLineID", EmitDefaultValue=false)]
		public IntValue? MaterialLineID { get; set; }

		[DataMember(Name="RefDes", EmitDefaultValue=false)]
		public StringValue? RefDes { get; set; }

	}
}